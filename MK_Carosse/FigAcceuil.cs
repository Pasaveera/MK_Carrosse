using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MK_Carosse
{
    public partial class FigAcceuil : Form
    {
        private MonPoint pointTest;
        private MonCercle cercleTest;
        private MonRectangle rectangleTest;
        private MonCarosse carosse;
        private MonBonhomme Man;
        private MonBonhomme Women;



        private BufferedGraphics bufferG = null;
        private Graphics g;

        public FigAcceuil()
        {
            InitializeComponent();
            bufferG = BufferedGraphicsManager.Current.Allocate(TV.CreateGraphics(), TV.DisplayRectangle);
            g = bufferG.Graphics;
        }

        private void btnPoint_Click_1(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            this.pointTest = new MonPoint(this.TV, 10, 20, Color.Black);
            this.pointTest.Afficher(g);
            bufferG.Render();
            btnDeplacer.Enabled = true;
            btnADTimer.Enabled = true;
            this.Text = "Handle de la TV (pictureBox) : " + this.TV.Handle.ToString();
        }

        private void btnDeplacer_Click_1(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            this.pointTest.Bouger(20, 10);
            TV.Refresh();
            this.pointTest.Afficher(g);
            bufferG.Render();
        }

        private void btnCacher_Click_1(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            bufferG.Render();
            btnDeplacer.Enabled = false;
        }

        private void Image_tick(object sender, EventArgs e)
        {
            this.pointTest.Cacher(g);
            this.cercleTest.Cacher(g);
            bufferG.Render();

            this.pointTest.Bouger(4, 0);
            this.pointTest.Afficher(g);
            this.cercleTest.Bouger(7, 0);
            this.cercleTest.Afficher(g);
            bufferG.Render();
        }

        private void btnBuffer_Click(object sender, EventArgs e)
        {
            bufferG.Render();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            bufferG.Render();
        }

        private void btnADTimer_Click(object sender, EventArgs e)
        {
            if (pointTest is MonPoint && cercleTest is MonCercle)
            {
                timerImage.Enabled = !timerImage.Enabled;
            }
        }

        private void btnCercle_Click(object sender, EventArgs e)
        {
            this.cercleTest = new MonCercle(this.TV, 150, 50, 50, Color.Cyan, Color.Magenta);
            this.cercleTest.Afficher(g);
            bufferG.Render();

            btnCacherCercle.Enabled = true;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.rectangleTest = new MonRectangle(this.TV, 150, 75, 25, 45, Color.DarkOrange, Color.Yellow);
            this.rectangleTest.Afficher(g);
            bufferG.Render();

            btnCacherRec.Enabled = true;
        }

        private void btnCacherRec_Click(object sender, EventArgs e)
        {
            this.rectangleTest.Cacher(g);
            bufferG.Render();
        }

        private void btnCacherCercle_Click(object sender, EventArgs e)
        {
            this.cercleTest.Cacher(g);
            bufferG.Render();
        }

        private void btnCreationCarosse_Click(object sender, EventArgs e)
        {
            this.carosse = new MonCarosse(this.TV, 10, 75, 140, 60);
            this.carosse.Afficher(g);
            bufferG.Render();
            btnDeplacerCarrosse.Enabled = true;
        }

        private void btnDeplacerCarrosse_Click(object sender, EventArgs e)
        {
            this.carosse.Bouger(4, 0);
            this.carosse.Afficher(g);
            bufferG.Render();
        }

        private void btnTimerCarrosse_Click(object sender, EventArgs e)
        {
            if (carosse is MonCarosse)
                timerCarrosse.Enabled = !timerCarrosse.Enabled;
        }

        private void timerCarrosse_Tick(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
            this.carosse.Cacher(g);
            bufferG.Render();

            this.carosse.Bouger(4, 0);
            this.carosse.Afficher(g);
            bufferG.Render();
        }

        private void btnCreationMan_Click(object sender, EventArgs e)
        {
            this.Man = new MonBonhomme(this.TV, 40, 70, 40, 60);
            this.Man.Afficher(g);
            bufferG.Render();

            EnabledTrue(btnDeplacerMan);
        }

        private void btnDeplacerMan_Click(object sender, EventArgs e)
        {
            Man.Cacher(g);
            Deplacer(Man);
        }

        private void btnCreationWomen_Click(object sender, EventArgs e)
        {
            this.Women = new MonBonhomme(this.TV, 120, 50, 30, 50);
            this.Women.Afficher(g);
            bufferG.Render();

            EnabledTrue(btnDeplacerWomen);
        }

        #region Functions
        void EnabledTrue(params Button[] mesButtons)
        {
            foreach(Button button in mesButtons)
            {
                button.Enabled = true;
            }
        }

        void Deplacer(MonPoint obj)
        {
            obj.Bouger(5, 0);
            obj.Afficher(g);
            bufferG.Render();
        }
        #endregion

        private void btnDeplacerWomen_Click(object sender, EventArgs e)
        {
            Women.Cacher(g);
            Deplacer(Women);
        }

        private void FigAcceuil_Load(object sender, EventArgs e)
        {
            g.Clear(TV.BackColor);
        }
    }
}
