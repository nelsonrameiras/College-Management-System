namespace CollegeManagementSystem
{
    partial class FormFees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFees));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registrationNumberLabel = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.motherNameLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.feesLabel = new System.Windows.Forms.Label();
            this.registrationNumberTextBox = new System.Windows.Forms.TextBox();
            this.fullNamePlaceHolderLabel = new System.Windows.Forms.Label();
            this.motherNamePlaceHolderLabel = new System.Windows.Forms.Label();
            this.durationPlaceHolderLabel = new System.Windows.Forms.Label();
            this.feesTextBox = new System.Windows.Forms.TextBox();
            this.submitFeesButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // registrationNumberLabel
            // 
            this.registrationNumberLabel.AutoSize = true;
            this.registrationNumberLabel.Location = new System.Drawing.Point(41, 202);
            this.registrationNumberLabel.Name = "registrationNumberLabel";
            this.registrationNumberLabel.Size = new System.Drawing.Size(187, 22);
            this.registrationNumberLabel.TabIndex = 1;
            this.registrationNumberLabel.Text = "Registration Number:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(41, 253);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(97, 22);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // motherNameLabel
            // 
            this.motherNameLabel.AutoSize = true;
            this.motherNameLabel.Location = new System.Drawing.Point(41, 310);
            this.motherNameLabel.Name = "motherNameLabel";
            this.motherNameLabel.Size = new System.Drawing.Size(139, 22);
            this.motherNameLabel.TabIndex = 3;
            this.motherNameLabel.Text = "Mother\'s Name:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(41, 359);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(86, 22);
            this.durationLabel.TabIndex = 4;
            this.durationLabel.Text = "Duration:";
            // 
            // feesLabel
            // 
            this.feesLabel.AutoSize = true;
            this.feesLabel.Location = new System.Drawing.Point(41, 409);
            this.feesLabel.Name = "feesLabel";
            this.feesLabel.Size = new System.Drawing.Size(52, 22);
            this.feesLabel.TabIndex = 5;
            this.feesLabel.Text = "Fees:";
            // 
            // registrationNumberTextBox
            // 
            this.registrationNumberTextBox.Location = new System.Drawing.Point(254, 203);
            this.registrationNumberTextBox.Name = "registrationNumberTextBox";
            this.registrationNumberTextBox.Size = new System.Drawing.Size(270, 27);
            this.registrationNumberTextBox.TabIndex = 6;
            this.registrationNumberTextBox.TextChanged += new System.EventHandler(this.registrationNumberTextBox_TextChanged);
            // 
            // fullNamePlaceHolderLabel
            // 
            this.fullNamePlaceHolderLabel.AutoSize = true;
            this.fullNamePlaceHolderLabel.Location = new System.Drawing.Point(250, 253);
            this.fullNamePlaceHolderLabel.Name = "fullNamePlaceHolderLabel";
            this.fullNamePlaceHolderLabel.Size = new System.Drawing.Size(274, 22);
            this.fullNamePlaceHolderLabel.TabIndex = 7;
            this.fullNamePlaceHolderLabel.Text = "_________________________________";
            // 
            // motherNamePlaceHolderLabel
            // 
            this.motherNamePlaceHolderLabel.AutoSize = true;
            this.motherNamePlaceHolderLabel.Location = new System.Drawing.Point(250, 310);
            this.motherNamePlaceHolderLabel.Name = "motherNamePlaceHolderLabel";
            this.motherNamePlaceHolderLabel.Size = new System.Drawing.Size(274, 22);
            this.motherNamePlaceHolderLabel.TabIndex = 8;
            this.motherNamePlaceHolderLabel.Text = "_________________________________";
            // 
            // durationPlaceHolderLabel
            // 
            this.durationPlaceHolderLabel.AutoSize = true;
            this.durationPlaceHolderLabel.Location = new System.Drawing.Point(250, 359);
            this.durationPlaceHolderLabel.Name = "durationPlaceHolderLabel";
            this.durationPlaceHolderLabel.Size = new System.Drawing.Size(274, 22);
            this.durationPlaceHolderLabel.TabIndex = 9;
            this.durationPlaceHolderLabel.Text = "_________________________________";
            // 
            // feesTextBox
            // 
            this.feesTextBox.Location = new System.Drawing.Point(252, 406);
            this.feesTextBox.Name = "feesTextBox";
            this.feesTextBox.Size = new System.Drawing.Size(272, 27);
            this.feesTextBox.TabIndex = 10;
            // 
            // submitFeesButton
            // 
            this.submitFeesButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.submitFeesButton.Location = new System.Drawing.Point(241, 452);
            this.submitFeesButton.Name = "submitFeesButton";
            this.submitFeesButton.Size = new System.Drawing.Size(82, 37);
            this.submitFeesButton.TabIndex = 11;
            this.submitFeesButton.Text = "Submit";
            this.submitFeesButton.UseVisualStyleBackColor = false;
            this.submitFeesButton.Click += new System.EventHandler(this.submitFeesButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(254, 237);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(224, 22);
            this.warningLabel.TabIndex = 12;
            this.warningLabel.Text = "That NAID isn\'t registered.";
            this.warningLabel.Visible = false;
            // 
            // FormFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 501);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.submitFeesButton);
            this.Controls.Add(this.feesTextBox);
            this.Controls.Add(this.durationPlaceHolderLabel);
            this.Controls.Add(this.motherNamePlaceHolderLabel);
            this.Controls.Add(this.fullNamePlaceHolderLabel);
            this.Controls.Add(this.registrationNumberTextBox);
            this.Controls.Add(this.feesLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.motherNameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.registrationNumberLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label registrationNumberLabel;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label motherNameLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label feesLabel;
        private System.Windows.Forms.TextBox registrationNumberTextBox;
        private System.Windows.Forms.Label fullNamePlaceHolderLabel;
        private System.Windows.Forms.Label motherNamePlaceHolderLabel;
        private System.Windows.Forms.Label durationPlaceHolderLabel;
        private System.Windows.Forms.TextBox feesTextBox;
        private System.Windows.Forms.Button submitFeesButton;
        private System.Windows.Forms.Label warningLabel;
    }
}