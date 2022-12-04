using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK_Carosse
{
    class MonRectangle:MonPoint
    {
        #region Données membres
        private Color _Pot = Color.Red;
        private bool _Remplir = true;
        private int _Longueur = 1, _Hauteur = 1;
        #endregion

        #region Constructeurs
        public MonRectangle(): base()
        {
        }
        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
        }
        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        public MonRectangle(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot): base(hebergeur, xsg, ysg, crayon)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        #endregion

        #region Accesseurs
        public int Longueur
        {
            get { return _Longueur; }
            set
            {
                if (value < 0) { _Longueur = 1; }
                else { _Longueur = value; }
            }
        }
        public int Hauteur
        {
            get { return _Hauteur; }
            set
            {
                if (value < 0) { _Hauteur = 1; }
                else { _Hauteur = value; }
            }
        }
        public bool Remplir
        {
            get { return _Remplir; }
            set { _Remplir = value; }
        }
        public Color Pot
        {
            get { return _Pot; }
            set
            {
                try { _Pot = value; }
                catch (Exception) { }
            }
        }
        #endregion

        #region Méthodes
        public override void Cacher(Graphics gr)
        {
            if (this.Remplir)
            {
                gr.FillRectangle(new SolidBrush(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
            }
            gr.DrawRectangle(new Pen(this.Fond), this.X, this.Y, this.Longueur, this.Hauteur);
        }
        public override void Afficher(Graphics gr)
        {
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillRectangle(new SolidBrush(this.Pot), this.X, this.Y, this.Longueur, this.Hauteur);
                }
                gr.DrawRectangle(new Pen(this.Crayon), this.X, this.Y, this.Longueur, this.Hauteur);
            }
        }
        #endregion
    }
}
