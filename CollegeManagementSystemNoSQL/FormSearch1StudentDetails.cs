using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class FormSearch1StudentDetails : Form
    {
        public FormSearch1StudentDetails()
        {
            InitializeComponent();
        }


        //// Does not fullly Work without SQL

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            // SQL CODE

            if(registrationIdTextBox.Text.Length != 0 ) // One Check missing
            {
                // SQL Application
            }
            else {
                MessageBox.Show("That Student Registration ID is invalid. Please, enter a valid NAID.",
                    "Invalid Registration ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetButton_Click(sender, e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            registrationIdTextBox.Clear();
            fullNamePlaceHolderLabel.Text = "______________________";
            motherNamePlaceHolderLabel.Text = "______________________";
            genderPlaceHolderLabel.Text = "______________________";
            dateOfBirthPlaceHolderLabel.Text = "______________________";
            mobileNumberPlaceHolderLabel.Text = "______________________";
            emailIdPlaceHolderLabel.Text = "______________________";
            semesterPlaceHolderLabel.Text = "______________________";
            programmingLanguagePlaceHolderLabel.Text = "______________________";
            schoolNamePlaceHolderLabel.Text = "______________________";
            durationPlaceHolderLabel.Text = "______________________";
            addressPlaceHolderLabel.Text = "______________________";
        }
    }
}
