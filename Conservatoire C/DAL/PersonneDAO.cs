using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Conservatoire_C.Modele;
using Connecte;
using Org.BouncyCastle.Ocsp;
using static Mysqlx.Notice.Warning.Types;

namespace Conservatoire_C.DAL
{
    public class PersonneDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "tconservatoire";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;



        public static List<Professeur> getPersonne()
        {

            List<Professeur> lc = new List<Professeur>();

            try
            {

                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("SELECT IDPROF, ID, nom, prenom, tel, mail, adresse, instrument, salaire FROM prof JOIN personne ON prof.IDPROF = personne.ID");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Professeur p;



                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération de la ligne
                    int unIdProf = (int)reader.GetValue(0);
                    int unId = (int)reader.GetValue(1);
                    string unNom = (string)reader.GetValue(2);
                    string unPrenom = (string)reader.GetValue(3);
                    int unTel = (int)reader.GetValue(4);
                    string unMail = (string)reader.GetValue(5);
                    string uneAdresse = (string)reader.GetValue(6);
                    string unInstrument = (string)reader.GetValue(7);
                    double unSalaire = (double)reader.GetValue(8);


                    //Instanciation d'un Emplye
                    p = new Professeur(unId, unNom, unPrenom, unTel, unMail, uneAdresse, unInstrument, unSalaire);

                    // Ajout de cet employe à la liste 
                    lc.Add(p);


                }


                // fermeture de la connexion
                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }


            catch (Exception emp)
            {

                throw (emp);

            }


        }

        public static bool connexion(string login, string password)
        {
            bool connect = false;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                string query = "SELECT COUNT(*) FROM admin WHERE login = @login AND mdp = @password";
                Ocom = maConnexionSql.reqExec(query);
                Ocom.Parameters.AddWithValue("@login", login);
                Ocom.Parameters.AddWithValue("@password", password);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    if ((Int64)reader.GetValue(0) == 1)
                    {
                        connect = true;
                    }
                }

                reader.Close();
                maConnexionSql.closeConnection();
                return (connect);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static void ajoutProf(int id, string nom, string prenom, int tel, string mail, string adresse, string instrument, double salaire)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("INSERT INTO personne (ID, nom, prenom, tel, mail, adresse) VALUES (@ID, @nom, @prenom, @tel, @mail, @adresse)");
                Ocom.Parameters.AddWithValue("@ID", id);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);
                Ocom.ExecuteNonQuery();



                Ocom = maConnexionSql.reqExec("INSERT INTO prof (IDPROF, instrument, salaire) VALUES (@IDPROF, @instrument, @salaire)");
                Ocom.Parameters.AddWithValue("@IDPROF", id);
                Ocom.Parameters.AddWithValue("@instrument", instrument);
                Ocom.Parameters.AddWithValue("@salaire", salaire);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static int recuperationDernierId()
        {
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
            maConnexionSql.openConnection();

            Ocom = maConnexionSql.reqExec("SELECT MAX(ID) FROM personne");
            MySqlDataReader reader = Ocom.ExecuteReader();

            int dernierId = 0;
            try
            {
                while (reader.Read())
                {
                    dernierId = (int)reader.GetValue(0);


                }

                reader.Close();

                maConnexionSql.closeConnection();

                return (dernierId);

            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }


        public static List<Instrument> getInstrument()
        {
            List<Instrument> lesInstruments = new List<Instrument>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT * FROM instrument");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Instrument i;

                while (reader.Read())
                {
                    string libelle = (string)reader.GetValue(0);

                    i = new Instrument(libelle);
                    lesInstruments.Add(i);
                }
                reader.Close();

                maConnexionSql.closeConnection();

                return (lesInstruments);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static List<Eleve> GetEleves()
        {
            List<Eleve> eleves = new List<Eleve>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT  ID, IDELEVE, nom, prenom, tel, mail, adresse, bourse FROM eleve JOIN personne ON eleve.IDELEVE = personne.ID");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;

                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    int ideleve = (int)reader.GetValue(1);
                    string nom = (string)reader.GetValue(2);
                    string prenom = (string)reader.GetValue(3);
                    int tel = (int)reader.GetValue(4);
                    string mail = (string)reader.GetValue(5);
                    string adresse = (string)reader.GetValue(6);
                    int bourse = (int)reader.GetValue(7);



                    e = new Eleve(id, nom, prenom, tel, mail, adresse, bourse);
                    eleves.Add(e);
                }
                reader.Close();

                maConnexionSql.closeConnection();

                return (eleves);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static List<Trimestre> GetTrimestres()
        {

            List<Trimestre> list = new List<Trimestre>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT * FROM trim");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Trimestre t;

                while (reader.Read())
                {


                    string libelle = (string)reader.GetValue(0);
                    string datefin = (string)reader.GetValue(1);




                    t = new Trimestre(libelle, datefin);
                    list.Add(t);
                }
                reader.Close();

                maConnexionSql.closeConnection();

                return (list);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static bool verifpayement(int idselectionnereleve, string libelle)
        {
            bool res = false;

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT COUNT(*) as nbre FROM payer WHERE IDELEVE = @ideleve AND LIBELLE = @libelle AND PAYE = 1");
                Ocom.Parameters.AddWithValue("@ideleve", idselectionnereleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);
                MySqlDataReader reader = Ocom.ExecuteReader();



                while (reader.Read())
                {
                    Int64 Resultat = (Int64)reader.GetValue(0);
                    if (Resultat > 0)
                    {
                        res = true;
                    }

                }
                reader.Close();

                maConnexionSql.closeConnection();


            }

            catch (Exception emp)
            {

                throw (emp);

            }

            return res;
        }

        public static Trimestre detaillepayement(int idselectionnereleve, string libelle)
        {
           
            Trimestre Trim = new Trimestre(0, "", "", 0);
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                string queryString = "SELECT * FROM payer where IDELEVE = @idEleve AND LIBELLE = @libelle";


                Ocom = maConnexionSql.reqExec(queryString);

                Ocom.Parameters.AddWithValue("@ideleve", idselectionnereleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);

                maConnexionSql.openConnection();

         
                MySqlDataReader reader = Ocom.ExecuteReader();

                

                while (reader.Read())
                {


                    int ideleve = (int)reader.GetValue(0);
                    string libellepaye = (string)reader.GetValue(1);
                    string datepayement = (string)reader.GetValue(2);
                    int paye = (int)reader.GetValue(3);



                    Trim = new Trimestre(ideleve, libellepaye, datepayement, paye);

                    
                }
                reader.Close();

                maConnexionSql.closeConnection();

                return (Trim);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static void Inserpay(int idEleve, string libelle)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                string queryString = "INSERT INTO payer (IDELEVE, LIBELLE, DATEPAEMENT, PAYE) VALUES (@idEleve, @libelle, NOW(), 1)";


                Ocom = maConnexionSql.reqExec(queryString);
                Ocom.Parameters.AddWithValue("@ideleve", idEleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);

                maConnexionSql.openConnection();
                Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
               
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }


    }
}



   






