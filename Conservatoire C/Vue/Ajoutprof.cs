using Conservatoire_C.Controleur;
using Conservatoire_C.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conservatoire_C.Vue
{
    public partial class AjoutProf : Form
    {
        Instrument instrument;
        List<Instrument> lesInstruments = new List<Instrument>();
        int id;
        public AjoutProf()
        {
            InitializeComponent();

            lesInstruments = Admin.chargementInstrument();
            id = PersonneDAO.recuperationDernierId() + 1;
            affiche();
        }

        public void affiche()
        {
            try
            {
                Instrument1.DataSource = null;
                Instrument1.DataSource = lesInstruments;
                Instrument1.DisplayMember = "Description";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            string nom = Nom.Text;
            string prenom = Prenom.Text;
            int telephone = Convert.ToInt32(Tel.Text);
            string email = Email.Text;
            string adresse = Adresse.Text;
            string instrument = Instrument1.Text;
            double salaire = Convert.ToDouble(Salaire.Text);

            Admin.ajoutProf(id, nom, prenom, telephone, email, adresse, instrument, salaire);

            MessageBox.Show("Le professeur a bien été ajouté");
        }

        private void AjoutProf_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}