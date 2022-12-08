
namespace MK_Carosse
{
    partial class FigAcceuil
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
            this.components = new System.ComponentModel.Container();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnDeplacer = new System.Windows.Forms.Button();
            this.TV = new System.Windows.Forms.PictureBox();
            this.btnCacher = new System.Windows.Forms.Button();
            this.btnBuffer = new System.Windows.Forms.Button();
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnADTimer = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnCercle = new System.Windows.Forms.Button();
            this.btnCacherRec = new System.Windows.Forms.Button();
            this.btnCacherCercle = new System.Windows.Forms.Button();
            this.btnCreationCarosse = new System.Windows.Forms.Button();
            this.btnDeplacerCarrosse = new System.Windows.Forms.Button();
            this.btnTimerCarrosse = new System.Windows.Forms.Button();
            this.timerCarrosse = new System.Windows.Forms.Timer(this.components);
            this.btnCreationMan = new System.Windows.Forms.Button();
            this.btnDeplacerMan = new System.Windows.Forms.Button();
            this.btnCreationWomen = new System.Windows.Forms.Button();
            this.btnDeplacerWomen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoint
            // 
            this.btnPoint.Location = new System.Drawing.Point(22, 304);
            this.btnPoint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(166, 32);
            this.btnPoint.TabIndex = 0;
            this.btnPoint.Text = "Creation Point";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click_1);
            // 
            // btnDeplacer
            // 
            this.btnDeplacer.Location = new System.Drawing.Point(404, 306);
            this.btnDeplacer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeplacer.Name = "btnDeplacer";
            this.btnDeplacer.Size = new System.Drawing.Size(164, 31);
            this.btnDeplacer.TabIndex = 1;
            this.btnDeplacer.Text = "Deplacer";
            this.btnDeplacer.UseVisualStyleBackColor = true;
            this.btnDeplacer.Click += new System.EventHandler(this.btnDeplacer_Click_1);
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(33, 28);
            this.TV.Margin = new System.Windows.Forms.Padding(2);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(931, 257);
            this.TV.TabIndex = 2;
            this.TV.TabStop = false;
            // 
            // btnCacher
            // 
            this.btnCacher.Location = new System.Drawing.Point(214, 306);
            this.btnCacher.Margin = new System.Windows.Forms.Padding(2);
            this.btnCacher.Name = "btnCacher";
            this.btnCacher.Size = new System.Drawing.Size(165, 28);
            this.btnCacher.TabIndex = 3;
            this.btnCacher.Text = "Cacher Point";
            this.btnCacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCacher.UseVisualStyleBackColor = true;
            this.btnCacher.Click += new System.EventHandler(this.btnCacher_Click_1);
            // 
            // btnBuffer
            // 
            this.btnBuffer.Location = new System.Drawing.Point(798, 354);
            this.btnBuffer.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuffer.Name = "btnBuffer";
            this.btnBuffer.Size = new System.Drawing.Size(166, 32);
            this.btnBuffer.TabIndex = 4;
            this.btnBuffer.Text = "Buffer";
            this.btnBuffer.UseVisualStyleBackColor = true;
            this.btnBuffer.Click += new System.EventHandler(this.btnBuffer_Click);
            // 
            // timerImage
            // 
            this.timerImage.Interval = 40;
            this.timerImage.Tick += new System.EventHandler(this.Image_tick);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(798, 400);
            this.btnEffacer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(166, 32);
            this.btnEffacer.TabIndex = 5;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnADTimer
            // 
            this.btnADTimer.Location = new System.Drawing.Point(798, 302);
            this.btnADTimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnADTimer.Name = "btnADTimer";
            this.btnADTimer.Size = new System.Drawing.Size(166, 32);
            this.btnADTimer.TabIndex = 6;
            this.btnADTimer.Text = "ActivateTimer/DeactivateTimer";
            this.btnADTimer.UseVisualStyleBackColor = true;
            this.btnADTimer.Click += new System.EventHandler(this.btnADTimer_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(22, 404);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(166, 32);
            this.btnRectangle.TabIndex = 7;
            this.btnRectangle.Text = "Creation Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnCercle
            // 
            this.btnCercle.Location = new System.Drawing.Point(22, 354);
            this.btnCercle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCercle.Name = "btnCercle";
            this.btnCercle.Size = new System.Drawing.Size(166, 32);
            this.btnCercle.TabIndex = 8;
            this.btnCercle.Text = "Creation Cercle";
            this.btnCercle.UseVisualStyleBackColor = true;
            this.btnCercle.Click += new System.EventHandler(this.btnCercle_Click);
            // 
            // btnCacherRec
            // 
            this.btnCacherRec.Location = new System.Drawing.Point(214, 404);
            this.btnCacherRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnCacherRec.Name = "btnCacherRec";
            this.btnCacherRec.Size = new System.Drawing.Size(165, 28);
            this.btnCacherRec.TabIndex = 9;
            this.btnCacherRec.Text = "Cacher Rectangle";
            this.btnCacherRec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCacherRec.UseVisualStyleBackColor = true;
            this.btnCacherRec.Click += new System.EventHandler(this.btnCacherRec_Click);
            // 
            // btnCacherCercle
            // 
            this.btnCacherCercle.Location = new System.Drawing.Point(213, 354);
            this.btnCacherCercle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCacherCercle.Name = "btnCacherCercle";
            this.btnCacherCercle.Size = new System.Drawing.Size(166, 32);
            this.btnCacherCercle.TabIndex = 10;
            this.btnCacherCercle.Text = "Cacher Cercle";
            this.btnCacherCercle.UseVisualStyleBackColor = true;
            this.btnCacherCercle.Click += new System.EventHandler(this.btnCacherCercle_Click);
            // 
            // btnCreationCarosse
            // 
            this.btnCreationCarosse.Location = new System.Drawing.Point(22, 453);
            this.btnCreationCarosse.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreationCarosse.Name = "btnCreationCarosse";
            this.btnCreationCarosse.Size = new System.Drawing.Size(166, 32);
            this.btnCreationCarosse.TabIndex = 11;
            this.btnCreationCarosse.Text = "Creation Carrosse";
            this.btnCreationCarosse.UseVisualStyleBackColor = true;
            this.btnCreationCarosse.Click += new System.EventHandler(this.btnCreationCarosse_Click);
            // 
            // btnDeplacerCarrosse
            // 
            this.btnDeplacerCarrosse.Location = new System.Drawing.Point(213, 453);
            this.btnDeplacerCarrosse.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeplacerCarrosse.Name = "btnDeplacerCarrosse";
            this.btnDeplacerCarrosse.Size = new System.Drawing.Size(164, 31);
            this.btnDeplacerCarrosse.TabIndex = 12;
            this.btnDeplacerCarrosse.Text = "Deplacer Carrosse";
            this.btnDeplacerCarrosse.UseVisualStyleBackColor = true;
            this.btnDeplacerCarrosse.Click += new System.EventHandler(this.btnDeplacerCarrosse_Click);
            // 
            // btnTimerCarrosse
            // 
            this.btnTimerCarrosse.Location = new System.Drawing.Point(798, 453);
            this.btnTimerCarrosse.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimerCarrosse.Name = "btnTimerCarrosse";
            this.btnTimerCarrosse.Size = new System.Drawing.Size(164, 31);
            this.btnTimerCarrosse.TabIndex = 13;
            this.btnTimerCarrosse.Text = "Activate Carrosse/Deactivate";
            this.btnTimerCarrosse.UseVisualStyleBackColor = true;
            this.btnTimerCarrosse.Click += new System.EventHandler(this.btnTimerCarrosse_Click);
            // 
            // timerCarrosse
            // 
            this.timerCarrosse.Tick += new System.EventHandler(this.timerCarrosse_Tick);
            // 
            // btnCreationMan
            // 
            this.btnCreationMan.Location = new System.Drawing.Point(22, 506);
            this.btnCreationMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreationMan.Name = "btnCreationMan";
            this.btnCreationMan.Size = new System.Drawing.Size(166, 32);
            this.btnCreationMan.TabIndex = 14;
            this.btnCreationMan.Text = "Creation MAN";
            this.btnCreationMan.UseVisualStyleBackColor = true;
            this.btnCreationMan.Click += new System.EventHandler(this.btnCreationMan_Click);
            // 
            // btnDeplacerMan
            // 
            this.btnDeplacerMan.Location = new System.Drawing.Point(602, 506);
            this.btnDeplacerMan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeplacerMan.Name = "btnDeplacerMan";
            this.btnDeplacerMan.Size = new System.Drawing.Size(166, 32);
            this.btnDeplacerMan.TabIndex = 15;
            this.btnDeplacerMan.Text = "Deplacer MAN";
            this.btnDeplacerMan.UseVisualStyleBackColor = true;
            this.btnDeplacerMan.Click += new System.EventHandler(this.btnDeplacerMan_Click);
            // 
            // btnCreationWomen
            // 
            this.btnCreationWomen.Location = new System.Drawing.Point(213, 506);
            this.btnCreationWomen.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreationWomen.Name = "btnCreationWomen";
            this.btnCreationWomen.Size = new System.Drawing.Size(166, 32);
            this.btnCreationWomen.TabIndex = 16;
            this.btnCreationWomen.Text = "Creation WOMEN";
            this.btnCreationWomen.UseVisualStyleBackColor = true;
            this.btnCreationWomen.Click += new System.EventHandler(this.btnCreationWomen_Click);
            // 
            // btnDeplacerWomen
            // 
            this.btnDeplacerWomen.Location = new System.Drawing.Point(402, 506);
            this.btnDeplacerWomen.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeplacerWomen.Name = "btnDeplacerWomen";
            this.btnDeplacerWomen.Size = new System.Drawing.Size(166, 32);
            this.btnDeplacerWomen.TabIndex = 17;
            this.btnDeplacerWomen.Text = "Deplacer WOMEN";
            this.btnDeplacerWomen.UseVisualStyleBackColor = true;
            this.btnDeplacerWomen.Click += new System.EventHandler(this.btnDeplacerWomen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 556);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Creation MAN";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 556);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 32);
            this.button2.TabIndex = 19;
            this.button2.Text = "Creation MAN";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(459, 563);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 20);
            this.textBox1.TabIndex = 21;
            // 
            // FigAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 609);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDeplacerWomen);
            this.Controls.Add(this.btnCreationWomen);
            this.Controls.Add(this.btnDeplacerMan);
            this.Controls.Add(this.btnCreationMan);
            this.Controls.Add(this.btnTimerCarrosse);
            this.Controls.Add(this.btnDeplacerCarrosse);
            this.Controls.Add(this.btnCreationCarosse);
            this.Controls.Add(this.btnCacherCercle);
            this.Controls.Add(this.btnCacherRec);
            this.Controls.Add(this.btnCercle);
            this.Controls.Add(this.btnRectangle);
            this.Controls.Add(this.btnADTimer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnBuffer);
            this.Controls.Add(this.btnCacher);
            this.Controls.Add(this.TV);
            this.Controls.Add(this.btnDeplacer);
            this.Controls.Add(this.btnPoint);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FigAcceuil";
            this.Text = "Dessin Animé";
            this.Load += new System.EventHandler(this.FigAcceuil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnDeplacer;
        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Button btnCacher;
        private System.Windows.Forms.Button btnBuffer;
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnADTimer;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCercle;
        private System.Windows.Forms.Button btnCacherRec;
        private System.Windows.Forms.Button btnCacherCercle;
        private System.Windows.Forms.Button btnCreationCarosse;
        private System.Windows.Forms.Button btnDeplacerCarrosse;
        private System.Windows.Forms.Button btnTimerCarrosse;
        private System.Windows.Forms.Timer timerCarrosse;
        private System.Windows.Forms.Button btnCreationMan;
        private System.Windows.Forms.Button btnDeplacerMan;
        private System.Windows.Forms.Button btnCreationWomen;
        private System.Windows.Forms.Button btnDeplacerWomen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

