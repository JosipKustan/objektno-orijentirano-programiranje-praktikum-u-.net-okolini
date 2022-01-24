namespace WindowsFormsProject.Forms
{
    partial class FootballApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FootballApp));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelectTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTeamSelection = new System.Windows.Forms.ComboBox();
            this.flowPlayerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowPanelFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRankedLists = new System.Windows.Forms.Button();
            this.TitlePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            resources.ApplyResources(this.TitlePanel, "TitlePanel");
            this.TitlePanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.TitlePanel.Controls.Add(this.Title);
            this.TitlePanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AlphaDown);
            // 
            // Title
            // 
            resources.ApplyResources(this.Title, "Title");
            this.Title.Name = "Title";
            this.Title.Paint += new System.Windows.Forms.PaintEventHandler(this.AlphaDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnSelectTeam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTeamSelection);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.AlphaDown);
            // 
            // btnSelectTeam
            // 
            this.btnSelectTeam.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.btnSelectTeam, "btnSelectTeam");
            this.btnSelectTeam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSelectTeam.Name = "btnSelectTeam";
            this.btnSelectTeam.UseVisualStyleBackColor = false;
            this.btnSelectTeam.Click += new System.EventHandler(this.SelectTeam_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.AlphaDown);
            // 
            // cbTeamSelection
            // 
            this.cbTeamSelection.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.cbTeamSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbTeamSelection, "cbTeamSelection");
            this.cbTeamSelection.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbTeamSelection.FormattingEnabled = true;
            this.cbTeamSelection.Name = "cbTeamSelection";
            // 
            // flowPlayerPanel
            // 
            this.flowPlayerPanel.AllowDrop = true;
            resources.ApplyResources(this.flowPlayerPanel, "flowPlayerPanel");
            this.flowPlayerPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowPlayerPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.flowPlayerPanel.Name = "flowPlayerPanel";
            this.flowPlayerPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropData);
            this.flowPlayerPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.AcceptData);
            // 
            // flowPanelFavorites
            // 
            resources.ApplyResources(this.flowPanelFavorites, "flowPanelFavorites");
            this.flowPanelFavorites.BackColor = System.Drawing.SystemColors.Desktop;
            this.flowPanelFavorites.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.flowPanelFavorites.Name = "flowPanelFavorites";
            this.flowPanelFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropData);
            this.flowPanelFavorites.DragEnter += new System.Windows.Forms.DragEventHandler(this.AcceptData);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Name = "label3";
            // 
            // btnRankedLists
            // 
            this.btnRankedLists.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.btnRankedLists, "btnRankedLists");
            this.btnRankedLists.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRankedLists.Name = "btnRankedLists";
            this.btnRankedLists.UseVisualStyleBackColor = false;
            this.btnRankedLists.Click += new System.EventHandler(this.btnRankedLists_Click);
            // 
            // FootballApp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsProject.Properties.Resources.grassDark;
            this.Controls.Add(this.btnRankedLists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowPanelFavorites);
            this.Controls.Add(this.flowPlayerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitlePanel);
            this.Name = "FootballApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FootballApp_FormClosing);
            this.Load += new System.EventHandler(this.FootballApp_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTeamSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectTeam;
        private System.Windows.Forms.FlowLayoutPanel flowPlayerPanel;
        private System.Windows.Forms.FlowLayoutPanel flowPanelFavorites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRankedLists;
    }
}