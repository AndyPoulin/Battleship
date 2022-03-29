using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Case
    {
        private bool bateauPresent;
        private bool caseAttaquee;
        private int taille;

        public Case(int taille)
        {
            this.taille = taille;
            bateauPresent = false;
            caseAttaquee = false;
        }

        public bool BateauPresent { get => bateauPresent; set => bateauPresent = value; }
        public bool CaseAttaquee { get => caseAttaquee; set => caseAttaquee = value; }
        public int Taille { get => taille; set => taille = value; }

        public Bitmap Dessiner(bool estAdverse)
        {
            Bitmap imageCase = new Bitmap(taille, taille);
            using (Graphics graphiques = Graphics.FromImage(imageCase))
            {
                Rectangle fond = new Rectangle(0, 0, taille, taille);
                graphiques.FillRectangle(TrouverCouleur(estAdverse), fond);

                if (caseAttaquee)
                {
                    Rectangle cercleRouge = new Rectangle(0, 0, taille, taille);
                    graphiques.FillEllipse(new SolidBrush(Color.Red), cercleRouge);
                }
            }
            return imageCase;
        }

        private Brush TrouverCouleur(bool estAdverse)
        {
            if (bateauPresent && !estAdverse) return new SolidBrush(Color.Gray);
            else if (bateauPresent && caseAttaquee) return new SolidBrush(Color.Gray);
            return new SolidBrush(Color.Blue);
        }

        public void AEteClick()
        {
            
        }
    }
}
