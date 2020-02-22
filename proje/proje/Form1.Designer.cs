namespace proje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oyunalani = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.raket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oyunalani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // oyunalani
            // 
            this.oyunalani.BackColor = System.Drawing.SystemColors.Control;
            this.oyunalani.Controls.Add(this.label2);
            this.oyunalani.Controls.Add(this.raket);
            this.oyunalani.Controls.Add(this.ball);
            this.oyunalani.Controls.Add(this.label1);
            this.oyunalani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunalani.Location = new System.Drawing.Point(0, 0);
            this.oyunalani.Name = "oyunalani";
            this.oyunalani.Size = new System.Drawing.Size(713, 425);
            this.oyunalani.TabIndex = 0;
            this.oyunalani.Paint += new System.Windows.Forms.PaintEventHandler(this.oyunalani_Paint);
            this.oyunalani.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.oyunalani.MouseLeave += new System.EventHandler(this.oyunalani_MouseLeave);
            this.oyunalani.MouseHover += new System.EventHandler(this.oyunalani_MouseHover);
            this.oyunalani.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oyunalani_MouseMove);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(207, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 125);
            this.label2.TabIndex = 3;
            this.label2.Text = "KAYBETTİNİZ !\r\nEsc-Çıkış\r\nBir Kez Tıklayınız-Yeniden\r\n\r\n\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // raket
            // 
            this.raket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.raket.Location = new System.Drawing.Point(245, 372);
            this.raket.Name = "raket";
            this.raket.Size = new System.Drawing.Size(212, 23);
            this.raket.TabIndex = 2;
            this.raket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.Control;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(335, 341);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(26, 25);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 425);
            this.Controls.Add(this.oyunalani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.oyunalani.ResumeLayout(false);
            this.oyunalani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oyunalani;
        private System.Windows.Forms.PictureBox raket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}

