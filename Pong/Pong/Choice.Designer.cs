namespace Pong
{
    partial class CharacterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterForm));
            this.Char1 = new System.Windows.Forms.Label();
            this.Char14real = new System.Windows.Forms.PictureBox();
            this.Stickman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Char14real)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stickman)).BeginInit();
            this.SuspendLayout();
            // 
            // Char1
            // 
            this.Char1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Char1.Location = new System.Drawing.Point(23, 97);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(1499, 97);
            this.Char1.TabIndex = 0;
            this.Char1.Text = "Choose a Character";
            this.Char1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Char14real
            // 
            this.Char14real.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Char14real.BackgroundImage")));
            this.Char14real.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Char14real.Location = new System.Drawing.Point(81, 357);
            this.Char14real.Name = "Char14real";
            this.Char14real.Size = new System.Drawing.Size(599, 600);
            this.Char14real.TabIndex = 1;
            this.Char14real.TabStop = false;
            this.Char14real.Click += new System.EventHandler(this.Char14real_Click);
            // 
            // Stickman
            // 
            this.Stickman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stickman.BackgroundImage")));
            this.Stickman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stickman.Location = new System.Drawing.Point(838, 357);
            this.Stickman.Name = "Stickman";
            this.Stickman.Size = new System.Drawing.Size(599, 600);
            this.Stickman.TabIndex = 2;
            this.Stickman.TabStop = false;
            this.Stickman.Click += new System.EventHandler(this.Stickman_Click);
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1567, 1380);
            this.Controls.Add(this.Stickman);
            this.Controls.Add(this.Char14real);
            this.Controls.Add(this.Char1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CharacterForm";
            this.Text = "Choose a character";
            ((System.ComponentModel.ISupportInitialize)(this.Char14real)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stickman)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Char1;
        private PictureBox Char14real;
        private PictureBox Stickman;
    }
}