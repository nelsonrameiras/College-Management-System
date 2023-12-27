namespace CollegeManagementSystem
{
    partial class FormDisenrollStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisenrollStudent));
            this.deleteStudentRecordPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationIdLabel = new System.Windows.Forms.Label();
            this.registrationIdTextBox = new System.Windows.Forms.TextBox();
            this.deleteStudentRecordButton = new System.Windows.Forms.Button();
            this.deleteStudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.deleteStudentRecordPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteStudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteStudentRecordPictureBox
            // 
            this.deleteStudentRecordPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteStudentRecordPictureBox.Image")));
            this.deleteStudentRecordPictureBox.Location = new System.Drawing.Point(12, 20);
            this.deleteStudentRecordPictureBox.Name = "deleteStudentRecordPictureBox";
            this.deleteStudentRecordPictureBox.Size = new System.Drawing.Size(128, 132);
            this.deleteStudentRecordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteStudentRecordPictureBox.TabIndex = 0;
            this.deleteStudentRecordPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disenroll Student";
            // 
            // registrationIdLabel
            // 
            this.registrationIdLabel.AutoSize = true;
            this.registrationIdLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationIdLabel.Location = new System.Drawing.Point(152, 123);
            this.registrationIdLabel.Name = "registrationIdLabel";
            this.registrationIdLabel.Size = new System.Drawing.Size(178, 29);
            this.registrationIdLabel.TabIndex = 2;
            this.registrationIdLabel.Text = "Registration Id:";
            // 
            // registrationIdTextBox
            // 
            this.registrationIdTextBox.Location = new System.Drawing.Point(395, 125);
            this.registrationIdTextBox.Name = "registrationIdTextBox";
            this.registrationIdTextBox.Size = new System.Drawing.Size(216, 27);
            this.registrationIdTextBox.TabIndex = 3;
            // 
            // deleteStudentRecordButton
            // 
            this.deleteStudentRecordButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteStudentRecordButton.Location = new System.Drawing.Point(268, 187);
            this.deleteStudentRecordButton.Name = "deleteStudentRecordButton";
            this.deleteStudentRecordButton.Size = new System.Drawing.Size(116, 39);
            this.deleteStudentRecordButton.TabIndex = 4;
            this.deleteStudentRecordButton.Text = "Disenroll";
            this.deleteStudentRecordButton.UseVisualStyleBackColor = false;
            this.deleteStudentRecordButton.Click += new System.EventHandler(this.deleteStudentRecordButton_Click);
            // 
            // deleteStudentRecordDataGridView
            // 
            this.deleteStudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteStudentRecordDataGridView.Location = new System.Drawing.Point(37, 258);
            this.deleteStudentRecordDataGridView.Name = "deleteStudentRecordDataGridView";
            this.deleteStudentRecordDataGridView.Size = new System.Drawing.Size(582, 223);
            this.deleteStudentRecordDataGridView.TabIndex = 5;
            // 
            // FormDisenrollStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 511);
            this.Controls.Add(this.deleteStudentRecordDataGridView);
            this.Controls.Add(this.deleteStudentRecordButton);
            this.Controls.Add(this.registrationIdTextBox);
            this.Controls.Add(this.registrationIdLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteStudentRecordPictureBox);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormDisenrollStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disenroll Student";
            this.Load += new System.EventHandler(this.FormDisenrollStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteStudentRecordPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteStudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox deleteStudentRecordPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label registrationIdLabel;
        private System.Windows.Forms.TextBox registrationIdTextBox;
        private System.Windows.Forms.Button deleteStudentRecordButton;
        private System.Windows.Forms.DataGridView deleteStudentRecordDataGridView;
    }
}