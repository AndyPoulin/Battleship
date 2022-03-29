using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitialiserGrilles();
        }

        int largeurGrille = 5;
        int nbBateaux = 5;

        Grille grilleJoueur;
        Grille grilleOrdinateur;

        private void InitialiserGrilles()
        {
            grilleJoueur = new Grille(largeurGrille, false, PBjoueur.Width / largeurGrille, nbBateaux);
            grilleOrdinateur = new Grille(largeurGrille, true, PBordinateur.Width / largeurGrille, nbBateaux);
            RedessinerGrilles();
        }

        private void AfficherGrilleJoueur(object sender, PaintEventArgs e)
        {
            Bitmap imageGrille = grilleJoueur.Afficher();
            e.Graphics.DrawImage(imageGrille, 0, 0);
        }

        private void AfficherGrilleOrdinateur(object sender, PaintEventArgs e)
        {
            Bitmap imageGrille = grilleOrdinateur.Afficher();
            e.Graphics.DrawImage(imageGrille, 0, 0);
        }

        private void JoueurClick(object sender, MouseEventArgs e)
        {
            grilleOrdinateur.Click(e.X, e.Y);
            grilleJoueur.JouerTourDeOrdi();
            RedessinerGrilles();

            if (grilleJoueur.VerifierGagner() || grilleOrdinateur.VerifierGagner()) InitialiserGrilles();
        }

        private void RedessinerGrilles()
        {
            PBordinateur.Refresh();
            PBjoueur.Refresh();
        }
    }
}
