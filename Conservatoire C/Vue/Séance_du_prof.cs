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
    public partial class Séance_du_prof : Form
    {

        Séance_du_prof seance;
        List<Seance> lesseances = new List<Seance>();
        Professeur professeur;
        public Séance_du_prof(Professeur prof)
        {
            InitializeComponent();
            professeur=prof;    
            int idprof = prof.Id;

            lesseances = Admin.chargementSeance(idprof);

            button1.Show();
            affiche();
        }

        public void affiche()

        {


            try
            {

                // Initialisation de la listbox
                listBox1.DataSource = null;
                // lier la listbox avec la collection
                listBox1.DataSource = lesseances;
                // Affichage des employes en utilisant la Propriété Description de la class Employe
                listBox1.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seance numseance = (Seance)listBox1.SelectedItem;
            listeEleveCours nbrEleve = new listeEleveCours(numseance);
            nbrEleve.ShowDialog();

        }
    }
}
