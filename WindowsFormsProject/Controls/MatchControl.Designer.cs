namespace WindowsFormsProject.Controls
{
    partial class MatchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchControl));
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHomePenalties = new System.Windows.Forms.Label();
            this.lblAwayPenalties = new System.Windows.Forms.Label();
            this.btnAwayPlayers = new System.Windows.Forms.Button();
            this.btnHomePlayers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVenue
            // 
            resources.ApplyResources(this.lblVenue, "lblVenue");
            this.lblVenue.Name = "lblVenue";
            // 
            // lblLocation
            // 
            resources.ApplyResources(this.lblLocation, "lblLocation");
            this.lblLocation.Name = "lblLocation";
            // 
            // lblHomeTeam
            // 
            resources.ApplyResources(this.lblHomeTeam, "lblHomeTeam");
            this.lblHomeTeam.Name = "lblHomeTeam";
            // 
            // lblAwayTeam
            // 
            resources.ApplyResources(this.lblAwayTeam, "lblAwayTeam");
            this.lblAwayTeam.Name = "lblAwayTeam";
            // 
            // lblAwayScore
            // 
            resources.ApplyResources(this.lblAwayScore, "lblAwayScore");
            this.lblAwayScore.Name = "lblAwayScore";
            // 
            // lblHomeScore
            // 
            resources.ApplyResources(this.lblHomeScore, "lblHomeScore");
            this.lblHomeScore.Name = "lblHomeScore";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblHomePenalties
            // 
            resources.ApplyResources(this.lblHomePenalties, "lblHomePenalties");
            this.lblHomePenalties.Name = "lblHomePenalties";
            // 
            // lblAwayPenalties
            // 
            resources.ApplyResources(this.lblAwayPenalties, "lblAwayPenalties");
            this.lblAwayPenalties.Name = "lblAwayPenalties";
            // 
            // btnAwayPlayers
            // 
            resources.ApplyResources(this.btnAwayPlayers, "btnAwayPlayers");
            this.btnAwayPlayers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAwayPlayers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAwayPlayers.Name = "btnAwayPlayers";
            this.btnAwayPlayers.UseVisualStyleBackColor = false;
            this.btnAwayPlayers.Click += new System.EventHandler(this.btnAwayPlayers_Click);
            // 
            // btnHomePlayers
            // 
            resources.ApplyResources(this.btnHomePlayers, "btnHomePlayers");
            this.btnHomePlayers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHomePlayers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnHomePlayers.Name = "btnHomePlayers";
            this.btnHomePlayers.UseVisualStyleBackColor = false;
            this.btnHomePlayers.Click += new System.EventHandler(this.btnHomePlayers_Click);
            // 
            // MatchControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnHomePlayers);
            this.Controls.Add(this.btnAwayPlayers);
            this.Controls.Add(this.lblAwayPenalties);
            this.Controls.Add(this.lblHomePenalties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHomeScore);
            this.Controls.Add(this.lblAwayScore);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblVenue);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MatchControl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHomePenalties;
        private System.Windows.Forms.Label lblAwayPenalties;
        private System.Windows.Forms.Button btnAwayPlayers;
        private System.Windows.Forms.Button btnHomePlayers;
    }
}
