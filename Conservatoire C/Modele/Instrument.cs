using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Conservatoire_C.Modele
{
    public class Instrument
    {
        private string libelle;
    

        public Instrument(string libelle)
        {
            this.libelle = libelle;
        }

        public string Libelle { get => libelle; set => libelle = value; }

       

        public override string ToString()
        {
            return libelle;
        }
    }
}

