namespace CollegeManagementSystem
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
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.titleLabel2 = new System.Windows.Forms.Label();
            this.titleLabel3 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passwordLoginLabel = new System.Windows.Forms.Label();
            this.usernameLoginLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.admissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdmissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pupilDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfessorInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disenrollPupilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Montserrat", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.Location = new System.Drawing.Point(63, 697);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(194, 60);
            this.titleLabel1.TabIndex = 0;
            this.titleLabel1.Text = "College";
            // 
            // titleLabel2
            // 
            this.titleLabel2.AutoSize = true;
            this.titleLabel2.Font = new System.Drawing.Font("Montserrat", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel2.Location = new System.Drawing.Point(258, 780);
            this.titleLabel2.Name = "titleLabel2";
            this.titleLabel2.Size = new System.Drawing.Size(328, 60);
            this.titleLabel2.TabIndex = 1;
            this.titleLabel2.Text = "Management";
            // 
            // titleLabel3
            // 
            this.titleLabel3.AutoSize = true;
            this.titleLabel3.Font = new System.Drawing.Font("Montserrat", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel3.Location = new System.Drawing.Point(584, 864);
            this.titleLabel3.Name = "titleLabel3";
            this.titleLabel3.Size = new System.Drawing.Size(227, 60);
            this.titleLabel3.TabIndex = 2;
            this.titleLabel3.Text = "Software";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordTextBox);
            this.loginPanel.Controls.Add(this.usernameTextBox);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.passwordLoginLabel);
            this.loginPanel.Controls.Add(this.usernameLoginLabel);
            this.loginPanel.Location = new System.Drawing.Point(765, 371);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(364, 210);
            this.loginPanel.TabIndex = 3;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginButton.Location = new System.Drawing.Point(135, 158);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(98, 37);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(180, 116);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(145, 27);
            this.passwordTextBox.TabIndex = 5;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(180, 79);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(145, 27);
            this.usernameTextBox.TabIndex = 4;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Montserrat ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(128, 16);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(105, 37);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // passwordLoginLabel
            // 
            this.passwordLoginLabel.AutoSize = true;
            this.passwordLoginLabel.Location = new System.Drawing.Point(38, 117);
            this.passwordLoginLabel.Name = "passwordLoginLabel";
            this.passwordLoginLabel.Size = new System.Drawing.Size(111, 26);
            this.passwordLoginLabel.TabIndex = 1;
            this.passwordLoginLabel.Text = "Password:";
            // 
            // usernameLoginLabel
            // 
            this.usernameLoginLabel.AutoSize = true;
            this.usernameLoginLabel.Location = new System.Drawing.Point(38, 79);
            this.usernameLoginLabel.Name = "usernameLoginLabel";
            this.usernameLoginLabel.Size = new System.Drawing.Size(117, 26);
            this.usernameLoginLabel.TabIndex = 0;
            this.usernameLoginLabel.Text = "Username:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionsToolStripMenuItem,
            this.feesToolStripMenuItem,
            this.pupilDetailsToolStripMenuItem,
            this.professorsToolStripMenuItem,
            this.disenrollPupilToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitSoftwareToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1592, 88);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // admissionsToolStripMenuItem
            // 
            this.admissionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdmissionToolStripMenuItem,
            this.upgradeSemesterToolStripMenuItem});
            this.admissionsToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admissionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("admissionsToolStripMenuItem.Image")));
            this.admissionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.admissionsToolStripMenuItem.Name = "admissionsToolStripMenuItem";
            this.admissionsToolStripMenuItem.Size = new System.Drawing.Size(89, 84);
            this.admissionsToolStripMenuItem.Text = "Admissions";
            this.admissionsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // newAdmissionToolStripMenuItem
            // 
            this.newAdmissionToolStripMenuItem.Name = "newAdmissionToolStripMenuItem";
            this.newAdmissionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newAdmissionToolStripMenuItem.Text = "New Admission";
            this.newAdmissionToolStripMenuItem.Click += new System.EventHandler(this.newAdmissionToolStripMenuItem_Click);
            // 
            // upgradeSemesterToolStripMenuItem
            // 
            this.upgradeSemesterToolStripMenuItem.Name = "upgradeSemesterToolStripMenuItem";
            this.upgradeSemesterToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.upgradeSemesterToolStripMenuItem.Text = "Upgrade Semester";
            this.upgradeSemesterToolStripMenuItem.Click += new System.EventHandler(this.upgradeSemesterToolStripMenuItem_Click);
            // 
            // feesToolStripMenuItem
            // 
            this.feesToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("feesToolStripMenuItem.Image")));
            this.feesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.feesToolStripMenuItem.Name = "feesToolStripMenuItem";
            this.feesToolStripMenuItem.Size = new System.Drawing.Size(76, 84);
            this.feesToolStripMenuItem.Text = "Fees";
            this.feesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // pupilDetailsToolStripMenuItem
            // 
            this.pupilDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchPupilToolStripMenuItem,
            this.individualDetailsToolStripMenuItem});
            this.pupilDetailsToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pupilDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pupilDetailsToolStripMenuItem.Image")));
            this.pupilDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pupilDetailsToolStripMenuItem.Name = "pupilDetailsToolStripMenuItem";
            this.pupilDetailsToolStripMenuItem.Size = new System.Drawing.Size(94, 84);
            this.pupilDetailsToolStripMenuItem.Text = "Pupil Details";
            this.pupilDetailsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // searchPupilToolStripMenuItem
            // 
            this.searchPupilToolStripMenuItem.Name = "searchPupilToolStripMenuItem";
            this.searchPupilToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.searchPupilToolStripMenuItem.Text = "Search Pupil";
            // 
            // individualDetailsToolStripMenuItem
            // 
            this.individualDetailsToolStripMenuItem.Name = "individualDetailsToolStripMenuItem";
            this.individualDetailsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.individualDetailsToolStripMenuItem.Text = "Individual Details";
            // 
            // professorsToolStripMenuItem
            // 
            this.professorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProfessorInformationToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.professorsToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("professorsToolStripMenuItem.Image")));
            this.professorsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            this.professorsToolStripMenuItem.Size = new System.Drawing.Size(83, 84);
            this.professorsToolStripMenuItem.Text = "Professors";
            this.professorsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // addProfessorInformationToolStripMenuItem
            // 
            this.addProfessorInformationToolStripMenuItem.Name = "addProfessorInformationToolStripMenuItem";
            this.addProfessorInformationToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.addProfessorInformationToolStripMenuItem.Text = "Add Professor Information";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // disenrollPupilToolStripMenuItem
            // 
            this.disenrollPupilToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disenrollPupilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("disenrollPupilToolStripMenuItem.Image")));
            this.disenrollPupilToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.disenrollPupilToolStripMenuItem.Name = "disenrollPupilToolStripMenuItem";
            this.disenrollPupilToolStripMenuItem.Size = new System.Drawing.Size(106, 84);
            this.disenrollPupilToolStripMenuItem.Text = "Disenroll Pupil";
            this.disenrollPupilToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutUsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutUsToolStripMenuItem.Image")));
            this.aboutUsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(76, 84);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // exitSoftwareToolStripMenuItem
            // 
            this.exitSoftwareToolStripMenuItem.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitSoftwareToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitSoftwareToolStripMenuItem.Image")));
            this.exitSoftwareToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitSoftwareToolStripMenuItem.Name = "exitSoftwareToolStripMenuItem";
            this.exitSoftwareToolStripMenuItem.Size = new System.Drawing.Size(98, 84);
            this.exitSoftwareToolStripMenuItem.Text = "Exit Software";
            this.exitSoftwareToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1592, 897);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.titleLabel3);
            this.Controls.Add(this.titleLabel2);
            this.Controls.Add(this.titleLabel1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Label titleLabel2;
        private System.Windows.Forms.Label titleLabel3;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordLoginLabel;
        private System.Windows.Forms.Label usernameLoginLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem admissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pupilDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disenrollPupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdmissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upgradeSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchPupilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfessorInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}

