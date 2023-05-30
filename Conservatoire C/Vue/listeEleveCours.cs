using Conservatoire_C.Controleur;
using Conservatoire_C.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatoire_C.Vue
{
    public partial class listeEleveCours : Form
    {
        Seance eleves;
        List<Eleve> elevesList = new List<Eleve>();
        Seance Se;
        private Séance_du_prof idseance;


        public listeEleveCours(Seance numseance)
        {

            InitializeComponent();
            this.Se = numseance;
            int numSeance = numseance.Numseance;

            elevesList = Admin.chargementEleves(numSeance);

            affiche();
            if (elevesList.Count == 0)
            {
                MessageBox.Show("Aucun élèves n'est inscrit à ce cours");
            }
        }

        public listeEleveCours(Séance_du_prof idseance)
        {
            this.idseance = idseance;
        }


        public void affiche()

        {


            try
            {

                // Initialisation de la listbox
                listBox1.DataSource = null;
                // lier la listbox avec la collection
                listBox1.DataSource = elevesList;
                // Affichage des employes en utilisant la Propriété Description de la class Employe
                listBox1.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
