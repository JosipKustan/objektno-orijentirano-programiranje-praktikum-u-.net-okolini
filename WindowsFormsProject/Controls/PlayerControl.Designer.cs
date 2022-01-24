namespace WindowsFormsProject.Controls
{
    partial class PlayerControl
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
            this.pbPlayerPicture = new System.Windows.Forms.PictureBox();
            this.lbShirtNumber = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.iconFavorite = new FontAwesome.Sharp.IconPictureBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbPlayerName = new System.Windows.Forms.Label();
            this.iconCapetan = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCapetan)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerPicture
            // 
            this.pbPlayerPicture.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pbPlayerPicture.BackgroundImage = global::WindowsFormsProject.Properties.Resources.soccerPlayerDefault_;
            this.pbPlayerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPlayerPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbPlayerPicture.InitialImage = global::WindowsFormsProject.Properties.Resources.soccerPlayerDefault_;
            this.pbPlayerPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPlayerPicture.Name = "pbPlayerPicture";
            this.pbPlayerPicture.Size = new System.Drawing.Size(128, 121);
            this.pbPlayerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerPicture.TabIndex = 0;
            this.pbPlayerPicture.TabStop = false;
            this.pbPlayerPicture.DoubleClick += new System.EventHandler(this.UploadPicture);
            // 
            // lbShirtNumber
            // 
            this.lbShirtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbShirtNumber.AutoSize = true;
            this.lbShirtNumber.BackColor = System.Drawing.Color.DimGray;
            this.lbShirtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShirtNumber.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbShirtNumber.Location = new System.Drawing.Point(74, 92);
            this.lbShirtNumber.Name = "lbShirtNumber";
            this.lbShirtNumber.Size = new System.Drawing.Size(54, 29);
            this.lbShirtNumber.TabIndex = 1;
            this.lbShirtNumber.Text = "No.";
            this.lbShirtNumber.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BottomPanel.Controls.Add(this.iconFavorite);
            this.BottomPanel.Controls.Add(this.lbPosition);
            this.BottomPanel.Controls.Add(this.lbPlayerName);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 117);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(128, 83);
            this.BottomPanel.TabIndex = 2;
            this.BottomPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ToggleSelectedEvent);
            // 
            // iconFavorite
            // 
            this.iconFavorite.BackColor = System.Drawing.Color.Transparent;
            this.iconFavorite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconFavorite.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconFavorite.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconFavorite.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconFavorite.Location = new System.Drawing.Point(93, 50);
            this.iconFavorite.Name = "iconFavorite";
            this.iconFavorite.Size = new System.Drawing.Size(32, 32);
            this.iconFavorite.TabIndex = 3;
            this.iconFavorite.TabStop = false;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.BackColor = System.Drawing.SystemColors.Control;
            this.lbPosition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPosition.Location = new System.Drawing.Point(3, 66);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(55, 16);
            this.lbPosition.TabIndex = 4;
            this.lbPosition.Text = "Position";
            // 
            // lbPlayerName
            // 
            this.lbPlayerName.AutoSize = true;
            this.lbPlayerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayerName.Location = new System.Drawing.Point(0, 0);
            this.lbPlayerName.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lbPlayerName.MaximumSize = new System.Drawing.Size(120, 0);
            this.lbPlayerName.Name = "lbPlayerName";
            this.lbPlayerName.Size = new System.Drawing.Size(83, 32);
            this.lbPlayerName.TabIndex = 3;
            this.lbPlayerName.Text = "First LAST NAME";
            this.lbPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPlayerName.UseMnemonic = false;
            this.lbPlayerName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            // 
            // iconCapetan
            // 
            this.iconCapetan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconCapetan.BackColor = System.Drawing.Color.DimGray;
            this.iconCapetan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.iconCapetan.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            this.iconCapetan.IconColor = System.Drawing.SystemColors.HotTrack;
            this.iconCapetan.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconCapetan.Location = new System.Drawing.Point(93, 0);
            this.iconCapetan.Name = "iconCapetan";
            this.iconCapetan.Size = new System.Drawing.Size(32, 34);
            this.iconCapetan.TabIndex = 3;
            this.iconCapetan.TabStop = false;
            this.iconCapetan.UseGdi = true;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconCapetan);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.lbShirtNumber);
            this.Controls.Add(this.pbPlayerPicture);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "PlayerControl";
            this.Size = new System.Drawing.Size(128, 200);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartDragging);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerPicture)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCapetan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerPicture;
        private System.Windows.Forms.Label lbShirtNumber;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Label lbPlayerName;
        private System.Windows.Forms.Label lbPosition;
        private FontAwesome.Sharp.IconPictureBox iconFavorite;
        private FontAwesome.Sharp.IconPictureBox iconCapetan;
    }
}
