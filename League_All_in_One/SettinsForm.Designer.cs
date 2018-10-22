namespace League_All_in_One
{
    partial class SettinsForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AutoRunesSelectToggle = new League_All_in_One.FlatToggle();
            this.AutoChatSpamToggle = new League_All_in_One.FlatToggle();
            this.AutoChampSelectToggle = new League_All_in_One.FlatToggle();
            this.AutoAcceptToggle = new League_All_in_One.FlatToggle();
            this.AutoLoginToggle = new League_All_in_One.FlatToggle();
            this.AutoStartLeagueAppStartToggle = new League_All_in_One.FlatToggle();
            this.AutoRunesSelectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChatSpamLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoChampSelectLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoAcceptLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoLoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 93);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(650, 399);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AutoRunesSelectToggle);
            this.tabPage1.Controls.Add(this.AutoChatSpamToggle);
            this.tabPage1.Controls.Add(this.AutoChampSelectToggle);
            this.tabPage1.Controls.Add(this.AutoAcceptToggle);
            this.tabPage1.Controls.Add(this.AutoLoginToggle);
            this.tabPage1.Controls.Add(this.AutoStartLeagueAppStartToggle);
            this.tabPage1.Controls.Add(this.AutoRunesSelectLabel);
            this.tabPage1.Controls.Add(this.AutoChatSpamLabel);
            this.tabPage1.Controls.Add(this.AutoChampSelectLabel);
            this.tabPage1.Controls.Add(this.AutoAcceptLabel);
            this.tabPage1.Controls.Add(this.AutoLoginLabel);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(642, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AutoRunesSelectToggle
            // 
            this.AutoRunesSelectToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoRunesSelectToggle.Checked = false;
            this.AutoRunesSelectToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoRunesSelectToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoRunesSelectToggle.Location = new System.Drawing.Point(548, 174);
            this.AutoRunesSelectToggle.Name = "AutoRunesSelectToggle";
            this.AutoRunesSelectToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoRunesSelectToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoRunesSelectToggle.TabIndex = 79;
            this.AutoRunesSelectToggle.Text = "flatToggle6";
            this.AutoRunesSelectToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoRunesSelectToggle_CheckedChanged);
            // 
            // AutoChatSpamToggle
            // 
            this.AutoChatSpamToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoChatSpamToggle.Checked = false;
            this.AutoChatSpamToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoChatSpamToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoChatSpamToggle.Location = new System.Drawing.Point(548, 133);
            this.AutoChatSpamToggle.Name = "AutoChatSpamToggle";
            this.AutoChatSpamToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoChatSpamToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoChatSpamToggle.TabIndex = 78;
            this.AutoChatSpamToggle.Text = "flatToggle5";
            this.AutoChatSpamToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoChatSpamToggle_CheckedChanged);
            // 
            // AutoChampSelectToggle
            // 
            this.AutoChampSelectToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoChampSelectToggle.Checked = false;
            this.AutoChampSelectToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoChampSelectToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoChampSelectToggle.Location = new System.Drawing.Point(548, 213);
            this.AutoChampSelectToggle.Name = "AutoChampSelectToggle";
            this.AutoChampSelectToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoChampSelectToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoChampSelectToggle.TabIndex = 77;
            this.AutoChampSelectToggle.Text = "flatToggle4";
            this.AutoChampSelectToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoChampSelectToggle_CheckedChanged);
            // 
            // AutoAcceptToggle
            // 
            this.AutoAcceptToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoAcceptToggle.Checked = false;
            this.AutoAcceptToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoAcceptToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoAcceptToggle.Location = new System.Drawing.Point(548, 94);
            this.AutoAcceptToggle.Name = "AutoAcceptToggle";
            this.AutoAcceptToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoAcceptToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoAcceptToggle.TabIndex = 76;
            this.AutoAcceptToggle.Text = "flatToggle3";
            this.AutoAcceptToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoAcceptToggle_CheckedChanged);
            // 
            // AutoLoginToggle
            // 
            this.AutoLoginToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoLoginToggle.Checked = false;
            this.AutoLoginToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLoginToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoLoginToggle.Location = new System.Drawing.Point(548, 55);
            this.AutoLoginToggle.Name = "AutoLoginToggle";
            this.AutoLoginToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoLoginToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoLoginToggle.TabIndex = 75;
            this.AutoLoginToggle.Text = "flatToggle2";
            this.AutoLoginToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoLoginToggle_CheckedChanged);
            // 
            // AutoStartLeagueAppStartToggle
            // 
            this.AutoStartLeagueAppStartToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoStartLeagueAppStartToggle.Checked = false;
            this.AutoStartLeagueAppStartToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoStartLeagueAppStartToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoStartLeagueAppStartToggle.Location = new System.Drawing.Point(548, 16);
            this.AutoStartLeagueAppStartToggle.Name = "AutoStartLeagueAppStartToggle";
            this.AutoStartLeagueAppStartToggle.Options = League_All_in_One.FlatToggle._Options.Style3;
            this.AutoStartLeagueAppStartToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoStartLeagueAppStartToggle.TabIndex = 74;
            this.AutoStartLeagueAppStartToggle.Text = "flatToggle1";
            this.AutoStartLeagueAppStartToggle.CheckedChanged += new League_All_in_One.FlatToggle.CheckedChangedEventHandler(this.AutoStartLeagueAppStartToggle_CheckedChanged);
            // 
            // AutoRunesSelectLabel
            // 
            this.AutoRunesSelectLabel.AutoSize = true;
            this.AutoRunesSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoRunesSelectLabel.Depth = 0;
            this.AutoRunesSelectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoRunesSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoRunesSelectLabel.Location = new System.Drawing.Point(406, 180);
            this.AutoRunesSelectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoRunesSelectLabel.Name = "AutoRunesSelectLabel";
            this.AutoRunesSelectLabel.Size = new System.Drawing.Size(136, 19);
            this.AutoRunesSelectLabel.TabIndex = 72;
            this.AutoRunesSelectLabel.Text = "Auto Runes Select:";
            // 
            // AutoChatSpamLabel
            // 
            this.AutoChatSpamLabel.AutoSize = true;
            this.AutoChatSpamLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoChatSpamLabel.Depth = 0;
            this.AutoChatSpamLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChatSpamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChatSpamLabel.Location = new System.Drawing.Point(420, 139);
            this.AutoChatSpamLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChatSpamLabel.Name = "AutoChatSpamLabel";
            this.AutoChatSpamLabel.Size = new System.Drawing.Size(122, 19);
            this.AutoChatSpamLabel.TabIndex = 70;
            this.AutoChatSpamLabel.Text = "Auto Chat Spam:";
            // 
            // AutoChampSelectLabel
            // 
            this.AutoChampSelectLabel.AutoSize = true;
            this.AutoChampSelectLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoChampSelectLabel.Depth = 0;
            this.AutoChampSelectLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoChampSelectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoChampSelectLabel.Location = new System.Drawing.Point(400, 219);
            this.AutoChampSelectLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoChampSelectLabel.Name = "AutoChampSelectLabel";
            this.AutoChampSelectLabel.Size = new System.Drawing.Size(142, 19);
            this.AutoChampSelectLabel.TabIndex = 68;
            this.AutoChampSelectLabel.Text = "Auto Champ Select:";
            // 
            // AutoAcceptLabel
            // 
            this.AutoAcceptLabel.AutoSize = true;
            this.AutoAcceptLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoAcceptLabel.Depth = 0;
            this.AutoAcceptLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoAcceptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoAcceptLabel.Location = new System.Drawing.Point(437, 100);
            this.AutoAcceptLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoAcceptLabel.Name = "AutoAcceptLabel";
            this.AutoAcceptLabel.Size = new System.Drawing.Size(96, 19);
            this.AutoAcceptLabel.TabIndex = 66;
            this.AutoAcceptLabel.Text = "Auto Accept:";
            // 
            // AutoLoginLabel
            // 
            this.AutoLoginLabel.AutoSize = true;
            this.AutoLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.AutoLoginLabel.Depth = 0;
            this.AutoLoginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoLoginLabel.Location = new System.Drawing.Point(456, 61);
            this.AutoLoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoLoginLabel.Name = "AutoLoginLabel";
            this.AutoLoginLabel.Size = new System.Drawing.Size(86, 19);
            this.AutoLoginLabel.TabIndex = 64;
            this.AutoLoginLabel.Text = "Auto Login:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(321, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(221, 19);
            this.materialLabel2.TabIndex = 63;
            this.materialLabel2.Text = "Auto Start League On App Start:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(642, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visuals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(650, 23);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // SettinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 492);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "SettinsForm";
            this.Text = "Settings - League";
            this.Load += new System.EventHandler(this.SettinsForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tabPage1;
        private FlatToggle AutoRunesSelectToggle;
        private FlatToggle AutoChatSpamToggle;
        private FlatToggle AutoChampSelectToggle;
        private FlatToggle AutoAcceptToggle;
        private FlatToggle AutoLoginToggle;
        private FlatToggle AutoStartLeagueAppStartToggle;
        private MaterialSkin.Controls.MaterialLabel AutoRunesSelectLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChatSpamLabel;
        private MaterialSkin.Controls.MaterialLabel AutoChampSelectLabel;
        private MaterialSkin.Controls.MaterialLabel AutoAcceptLabel;
        private MaterialSkin.Controls.MaterialLabel AutoLoginLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}