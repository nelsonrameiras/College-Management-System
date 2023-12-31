namespace CollegeManagementSystem
{
    partial class FormSearchTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchTeacher));
            this.teachersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTeachersButton = new System.Windows.Forms.Button();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.registrationIdLabel = new System.Windows.Forms.Label();
            this.searchTeachersLabel = new System.Windows.Forms.Label();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // teachersDataGridView
            // 
            this.teachersDataGridView.AllowUserToAddRows = false;
            this.teachersDataGridView.AllowUserToDeleteRows = false;
            this.teachersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachersDataGridView.Location = new System.Drawing.Point(34, 235);
            this.teachersDataGridView.Name = "teachersDataGridView";
            this.teachersDataGridView.ReadOnly = true;
            this.teachersDataGridView.Size = new System.Drawing.Size(752, 254);
            this.teachersDataGridView.TabIndex = 13;
            // 
            // searchTeachersButton
            // 
            this.searchTeachersButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.searchTeachersButton.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTeachersButton.Location = new System.Drawing.Point(363, 179);
            this.searchTeachersButton.Name = "searchTeachersButton";
            this.searchTeachersButton.Size = new System.Drawing.Size(99, 37);
            this.searchTeachersButton.TabIndex = 18;
            this.searchTeachersButton.Text = "Search";
            this.searchTeachersButton.UseVisualStyleBackColor = false;
            this.searchTeachersButton.Click += new System.EventHandler(this.searchTeachersButton_Click);
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationNumberTextBox.Location = new System.Drawing.Point(440, 133);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(231, 27);
            this.registrationNumberTextBox.TabIndex = 17;
            // 
            // registrationIdLabel
            // 
            this.registrationIdLabel.AutoSize = true;
            this.registrationIdLabel.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationIdLabel.Location = new System.Drawing.Point(192, 131);
            this.registrationIdLabel.Name = "registrationIdLabel";
            this.registrationIdLabel.Size = new System.Drawing.Size(181, 29);
            this.registrationIdLabel.TabIndex = 16;
            this.registrationIdLabel.Text = "Registration Id:";
            // 
            // searchTeachersLabel
            // 
            this.searchTeachersLabel.AutoSize = true;
            this.searchTeachersLabel.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTeachersLabel.Location = new System.Drawing.Point(219, 45);
            this.searchTeachersLabel.Name = "searchTeachersLabel";
            this.searchTeachersLabel.Size = new System.Drawing.Size(436, 66);
            this.searchTeachersLabel.TabIndex = 15;
            this.searchTeachersLabel.Text = "Search Teachers";
            // 
            // userPictureBox
            // 
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(34, 28);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(134, 132);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 14;
            this.userPictureBox.TabStop = false;
            // 
            // FormSearchTeacher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 513);
            this.Controls.Add(this.searchTeachersButton);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.registrationIdLabel);
            this.Controls.Add(this.searchTeachersLabel);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.teachersDataGridView);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearchTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Teacher";
            this.Load += new System.EventHandler(this.FormSearchTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teachersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView teachersDataGridView;
        private System.Windows.Forms.Button searchTeachersButton;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label registrationIdLabel;
        private System.Windows.Forms.Label searchTeachersLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
    }
}