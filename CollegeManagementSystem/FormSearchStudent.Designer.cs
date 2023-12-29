namespace CollegeManagementSystem
{
    partial class FormSearchStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchStudent));
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationIdLabel = new System.Windows.Forms.Label();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchStudentsButton = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchAllRadioButton = new System.Windows.Forms.RadioButton();
            this.searchOnlyWithFeesRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(22, 23);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(134, 132);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 0;
            this.userPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Students";
            // 
            // registrationIdLabel
            // 
            this.registrationIdLabel.AutoSize = true;
            this.registrationIdLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationIdLabel.Location = new System.Drawing.Point(187, 105);
            this.registrationIdLabel.Name = "registrationIdLabel";
            this.registrationIdLabel.Size = new System.Drawing.Size(181, 29);
            this.registrationIdLabel.TabIndex = 2;
            this.registrationIdLabel.Text = "Registration Id:";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(453, 107);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(231, 27);
            this.registrationNumberTextBox.TabIndex = 3;
            // 
            // searchStudentsButton
            // 
            this.searchStudentsButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchStudentsButton.Location = new System.Drawing.Point(390, 168);
            this.searchStudentsButton.Name = "searchStudentsButton";
            this.searchStudentsButton.Size = new System.Drawing.Size(99, 37);
            this.searchStudentsButton.TabIndex = 4;
            this.searchStudentsButton.Text = "Search";
            this.searchStudentsButton.UseVisualStyleBackColor = false;
            this.searchStudentsButton.Click += new System.EventHandler(this.searchStudentsButton_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AllowUserToAddRows = false;
            this.studentsDataGridView.AllowUserToDeleteRows = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Location = new System.Drawing.Point(33, 233);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.ReadOnly = true;
            this.studentsDataGridView.Size = new System.Drawing.Size(752, 254);
            this.studentsDataGridView.TabIndex = 5;
            // 
            // searchAllRadioButton
            // 
            this.searchAllRadioButton.AutoSize = true;
            this.searchAllRadioButton.Location = new System.Drawing.Point(192, 147);
            this.searchAllRadioButton.Name = "searchAllRadioButton";
            this.searchAllRadioButton.Size = new System.Drawing.Size(48, 26);
            this.searchAllRadioButton.TabIndex = 6;
            this.searchAllRadioButton.TabStop = true;
            this.searchAllRadioButton.Text = "All";
            this.searchAllRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchOnlyWithFeesRadioButton
            // 
            this.searchOnlyWithFeesRadioButton.AutoSize = true;
            this.searchOnlyWithFeesRadioButton.Location = new System.Drawing.Point(192, 179);
            this.searchOnlyWithFeesRadioButton.Name = "searchOnlyWithFeesRadioButton";
            this.searchOnlyWithFeesRadioButton.Size = new System.Drawing.Size(147, 26);
            this.searchOnlyWithFeesRadioButton.TabIndex = 7;
            this.searchOnlyWithFeesRadioButton.TabStop = true;
            this.searchOnlyWithFeesRadioButton.Text = "Only with Fees";
            this.searchOnlyWithFeesRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormSearchStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 511);
            this.Controls.Add(this.searchOnlyWithFeesRadioButton);
            this.Controls.Add(this.searchAllRadioButton);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.searchStudentsButton);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.registrationIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userPictureBox);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSearchStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.Load += new System.EventHandler(this.FormSearchStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registrationIdLabel;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Button searchStudentsButton;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.RadioButton searchAllRadioButton;
        private System.Windows.Forms.RadioButton searchOnlyWithFeesRadioButton;
    }
}