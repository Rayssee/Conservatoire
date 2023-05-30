namespace Conservatoire_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxPersonne = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPersonne
            // 
            this.listBoxPersonne.FormattingEnabled = true;
            this.listBoxPersonne.ItemHeight = 16;
            this.listBoxPersonne.Location = new System.Drawing.Point(33, 40);
            this.listBoxPersonne.Name = "listBoxPersonne";
            this.listBoxPersonne.Size = new System.Drawing.Size(715, 244);
            this.listBoxPersonne.TabIndex = 0;
            this.listBoxPersonne.SelectedIndexChanged += new System.EventHandler(this.listBoxPersonne_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ajoutez prof";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(54, 362);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Supprimer prof";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Éleve du Conservatoire";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(580, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Scéance du Prof";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPersonne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPersonne;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

