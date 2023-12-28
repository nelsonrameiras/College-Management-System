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
    public partial class FormSearch1TeacherDetails : Form
    {
        public FormSearch1TeacherDetails()
        {
            InitializeComponent();
        }

        //// Does not work without SQL

        private void showDetailsButton_Click(object sender, EventArgs e)
        { 
               // SQL CODE

                if (/*dataset.Tables[0].Rows.Count != 0 &&*/ registrationIdTextBox.Text.Length != 0)
                {
                   // SQL Application
                }
                else
                {
                    MessageBox.Show("That Student Registration ID is invalid. Please, enter a valid NAID.",
                        "Invalid Registration ID.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetButton_Click(sender, e);
                }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            registrationIdTextBox.Clear();
            fullNamePlaceHolderLabel.Text = "______________________";
            motherNamePlaceHolderLabel.Text = "_____________________________________________";
            genderPlaceHolderLabel.Text = "______________________";
            dateOfBirthPlaceHolderLabel.Text = "______________________";
            mobileNumberPlaceHolderLabel.Text = "______________________";
            emailIdPlaceHolderLabel.Text = "______________________";
            semesterPlaceHolderLabel.Text = "______________________";
            programmingLanguagePlaceHolderLabel.Text = "______________________";
            durationPlaceHolderLabel.Text = "______________________";
            addressPlaceHolderLabel.Text = "______________________________________________________________________";
        }
    }
}
