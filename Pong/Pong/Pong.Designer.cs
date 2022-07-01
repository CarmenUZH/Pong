using Timer = System.Windows.Forms.Timer;

namespace Pong
{
    partial class Pong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.player1 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.score1 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.pongtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.LightCyan;
            this.player1.Location = new System.Drawing.Point(83, 593);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(36, 294);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Player2.Location = new System.Drawing.Point(1877, 593);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(36, 294);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ball.BackgroundImage")));
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Location = new System.Drawing.Point(952, 702);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(51, 54);
            this.ball.TabIndex = 3;
            this.ball.TabStop = false;
            // 
            // score1
            // 
            this.score1.BackColor = System.Drawing.Color.Transparent;
            this.score1.Font = new System.Drawing.Font("Haettenschweiler", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score1.ForeColor = System.Drawing.Color.Aqua;
            this.score1.Location = new System.Drawing.Point(143, 12);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(139, 152);
            this.score1.TabIndex = 4;
            this.score1.Text = "0";
            this.score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score2
            // 
            this.score2.BackColor = System.Drawing.Color.Transparent;
            this.score2.Font = new System.Drawing.Font("Haettenschweiler", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.score2.ForeColor = System.Drawing.Color.Gold;
            this.score2.Location = new System.Drawing.Point(1732, 29);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(139, 152);
            this.score2.TabIndex = 5;
            this.score2.Text = "0";
            this.score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongtimer
            // 
            this.pongtimer.Enabled = true;
            this.pongtimer.Interval = 15;
            this.pongtimer.Tick += new System.EventHandler(this.pongtimer_Tick);
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1966, 1576);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.score2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pong";
            this.Text = "Play pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox player1;
        private PictureBox Player2;
        private PictureBox ball;
        internal Label score1;
        internal Label score2;
        private System.Windows.Forms.Timer pongtimer;
    }
}