using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK_Carosse
{
    class MonCarosse:MonRectangle
    {
		#region Données membres
		private MonCercle RoueG, RoueD;
		private MonRectangle Porte, FenD, FenG, Poignee;
		#endregion

		#region Constructeurs
		public MonCarosse(PictureBox hebergeur, int xsg, int ysg, int lg, int ht) : base(hebergeur, xsg, ysg, lg, ht)
		{
			this.RoueG = new MonCercle(hebergeur, xsg, ysg + ht, ht / 2, Color.Blue, Color.Blue);
			this.RoueD = new MonCercle(hebergeur, xsg + lg, ysg + ht, ht / 2, Color.Blue, Color.Blue);
			this.FenG = new MonRectangle(hebergeur, lg / 10 + xsg, ht / 6 + ysg, lg / 5, ht / 3);
			this.FenD = new MonRectangle(hebergeur, xsg + lg - 3 * lg / 10, ht / 6 + ysg, lg / 5, ht / 3);
			this.Porte = new MonRectangle(hebergeur, xsg + lg / 2 - 2 * lg / 15, ysg + ht - 3 * ht / 4 - 1, 4 * lg / 15, 3 * ht / 4);
			this.Poignee = new MonRectangle(hebergeur, xsg + lg / 2 + lg / 30, ht / 2 + ysg, lg / 15, ht / 15);
			this.Crayon = Color.Brown;
			this.Pot = Color.Red;
			this.FenG.Pot = this.FenD.Pot = Color.Navy;
			this.Porte.Pot = Color.Brown;
			this.Poignee.Pot = this.Poignee.Crayon = Color.Yellow;
		}
		#endregion

		#region Méthodes
		public override void Bouger(int deplX, int deplY)
		{
			base.Bouger(deplX, deplY);
			this.RoueG.Bouger(deplX, deplY);
			this.RoueD.Bouger(deplX, deplY);
			this.FenG.Bouger(deplX, deplY);
			this.FenD.Bouger(deplX, deplY);
			this.Porte.Bouger(deplX, deplY);
			this.Poignee.Bouger(deplX, deplY);
		}
		public override void Cacher(Graphics g)
		{
			base.Cacher(g);
			this.RoueG.Cacher(g);
			this.RoueD.Cacher(g);
			this.FenG.Cacher(g);
			this.FenD.Cacher(g);
			this.Porte.Cacher(g);
			this.Poignee.Cacher(g);
		}
		public override void Afficher(Graphics g)
		{
			base.Afficher(g);
			this.RoueG.Afficher(g);
			this.RoueD.Afficher(g);
			this.FenG.Afficher(g);
			this.FenD.Afficher(g);
			this.Porte.Afficher(g);
			this.Poignee.Afficher(g);
		}
		#endregion
	}
}
