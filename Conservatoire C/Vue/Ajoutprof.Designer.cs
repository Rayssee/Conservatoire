namespace Conservatoire_C.Vue
{
    partial class AjoutProf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Nom = new System.Windows.Forms.TextBox();
            this.Salaire = new System.Windows.Forms.TextBox();
            this.Adresse = new System.Windows.Forms.TextBox();
            this.Tel = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Prenom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Instrument1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(73, 35);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(86, 22);
            this.Nom.TabIndex = 0;
            // 
            // Salaire
            // 
            this.Salaire.Location = new System.Drawing.Point(173, 301);
            this.Salaire.Name = "Salaire";
            this.Salaire.Size = new System.Drawing.Size(86, 22);
            this.Salaire.TabIndex = 1;
            // 
            // Adresse
            // 
            this.Adresse.Location = new System.Drawing.Point(73, 223);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(86, 22);
            this.Adresse.TabIndex = 2;
            // 
            // Tel
            // 
            this.Tel.Location = new System.Drawing.Point(73, 132);
            this.Tel.Name = "Tel";
            this.Tel.Size = new System.Drawing.Size(86, 22);
            this.Tel.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(274, 132);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(86, 22);
            this.Email.TabIndex = 4;
            // 
            // Prenom
            // 
            this.Prenom.Location = new System.Drawing.Point(274, 35);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(86, 22);
            this.Prenom.TabIndex = 5;
            this.Prenom.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter le professeur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Instrument1
            // 
            this.Instrument1.FormattingEnabled = true;
            this.Instrument1.Location = new System.Drawing.Point(273, 223);
            this.Instrument1.Name = "Instrument1";
            this.Instrument1.Size = new System.Drawing.Size(87, 24);
            this.Instrument1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Instrument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Téléphone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Prenom";
            // 
            // AjoutProf
            // 
            this.ClientSize = new System.Drawing.Size(425, 480);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instrument1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Tel);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Salaire);
            this.Controls.Add(this.Nom);
            this.Name = "AjoutProf";
            this.Load += new System.EventHandler(this.AjoutProf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.TextBox Salaire;
        private System.Windows.Forms.TextBox Adresse;
        private System.Windows.Forms.TextBox Tel;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Prenom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Instrument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}