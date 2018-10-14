namespace League_All_in_One
{
    partial class LeagueAIO
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TabControllerPanel = new System.Windows.Forms.Panel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AutoAcceptToggle = new FlatUI.FlatToggle();
            this.AutoLoginLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AutoLoginToggle = new FlatUI.FlatToggle();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RememberMeTickedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RememberMeIsTickedToggle = new FlatUI.FlatToggle();
            this.flatButton1 = new FlatUI.FlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EncryptPasswordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EncryptPasswordToggle = new FlatUI.FlatToggle();
            this.RememberLoginDetailsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RememberLoginDetailsToggle = new FlatUI.FlatToggle();
            this.SaveLoginDetailsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UsernameTextbox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AutoAcceptTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoLoginTimer = new System.Windows.Forms.Timer(this.components);
            this.TakeScreenshotTimer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.TabControllerPanel.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.TabControllerPanel);
            this.MainPanel.Controls.Add(this.materialTabSelector1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.ForeColor = System.Drawing.Color.Transparent;
            this.MainPanel.Location = new System.Drawing.Point(0, 64);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(985, 672);
            this.MainPanel.TabIndex = 1;
            // 
            // TabControllerPanel
            // 
            this.TabControllerPanel.Controls.Add(this.materialTabControl1);
            this.TabControllerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControllerPanel.Location = new System.Drawing.Point(0, 43);
            this.TabControllerPanel.Name = "TabControllerPanel";
            this.TabControllerPanel.Size = new System.Drawing.Size(985, 629);
            this.TabControllerPanel.TabIndex = 2;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.tabPage6);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(985, 629);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.AutoAcceptToggle);
            this.tabPage1.Controls.Add(this.AutoLoginLabel);
            this.tabPage1.Controls.Add(this.AutoLoginToggle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(977, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(506, 291);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Auto Accept:";
            // 
            // AutoAcceptToggle
            // 
            this.AutoAcceptToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoAcceptToggle.Checked = false;
            this.AutoAcceptToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoAcceptToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoAcceptToggle.Location = new System.Drawing.Point(608, 285);
            this.AutoAcceptToggle.Name = "AutoAcceptToggle";
            this.AutoAcceptToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.AutoAcceptToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoAcceptToggle.TabIndex = 17;
            this.AutoAcceptToggle.Text = "flatToggle4";
            // 
            // AutoLoginLabel
            // 
            this.AutoLoginLabel.AutoSize = true;
            this.AutoLoginLabel.Depth = 0;
            this.AutoLoginLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AutoLoginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AutoLoginLabel.Location = new System.Drawing.Point(312, 291);
            this.AutoLoginLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AutoLoginLabel.Name = "AutoLoginLabel";
            this.AutoLoginLabel.Size = new System.Drawing.Size(86, 19);
            this.AutoLoginLabel.TabIndex = 16;
            this.AutoLoginLabel.Text = "Auto Login:";
            // 
            // AutoLoginToggle
            // 
            this.AutoLoginToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoLoginToggle.Checked = false;
            this.AutoLoginToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoLoginToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AutoLoginToggle.Location = new System.Drawing.Point(404, 285);
            this.AutoLoginToggle.Name = "AutoLoginToggle";
            this.AutoLoginToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.AutoLoginToggle.Size = new System.Drawing.Size(76, 33);
            this.AutoLoginToggle.TabIndex = 15;
            this.AutoLoginToggle.Text = "flatToggle3";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.RememberMeTickedLabel);
            this.tabPage2.Controls.Add(this.RememberMeIsTickedToggle);
            this.tabPage2.Controls.Add(this.flatButton1);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.EncryptPasswordLabel);
            this.tabPage2.Controls.Add(this.EncryptPasswordToggle);
            this.tabPage2.Controls.Add(this.RememberLoginDetailsLabel);
            this.tabPage2.Controls.Add(this.RememberLoginDetailsToggle);
            this.tabPage2.Controls.Add(this.SaveLoginDetailsButton);
            this.tabPage2.Controls.Add(this.passwordLabel);
            this.tabPage2.Controls.Add(this.PasswordTextbox);
            this.tabPage2.Controls.Add(this.usernameLabel);
            this.tabPage2.Controls.Add(this.UsernameTextbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(977, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auto Login/Auto Accept";
            // 
            // RememberMeTickedLabel
            // 
            this.RememberMeTickedLabel.AutoSize = true;
            this.RememberMeTickedLabel.Depth = 0;
            this.RememberMeTickedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RememberMeTickedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RememberMeTickedLabel.Location = new System.Drawing.Point(26, 106);
            this.RememberMeTickedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberMeTickedLabel.Name = "RememberMeTickedLabel";
            this.RememberMeTickedLabel.Size = new System.Drawing.Size(171, 19);
            this.RememberMeTickedLabel.TabIndex = 15;
            this.RememberMeTickedLabel.Text = "Remember me is ticked:";
            // 
            // RememberMeIsTickedToggle
            // 
            this.RememberMeIsTickedToggle.BackColor = System.Drawing.Color.Transparent;
            this.RememberMeIsTickedToggle.Checked = false;
            this.RememberMeIsTickedToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberMeIsTickedToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RememberMeIsTickedToggle.Location = new System.Drawing.Point(203, 100);
            this.RememberMeIsTickedToggle.Name = "RememberMeIsTickedToggle";
            this.RememberMeIsTickedToggle.Options = FlatUI.FlatToggle._Options.Style2;
            this.RememberMeIsTickedToggle.Size = new System.Drawing.Size(76, 33);
            this.RememberMeIsTickedToggle.TabIndex = 14;
            this.RememberMeIsTickedToggle.Text = "flatToggle1";
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(153, 390);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 32);
            this.flatButton1.TabIndex = 13;
            this.flatButton1.Text = "flatButton1";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(436, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(436, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EncryptPasswordLabel
            // 
            this.EncryptPasswordLabel.AutoSize = true;
            this.EncryptPasswordLabel.Depth = 0;
            this.EncryptPasswordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.EncryptPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EncryptPasswordLabel.Location = new System.Drawing.Point(64, 184);
            this.EncryptPasswordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.EncryptPasswordLabel.Name = "EncryptPasswordLabel";
            this.EncryptPasswordLabel.Size = new System.Drawing.Size(133, 19);
            this.EncryptPasswordLabel.TabIndex = 10;
            this.EncryptPasswordLabel.Text = "Encrypt Password:";
            // 
            // EncryptPasswordToggle
            // 
            this.EncryptPasswordToggle.BackColor = System.Drawing.Color.Transparent;
            this.EncryptPasswordToggle.Checked = false;
            this.EncryptPasswordToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncryptPasswordToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EncryptPasswordToggle.Location = new System.Drawing.Point(203, 178);
            this.EncryptPasswordToggle.Name = "EncryptPasswordToggle";
            this.EncryptPasswordToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.EncryptPasswordToggle.Size = new System.Drawing.Size(76, 33);
            this.EncryptPasswordToggle.TabIndex = 9;
            this.EncryptPasswordToggle.Text = "flatToggle2";
            // 
            // RememberLoginDetailsLabel
            // 
            this.RememberLoginDetailsLabel.AutoSize = true;
            this.RememberLoginDetailsLabel.Depth = 0;
            this.RememberLoginDetailsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RememberLoginDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RememberLoginDetailsLabel.Location = new System.Drawing.Point(20, 145);
            this.RememberLoginDetailsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RememberLoginDetailsLabel.Name = "RememberLoginDetailsLabel";
            this.RememberLoginDetailsLabel.Size = new System.Drawing.Size(177, 19);
            this.RememberLoginDetailsLabel.TabIndex = 8;
            this.RememberLoginDetailsLabel.Text = "Remember Login Details:";
            // 
            // RememberLoginDetailsToggle
            // 
            this.RememberLoginDetailsToggle.BackColor = System.Drawing.Color.Transparent;
            this.RememberLoginDetailsToggle.Checked = false;
            this.RememberLoginDetailsToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RememberLoginDetailsToggle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RememberLoginDetailsToggle.Location = new System.Drawing.Point(203, 139);
            this.RememberLoginDetailsToggle.Name = "RememberLoginDetailsToggle";
            this.RememberLoginDetailsToggle.Options = FlatUI.FlatToggle._Options.Style3;
            this.RememberLoginDetailsToggle.Size = new System.Drawing.Size(76, 33);
            this.RememberLoginDetailsToggle.TabIndex = 7;
            this.RememberLoginDetailsToggle.Text = "flatToggle1";
            // 
            // SaveLoginDetailsButton
            // 
            this.SaveLoginDetailsButton.AutoSize = true;
            this.SaveLoginDetailsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveLoginDetailsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveLoginDetailsButton.Depth = 0;
            this.SaveLoginDetailsButton.Icon = null;
            this.SaveLoginDetailsButton.Location = new System.Drawing.Point(100, 248);
            this.SaveLoginDetailsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveLoginDetailsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveLoginDetailsButton.Name = "SaveLoginDetailsButton";
            this.SaveLoginDetailsButton.Primary = false;
            this.SaveLoginDetailsButton.Size = new System.Drawing.Size(159, 36);
            this.SaveLoginDetailsButton.TabIndex = 6;
            this.SaveLoginDetailsButton.Text = "Save Login  Details";
            this.SaveLoginDetailsButton.UseVisualStyleBackColor = true;
            this.SaveLoginDetailsButton.Click += new System.EventHandler(this.SaveLoginDetailsButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(20, 55);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Depth = 0;
            this.PasswordTextbox.Hint = "";
            this.PasswordTextbox.Location = new System.Drawing.Point(105, 55);
            this.PasswordTextbox.MaxLength = 32767;
            this.PasswordTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '\0';
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.SelectionLength = 0;
            this.PasswordTextbox.SelectionStart = 0;
            this.PasswordTextbox.Size = new System.Drawing.Size(174, 23);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.TabStop = false;
            this.PasswordTextbox.UseSystemPasswordChar = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(18, 16);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Depth = 0;
            this.UsernameTextbox.Hint = "";
            this.UsernameTextbox.Location = new System.Drawing.Point(105, 16);
            this.UsernameTextbox.MaxLength = 32767;
            this.UsernameTextbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.SelectionLength = 0;
            this.UsernameTextbox.SelectionStart = 0;
            this.UsernameTextbox.Size = new System.Drawing.Size(174, 23);
            this.UsernameTextbox.TabIndex = 0;
            this.UsernameTextbox.TabStop = false;
            this.UsernameTextbox.UseSystemPasswordChar = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(977, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Champ Select/Instant Lock";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(977, 603);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Chat Spamming";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(977, 603);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Change Runes";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(977, 603);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Check Builds";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(985, 43);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // AutoAcceptTimer
            // 
            this.AutoAcceptTimer.Interval = 500;
            this.AutoAcceptTimer.Tick += new System.EventHandler(this.AutoAcceptTimer_Tick);
            // 
            // AutoLoginTimer
            // 
            this.AutoLoginTimer.Interval = 500;
            this.AutoLoginTimer.Tick += new System.EventHandler(this.AutoLoginTimer_Tick);
            // 
            // TakeScreenshotTimer
            // 
            this.TakeScreenshotTimer.Interval = 500;
            this.TakeScreenshotTimer.Tick += new System.EventHandler(this.TakeScreenshotTimer_Tick);
            // 
            // LeagueAIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 736);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.Name = "LeagueAIO";
            this.Text = "All For One - League";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.TabControllerPanel.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Panel TabControllerPanel;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Timer AutoAcceptTimer;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTextbox;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField UsernameTextbox;
        private MaterialSkin.Controls.MaterialFlatButton SaveLoginDetailsButton;
        private System.Windows.Forms.Timer AutoLoginTimer;
        private FlatUI.FlatToggle RememberLoginDetailsToggle;
        private MaterialSkin.Controls.MaterialLabel EncryptPasswordLabel;
        private FlatUI.FlatToggle EncryptPasswordToggle;
        private MaterialSkin.Controls.MaterialLabel RememberLoginDetailsLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FlatUI.FlatToggle AutoAcceptToggle;
        private MaterialSkin.Controls.MaterialLabel AutoLoginLabel;
        private FlatUI.FlatToggle AutoLoginToggle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatButton flatButton1;
        private MaterialSkin.Controls.MaterialLabel RememberMeTickedLabel;
        private FlatUI.FlatToggle RememberMeIsTickedToggle;
        private System.Windows.Forms.Timer TakeScreenshotTimer;
    }
}

