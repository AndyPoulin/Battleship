
namespace Battleship
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
            this.lblJoueur = new System.Windows.Forms.Label();
            this.lblOrdi = new System.Windows.Forms.Label();
            this.PBjoueur = new System.Windows.Forms.PictureBox();
            this.PBordinateur = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBjoueur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBordinateur)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(9, 9);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(93, 13);
            this.lblJoueur.TabIndex = 0;
            this.lblJoueur.Text = "Bateaux du joueur";
            // 
            // lblOrdi
            // 
            this.lblOrdi.AutoSize = true;
            this.lblOrdi.Location = new System.Drawing.Point(9, 328);
            this.lblOrdi.Name = "lblOrdi";
            this.lblOrdi.Size = new System.Drawing.Size(115, 13);
            this.lblOrdi.TabIndex = 1;
            this.lblOrdi.Text = "Bateaux de l\'ordinateur";
            // 
            // PBjoueur
            // 
            this.PBjoueur.Location = new System.Drawing.Point(9, 25);
            this.PBjoueur.Name = "PBjoueur";
            this.PBjoueur.Size = new System.Drawing.Size(300, 300);
            this.PBjoueur.TabIndex = 2;
            this.PBjoueur.TabStop = false;
            this.PBjoueur.Paint += new System.Windows.Forms.PaintEventHandler(this.AfficherGrilleJoueur);
            // 
            // PBordinateur
            // 
            this.PBordinateur.Location = new System.Drawing.Point(9, 344);
            this.PBordinateur.Name = "PBordinateur";
            this.PBordinateur.Size = new System.Drawing.Size(300, 300);
            this.PBordinateur.TabIndex = 3;
            this.PBordinateur.TabStop = false;
            this.PBordinateur.Paint += new System.Windows.Forms.PaintEventHandler(this.AfficherGrilleOrdinateur);
            this.PBordinateur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JoueurClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 650);
            this.Controls.Add(this.PBordinateur);
            this.Controls.Add(this.PBjoueur);
            this.Controls.Add(this.lblOrdi);
            this.Controls.Add(this.lblJoueur);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBjoueur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBordinateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJoueur;
        private System.Windows.Forms.Label lblOrdi;
        private System.Windows.Forms.PictureBox PBjoueur;
        private System.Windows.Forms.PictureBox PBordinateur;
    }
}

