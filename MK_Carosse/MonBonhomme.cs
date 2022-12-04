using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK_Carosse
{
    class MonBonhomme:MonRectangle
    {
        #region Données membres
        private MonCercle tete;
        private MonRectangle brasD, brasG, jambeD, jambeG;

		#endregion
		#region Constructeurs
		public MonBonhomme(PictureBox hebergeur, int xsg, int ysg, int lg, int ht) : base(hebergeur, xsg, ysg, lg, ht)
		{
			this.tete = new MonCercle(hebergeur, xsg+xsg/2 , ysg-ysg/3, ht/2);
			this.brasD = new MonRectangle(hebergeur, xsg+lg, ysg ,lg/2, ht+ht/4);
			this.brasG = new MonRectangle(hebergeur, xsg-lg/2, ysg ,lg/2, ht+ht/4);
			this.jambeD = new MonRectangle(hebergeur, xsg+lg/2, ysg+ht,lg/2, ht+ht/2);
			this.jambeG = new MonRectangle(hebergeur, xsg, ht+ysg,lg/2, ht+ht/2);

			this.brasD.Pot = Color.Yellow;
			this.brasG.Pot = Color.Blue;
			this.jambeD.Pot = Color.Violet;
			this.jambeG.Pot = Color.Green;
			this.tete.Pot = Color.CornflowerBlue;
			this.Pot = Color.Red;
			this.Crayon = Color.Cyan;

			
		}
		#endregion

		#region Methods
		public override void Bouger(int deplX, int deplY)
		{
			base.Bouger(deplX, deplY); //Rectangle qui constitue le torse
			this.brasD.Bouger(deplX, deplY);
			this.brasG.Bouger(deplX, deplY);
			this.jambeD.Bouger(deplX, deplY);
			this.jambeG.Bouger(deplX, deplY);
			this.tete.Bouger(deplX, deplY);
		}
		public override void Cacher(Graphics g)
		{

			this.brasD.Cacher(g);
			this.brasG.Cacher(g);
			base.Afficher(g);
			this.jambeD.Cacher(g);
			this.jambeG.Cacher(g);
			this.tete.Cacher(g);

		}
		public override void Afficher(Graphics g)
		{
			
			this.brasD.Afficher(g);
			this.brasG.Afficher(g);
			base.Afficher(g);
			this.jambeD.Afficher(g);
			this.jambeG.Afficher(g);
			this.tete.Afficher(g);
		}
		#endregion
	}
}
