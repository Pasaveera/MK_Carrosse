using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK_Carosse
{
    class MonRectangleRotation:MonPoint
    {
        #region Données menbres
        private Color _pot = Color.Gray;
        private bool _remplir = true;
        private int _longueur = 1, _hauteur = 1;
        private double angle;
        #endregion

        public double Angle { get => angle; set => angle = value; }
        public int Longueur { get => _longueur; set => _longueur = value; }
        public int Hauteur { get => _hauteur; set => _hauteur = value; }


        #region Constructor
        public MonRectangleRotation() : base()
        {
        }
        public MonRectangleRotation(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            this.Angle = 0f;
            this.X = xsg;
            this.Y = ysg;
            Longueur = longueur;
            Hauteur = hauteur;
        }
        public MonRectangleRotation(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            this.Angle = 0f;
            this.X = xsg;
            this.Y = ysg;
            Longueur = longueur;
            Hauteur = hauteur;
            this._pot = pot;
        }
        #endregion

        #region Methods
        public virtual void Bouger(int deplX, int deplY,double diffangle)
        {
            this.Bouger(deplX, deplY,diffangle); 
        }
        public override void Cacher(Graphics g)
        {
            this.Cacher(g);
        }
        public override void Afficher(Graphics g)
        {
            this.Afficher(g);
        }
        #endregion

    }
}
