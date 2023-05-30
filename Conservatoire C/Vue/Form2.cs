using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conservatoire_C.Controleur;
using Conservatoire_C.Modele;

namespace Conservatoire_C.Vue
{
    public partial class Form2 : Form
    {
        Admin admin = new Admin() ;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer votre login et mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool connect = admin.connexion(login, password);

            if (connect == true)
            {
                this.Hide();
                Form1 connexion = new Form1();
                connexion.ShowDialog();
            }
            else
            {
                Console.WriteLine("connexion échoué");
            }
        }

    }
}
