using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatoire_C.Modele;
using Conservatoire_C.DAL;

namespace Conservatoire_C.Controleur
{
    internal class Admin
    {
        // Crée un objet
        PersonneDAO persDAO = new PersonneDAO();

        List<Professeur> maListeProfesseur;

        public Admin()
        {

            maListeProfesseur = new List<Professeur>();
        }

        public List<Professeur> chargementProfBD()
        {

            maListeProfesseur = PersonneDAO.getPersonne();

            return (maListeProfesseur);
        }

        public bool connexion(string login, string password)
        {
            bool Lespers=PersonneDAO.connexion(login, password);
            return Lespers;
        }


        public static void ajoutProf(int id, string nom, string prenom, int tel, string mail, string adresse, string instrument, double salaire)
        {
            PersonneDAO.ajoutProf(id, nom, prenom, tel, mail, adresse, instrument, salaire);
        }


        public static List<Instrument> chargementInstrument()
        {

            List<Instrument> maListeInstrument = PersonneDAO.getInstrument();

            return maListeInstrument;
        }

        public List<Eleve> GetEleves()
        {
            List<Eleve> lesEleves = PersonneDAO.GetEleves();
            return lesEleves;
        }

        public List<Trimestre> GetTrimestreseleves(int idselectionnereleve)
        {
            List<Trimestre> lesTrimestres = PersonneDAO.GetTrimestres();
            List<Trimestre> lesTrimestreseleves = new List<Trimestre>();

            foreach(Trimestre unTrimestre in lesTrimestres)
            {
                string libelle = unTrimestre.Libelle;
                bool verifpaye = PersonneDAO.verifpaiement(idselectionnereleve, libelle);
                if (verifpaye == true)
                {
                    Trimestre payeOui = PersonneDAO.detaillepaiement(idselectionnereleve, libelle);
                    lesTrimestreseleves.Add(payeOui);
                    
                }
                else
                {
                    lesTrimestreseleves.Add(unTrimestre);
                }
            }
            return (lesTrimestreseleves);

        }

        public static void Inserpay(int idEleve, string libelle)
        {
            PersonneDAO.Inserpay(idEleve, libelle);

        }

        public static List<Seance> chargementSeance(int idProf)
        {
            List<Seance> lesseances = PersonneDAO.chargementSeance(idProf);
            return lesseances;
        }


        public static List<Eleve> chargementEleves(int numSeance)
        {
            List<Eleve> listEleves = PersonneDAO.chargementEleves(numSeance);
            return (listEleves);
        }
    }


}
