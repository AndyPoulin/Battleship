using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    class Grille
    {
        private int largeurGrille;
        private bool estAdverse;
        private int tailleDesCases;
        private int nbBateaux;
        private Case[,] tableauCases;

        public Grille(int largeurGrille, bool estAdverse, int tailleDesCases, int nbBateaux)
        {
            this.largeurGrille = largeurGrille;
            this.estAdverse = estAdverse;
            this.tailleDesCases = tailleDesCases;
            this.nbBateaux = nbBateaux;
            tableauCases = new Case[largeurGrille, largeurGrille];

            for (int x = 0; x < largeurGrille; x++)
            {
                for (int y = 0; y < largeurGrille; y++)
                {
                    tableauCases[x, y] = new Case(tailleDesCases);
                }
            }

            PlacerBateauxHasard(nbBateaux);
        }

        public int Taille { get => largeurGrille; set => largeurGrille = value; }
        public bool EstAdverse { get => estAdverse; set => estAdverse = value; }
        public int TailleDesCases { get => tailleDesCases; set => tailleDesCases = value; }
        public Case[,] TableauCases { get => tableauCases; set => tableauCases = value; }

        public void Click(int x, int y)
        {
            int caseX = (int)Math.Floor((double)x / tailleDesCases);
            int caseY = (int)Math.Floor((double)y / tailleDesCases);

            tableauCases[caseX, caseY].CaseAttaquee = true;
        }

        public void JouerTourDeOrdi()
        {
            Random rand = new Random();

            int randX = rand.Next(tableauCases.GetLength(0));
            int randY = rand.Next(tableauCases.GetLength(1));

            tableauCases[randX, randY].CaseAttaquee = true;
        }

        public Bitmap Afficher()
        {
            Bitmap bitmapGrille = new Bitmap(largeurGrille * tailleDesCases, largeurGrille * tailleDesCases);

            using (Graphics graphiques = Graphics.FromImage(bitmapGrille))
            {
                Brush couleurDeFond = new SolidBrush(Color.Blue);
                Brush couleurDeGrille = new SolidBrush(Color.Black);
                for (int x = 0; x < largeurGrille; x++)
                {
                    for (int y = 0; y < largeurGrille; y++)
                    {
                        Bitmap bitmapCase = tableauCases[x, y].Dessiner(estAdverse);
                        graphiques.DrawImage(bitmapCase, x * tailleDesCases, y * tailleDesCases);
                    }
                }

                Pen p = new Pen(Color.Black);
                for (int y = 0; y < largeurGrille; ++y)
                {
                    graphiques.DrawLine(p, 0, y * tailleDesCases, largeurGrille * tailleDesCases, y * tailleDesCases);
                }

                for (int x = 0; x < largeurGrille; ++x)
                {
                    graphiques.DrawLine(p, x * tailleDesCases, 0, x * tailleDesCases, largeurGrille * tailleDesCases);
                }
            }

            return bitmapGrille;
        }

        public void PlacerBateauxHasard(int nbBateaux)
        {
            Random rand = new Random();

            int nbDeBateauxPresents = 0;
            while (nbDeBateauxPresents < nbBateaux)
            {
                int randX = rand.Next(tableauCases.GetLength(0));
                int randY = rand.Next(tableauCases.GetLength(1));

                if (!tableauCases[randX, randY].BateauPresent)
                {
                    tableauCases[randX, randY].BateauPresent = true;
                    nbDeBateauxPresents++;
                }
            }
        }

        public bool VerifierGagner()
        {
            int bateauxTouchés = 0;
            for (int x = 0; x < tableauCases.GetLength(0); x++)
            {
                for (int y = 0; y < tableauCases.GetLength(1); y++)
                {
                    if (tableauCases[x, y].BateauPresent && tableauCases[x, y].CaseAttaquee) bateauxTouchés++;
                }
            }

            if (bateauxTouchés == nbBateaux)
            {
                if (estAdverse) MessageBox.Show("Vous avez gagné", "asfdlo");
                else if (!estAdverse) MessageBox.Show("Vous avez perdu", "asfdlo");

                return true;
            }

            return false;
        }
    }
}
