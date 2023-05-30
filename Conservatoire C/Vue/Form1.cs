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
using Conservatoire_C.Vue;

namespace Conservatoire_C
{
    public partial class Form1 : Form
    {

        Admin monAdmin;

        List<Professeur> lPers = new List<Professeur>();



        public Form1()
        {
            InitializeComponent();

            monAdmin = new Admin();
        }

        private void Form1_Load(object sender, EventArgs p)
        {


            lPers = monAdmin.chargementProfBD();


            affiche();
        }

        public void affiche()

        {


            try
            {

                // Initialisation de la listbox
                listBoxPersonne.DataSource = null;
                // lier la listbox avec la collection
                listBoxPersonne.DataSource = lPers;
                // Affichage des employes en utilisant la Propriété Description de la class Employe
                listBoxPersonne.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void listBoxPersonne_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


            private void button1_Click(object sender, EventArgs e)
            {

                AjoutProf afficherAjoutProf = new AjoutProf();
                afficherAjoutProf.ShowDialog();
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listeEleve lesEleves=new listeEleve();
            lesEleves.ShowDialog();
        }
    }
}
