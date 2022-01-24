namespace WindowsFormsProject
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.bgLeague = new System.Windows.Forms.GroupBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.bgLanguage = new System.Windows.Forms.GroupBox();
            this.rbCroatian = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.btnSettings = new System.Windows.Forms.Button();
            this.bgLeague.SuspendLayout();
            this.bgLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgLeague
            // 
            this.bgLeague.Controls.Add(this.rbMan);
            this.bgLeague.Controls.Add(this.rbWoman);
            this.bgLeague.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.bgLeague, "bgLeague");
            this.bgLeague.Name = "bgLeague";
            this.bgLeague.TabStop = false;
            this.bgLeague.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbMan
            // 
            resources.ApplyResources(this.rbMan, "rbMan");
            this.rbMan.Name = "rbMan";
            this.rbMan.TabStop = true;
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbWoman
            // 
            resources.ApplyResources(this.rbWoman, "rbWoman");
            this.rbWoman.Checked = true;
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.TabStop = true;
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // bgLanguage
            // 
            this.bgLanguage.Controls.Add(this.rbCroatian);
            this.bgLanguage.Controls.Add(this.rbEnglish);
            this.bgLanguage.ForeColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.bgLanguage, "bgLanguage");
            this.bgLanguage.Name = "bgLanguage";
            this.bgLanguage.TabStop = false;
            // 
            // rbCroatian
            // 
            resources.ApplyResources(this.rbCroatian, "rbCroatian");
            this.rbCroatian.Name = "rbCroatian";
            this.rbCroatian.TabStop = true;
            this.rbCroatian.UseVisualStyleBackColor = true;
            // 
            // rbEnglish
            // 
            resources.ApplyResources(this.rbEnglish, "rbEnglish");
            this.rbEnglish.Checked = true;
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.TabStop = true;
            this.rbEnglish.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.Desktop;
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.bgLanguage);
            this.Controls.Add(this.bgLeague);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.bgLeague.ResumeLayout(false);
            this.bgLeague.PerformLayout();
            this.bgLanguage.ResumeLayout(false);
            this.bgLanguage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bgLeague;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.GroupBox bgLanguage;
        private System.Windows.Forms.RadioButton rbCroatian;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.Button btnSettings;
    }
}

