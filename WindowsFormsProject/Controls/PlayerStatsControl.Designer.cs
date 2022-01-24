namespace WindowsFormsProject.Controls
{
    partial class PlayerStatsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbYellowCards = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Futbol;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(54, 48);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Location = new System.Drawing.Point(19, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 52);
            this.panel1.TabIndex = 1;
            // 
            // lbGoals
            // 
            this.lbGoals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbGoals.AutoSize = true;
            this.lbGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoals.Location = new System.Drawing.Point(72, 40);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(31, 32);
            this.lbGoals.TabIndex = 2;
            this.lbGoals.Text = "0";
            // 
            // lbYellowCards
            // 
            this.lbYellowCards.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbYellowCards.AutoSize = true;
            this.lbYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYellowCards.Location = new System.Drawing.Point(72, 128);
            this.lbYellowCards.Name = "lbYellowCards";
            this.lbYellowCards.Size = new System.Drawing.Size(31, 32);
            this.lbYellowCards.TabIndex = 3;
            this.lbYellowCards.Text = "0";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.lbYellowCards);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconPictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximumSize = new System.Drawing.Size(128, 200);
            this.Name = "PlayerStats";
            this.Size = new System.Drawing.Size(128, 200);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbYellowCards;
    }
}
