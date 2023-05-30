using Conservatoire_C.Controleur;
using Conservatoire_C.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatoire_C.Vue
{
    public partial class listeEleve : Form
    {
        Admin admin;

        List<Eleve> lesEleves=new List<Eleve>();
        List<Trimestre> lesTrimestres = new List<Trimestre>();
        public listeEleve()
        {
            InitializeComponent();
            admin=new Admin();
            lesEleves = admin.GetEleves();
            affiche();
        }
        public void affiche()
        {
            try
            {
                listBox1.DataSource = null;
                listBox1.DataSource = lesEleves;
                listBox1.DisplayMember = "Description";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public void afficheTrimestres()
        {
            try
            {
                listBox2.DataSource = null;
                listBox2.DataSource = lesTrimestres;
                listBox2.DisplayMember = "Description";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eleve selectionnereleve = (Eleve)listBox1.SelectedItem;
            int idselectionnereleve = selectionnereleve.Id;
            lesTrimestres = admin.GetTrimestreseleves(idselectionnereleve);
            afficheTrimestres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleve leleve = (Eleve)listBox1.SelectedItem;
            int idEleve = leleve.Id;
            Trimestre trimeleve = (Trimestre)listBox2.SelectedItem;
            string libelle = trimeleve.Libelle;

            Admin.Inserpay(idEleve, libelle);

            lesTrimestres = admin.GetTrimestreseleves(idEleve);
            afficheTrimestres();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((Trimestre)listBox2.SelectedItem != null)
            {
                Trimestre trimeleve = (Trimestre)listBox2.SelectedItem;
                int etatpaiement = trimeleve.Payer;
                if (etatpaiement == 0)
                {
                    string datepaiement = trimeleve.Datefin;
                    DateTime dateTrimestre = DateTime.ParseExact(datepaiement, "dd/MM/yyyy", new CultureInfo("fr-FR", true));
                    DateTime todayDate = DateTime.Today;

                    if(dateTrimestre >= todayDate)
                    {
                        button1.Show();
                    }
                    else
                    {
                        button1.Hide();
                    }

                }
                else
                {
                    button1.Hide();
                }
            }
            else
            {
                button1.Hide();
            }
        }
    }
}
