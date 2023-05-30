using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_C.Modele
{
    public class Professeur
    {
        private int id;
        private string nom;
        private string prenom;
        private int tel;
        private string mail;
        private string adresse;
        private string instrument;
        private double salaire;
        
        

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Instrument { get => instrument; set => instrument = value; }
        public double Salaire { get => Salaire; set => salaire = value; }




        // Constructeur vide



        public Professeur(int unId, string unNom, string unPrenom, int unTel, string unMail, string uneAdresse, string unInstrument, double unSalaire)
        {
            this.id = unId;
            this.nom = unNom;   
            this.prenom = unPrenom;
            this.tel = unTel;
            this.mail = unMail;
            this.adresse = uneAdresse;
            this.instrument = unInstrument;
            this.salaire = unSalaire;
            

        }

       

        //pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Nom :" + this.nom + " Prenom : " + this.prenom + " Tel : " + this.tel + " Mail : " + this.mail + " Adresse : " + this.adresse + " Instrument : " + this.instrument + " Salaire : " + this.salaire;
        } 
    }
}
