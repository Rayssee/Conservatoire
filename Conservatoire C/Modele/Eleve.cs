﻿using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_C.Modele
{
    public class Eleve
    {
        private int id;
        private string nom;
        private string prenom;
        private int tel;
        private string mail;
        private string adresse;
        private int bourse;

       

        public Eleve(int id, string nom, string prenom, int tel, string mail, string adresse, int bourse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.adresse = adresse;
            this.bourse = bourse;
        }

        //surcharge du constructeur
        public Eleve(int id, string nom, string prenom, int tel, string mail, string adresse)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.adresse = adresse;  
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int Bourse { get => bourse; set => bourse = value; }


        public override string ToString()
        {
            return id + " -- Nom: " + nom + ",  Prenom: " + prenom + ",  Telephone: " + tel + ",  Mail: " + mail + ",  Adresse: " + adresse + ",  Bourse: " + bourse;
        }
    }
}
