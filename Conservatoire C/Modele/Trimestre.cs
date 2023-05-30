using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_C.Modele
{
    public class Trimestre
    {
        private string libelle;
        private string datefin;
        private int ideleve;
        private int payer;
        private string datepayement;
       

        public Trimestre(string libelle, string datefin)
        {
            this.libelle = libelle;
            this.datefin = datefin;
      
        }

        public Trimestre(int ideleve, string libelle, string datepayement, int payer)
        {
            this.ideleve = ideleve;
            this.libelle = libelle;
            this.datepayement = datepayement;
            this.payer = payer;
        }

        

        public string Libelle { get => libelle; set => libelle = value; }
        public string Datefin { get => datefin; set => datefin = value; }
        public int Ideleve { get => ideleve; set => ideleve = value; }
        public int Payer { get => payer; set => payer = value; }
        public string Datepayement { get => datepayement; set => datepayement = value; }


        public override string ToString()
        {
            if(payer== 1)
            {
                return libelle + " payé le : " + datepayement;
            }
            else
            {

                return libelle + " non payé, date limite pour le payement : " + datefin;

            }
        }
    }
}
