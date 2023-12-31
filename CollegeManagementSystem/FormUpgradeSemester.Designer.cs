namespace CollegeManagementSystem
{
    partial class FormUpgradeSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpgradeSemester));
            this.semesterCalendarPictureBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.fromSemesterUpgradeComboBox = new System.Windows.Forms.ComboBox();
            this.toSemesterUpgradeComboBox = new System.Windows.Forms.ComboBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.specificStudentRadioButton = new System.Windows.Forms.RadioButton();
            this.studentListComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.semesterCalendarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // semesterCalendarPictureBox
            // 
            this.semesterCalendarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("semesterCalendarPictureBox.Image")));
            this.semesterCalendarPictureBox.Location = new System.Drawing.Point(185, 12);
            this.semesterCalendarPictureBox.Name = "semesterCalendarPictureBox";
            this.semesterCalendarPictureBox.Size = new System.Drawing.Size(278, 182);
            this.semesterCalendarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.semesterCalendarPictureBox.TabIndex = 0;
            this.semesterCalendarPictureBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(143, 217);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(365, 22);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Select Semester for Old Pupils\' Admission:";
            // 
            // fromSemesterUpgradeComboBox
            // 
            this.fromSemesterUpgradeComboBox.FormattingEnabled = true;
            this.fromSemesterUpgradeComboBox.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "3rd Semester",
            "4th Semester",
            "5th Semester",
            "6th Semester"});
            this.fromSemesterUpgradeComboBox.Location = new System.Drawing.Point(296, 266);
            this.fromSemesterUpgradeComboBox.Name = "fromSemesterUpgradeComboBox";
            this.fromSemesterUpgradeComboBox.Size = new System.Drawing.Size(283, 30);
            this.fromSemesterUpgradeComboBox.TabIndex = 2;
            this.fromSemesterUpgradeComboBox.Text = "--  Choose an Option  --";
            // 
            // toSemesterUpgradeComboBox
            // 
            this.toSemesterUpgradeComboBox.FormattingEnabled = true;
            this.toSemesterUpgradeComboBox.Items.AddRange(new object[] {
            "1st Semester",
            "2nd Semester",
            "3rd Semester",
            "4th Semester",
            "5th Semester",
            "6th Semester"});
            this.toSemesterUpgradeComboBox.Location = new System.Drawing.Point(296, 355);
            this.toSemesterUpgradeComboBox.Name = "toSemesterUpgradeComboBox";
            this.toSemesterUpgradeComboBox.Size = new System.Drawing.Size(283, 30);
            this.toSemesterUpgradeComboBox.TabIndex = 4;
            this.toSemesterUpgradeComboBox.Text = "--  Choose an Option  --";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(62, 266);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(58, 22);
            this.fromLabel.TabIndex = 5;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toLabel.Location = new System.Drawing.Point(62, 363);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(33, 22);
            this.toLabel.TabIndex = 6;
            this.toLabel.Text = "To:";
            // 
            // upgradeButton
            // 
            this.upgradeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.upgradeButton.Location = new System.Drawing.Point(273, 416);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(104, 35);
            this.upgradeButton.TabIndex = 7;
            this.upgradeButton.Text = "Upgrade";
            this.upgradeButton.UseVisualStyleBackColor = false;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // specificStudentRadioButton
            // 
            this.specificStudentRadioButton.AutoSize = true;
            this.specificStudentRadioButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificStudentRadioButton.Location = new System.Drawing.Point(66, 312);
            this.specificStudentRadioButton.Name = "specificStudentRadioButton";
            this.specificStudentRadioButton.Size = new System.Drawing.Size(169, 26);
            this.specificStudentRadioButton.TabIndex = 8;
            this.specificStudentRadioButton.TabStop = true;
            this.specificStudentRadioButton.Text = "Specific Student:";
            this.specificStudentRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentListComboBox
            // 
            this.studentListComboBox.FormattingEnabled = true;
            this.studentListComboBox.Location = new System.Drawing.Point(296, 311);
            this.studentListComboBox.Name = "studentListComboBox";
            this.studentListComboBox.Size = new System.Drawing.Size(283, 30);
            this.studentListComboBox.TabIndex = 9;
            this.studentListComboBox.Text = "-- Choose an Option --";
            this.studentListComboBox.SelectedIndexChanged += new System.EventHandler(this.studentListComboBox_SelectedIndexChanged);
            // 
            // FormUpgradeSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(645, 482);
            this.Controls.Add(this.studentListComboBox);
            this.Controls.Add(this.specificStudentRadioButton);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toSemesterUpgradeComboBox);
            this.Controls.Add(this.fromSemesterUpgradeComboBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.semesterCalendarPictureBox);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUpgradeSemester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade Semester";
            this.Load += new System.EventHandler(this.FormUpgradeSemester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.semesterCalendarPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox semesterCalendarPictureBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox fromSemesterUpgradeComboBox;
        private System.Windows.Forms.ComboBox toSemesterUpgradeComboBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Button upgradeButton;
        private System.Windows.Forms.RadioButton specificStudentRadioButton;
        private System.Windows.Forms.ComboBox studentListComboBox;
    }
}