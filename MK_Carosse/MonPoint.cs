using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MK_Carosse
{
    class MonPoint
    {
        #region Données membres
        private int _x = 0;
        private int _y = 0;
        private bool _visible = true;
        private PictureBox _hebergeur;
        private Color _fond = Color.Silver;
        private Color _crayon = Color.Black;
        #endregion

        #region Accesseurs
        public int X
        {
            get { return this._x; }
            set
            {
                if (value < 0) this._x = 0;
                else if (value > this._hebergeur.Bounds.Size.Width) this._x = this._hebergeur.Bounds.Size.Width;
                else this._x = value;
            }
        }
        public int Y
        {
            get { return this._y; }
            set
            {
                if (value < 0) this._y = 0;
                else if (value > this._hebergeur.Bounds.Size.Height) this._y = this._hebergeur.Bounds.Size.Height;
                else this._y = value;
            }
        }
        public bool Visible
        {
            get { return this._visible; }
            set { this._visible = value; }
        }
        public Color Fond
        {
            get { return this._fond; }
            set
            {
                try { this._fond = value; }
                catch { }
            }
        }
        public Color Crayon
        {
            get { return this._crayon; }
            set
            {
                try { this._crayon = value; }
                catch { }
            }
        }
        public PictureBox Hebergeur
        {
            get { return this._hebergeur; }
            set { this._hebergeur = value; }
        }
        #endregion

        #region Constructeurs
        public MonPoint()
        {
            this._hebergeur = null;
        }
        public MonPoint(PictureBox hebergeur)
        {
            this._hebergeur = hebergeur;
            Fond = hebergeur.BackColor;
        }
        public MonPoint(PictureBox hebergeur, int xy) : this(hebergeur)
        {
            X = Y = xy;
        }
        public MonPoint(PictureBox hebergeur, int x, int y) : this(hebergeur)
        {
            X = x;
            Y = y;
        }
        public MonPoint(PictureBox hebergeur, int xy, Color crayon) : this(hebergeur, xy)
        {
            Crayon = crayon;
        }
        public MonPoint(PictureBox hebergeur, int x, int y, Color crayon) : this(hebergeur, x, y)
        {
            this.Fond = hebergeur.BackColor;
            this.Crayon = crayon;
        }
        #endregion

        #region Méthodes
        public virtual void Bouger(int deplX, int deplY)
        {
            X += deplX;
            Y += deplY;
        }
        public virtual void Afficher(Graphics gr)
        {
            if (this.Visible)
            {
                gr.FillEllipse(new SolidBrush(Color.Brown), this.X + 200, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Crayon, 3), this.X + 200, this.Y, 10, 10);
            }
        }
        public virtual void Cacher(Graphics gr)
        {
            if (this.Visible)
            {
                gr.FillEllipse(new SolidBrush(this.Fond), this.X + 200, this.Y, 10, 10);
                gr.DrawEllipse(new Pen(this.Fond, 3), this.X + 200, this.Y, 10, 10);

            }
        }
        #endregion
    }
}
