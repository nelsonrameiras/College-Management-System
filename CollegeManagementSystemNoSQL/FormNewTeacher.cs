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
    public partial class FormNewTeacher : Form
    {
        public FormNewTeacher()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string name = fullNameTextBox.Text;
            string mname = motherNameTextBox.Text;
            string gender = "";
            bool isChecked = maleGenderRadioButton.Checked;
            if (isChecked)
            {
                gender = maleGenderRadioButton.Text;
            }
            else
            {
                gender = femaleGenderRadioButton.Text;
            }
            string dateOfBirth = dateOfBirthDateTimePicker.Text;
            long mobileNumber = Convert.ToInt64(mobileNumberTextBox.Text);
            string emailId = emailIdTextBox.Text;
            string semester = semesterComboBox.Text;
            string programmingLanguage = programmingComboBox.Text;
            string duration = durationYearComboBox.Text;
            string address = addressRichTextBox.Text;

            if(name == "" || mname == "" || (maleGenderRadioButton.Checked == false && 
               femaleGenderRadioButton.Checked == false) || dateOfBirthDateTimePicker.Checked == false ||
               emailId == "" || semesterComboBox.SelectedIndex == -1 || programmingComboBox.SelectedIndex == -1 || 
               durationYearComboBox.SelectedIndex == -1 || address == "") 
            {
                MessageBox.Show("At least one of the fields must not have been entered properly or at all. Please, correct that and try again!",
                    "Unsuccessful. Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SQL CODE

                MessageBox.Show("This Teacher's Information has been successfully saved.",
                    "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                resetButton_Click(sender, e);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            fullNameTextBox.Clear();
            motherNameTextBox.Clear();
            maleGenderRadioButton.Checked = false;
            femaleGenderRadioButton.Checked = false;
            mobileNumberTextBox.Clear();
            emailIdTextBox.Clear();
            semesterComboBox.Text = "-- Choose an Option --";
            programmingComboBox.Text = "-- Choose an Option --";
            durationYearComboBox.Text = "-- Choose an Option --";
            addressRichTextBox.Clear();
        }
    }
}
