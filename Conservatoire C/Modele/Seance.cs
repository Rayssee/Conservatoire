using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_C.Modele
{
    public class Seance
    {
        private int id;
        private int numseance;
        private string tranche;
        private string jour;
        private int niveau;
        private int capacite;

       public Seance(int id, int numseance, string tranche, string jour, int niveau, int capacite)
        {
            this.id = id;
            this.numseance = numseance;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;
        }

        public int Id { get => id; set => id = value; }
        public int Numseance { get => numseance; set => numseance = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public string Jour { get => jour; set => jour = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }



        public override string ToString()
        {
            return " Tranche horaire : " + tranche + " , Jour : " + jour + " , Niveau : " + niveau + ", capacite : " + capacite;
        }
    }


    
}
