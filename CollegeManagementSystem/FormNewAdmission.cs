using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Xml.Linq;

namespace CollegeManagementSystem
{
    public partial class FormNewAdmission : Form
    {
        public FormNewAdmission()
        {
            InitializeComponent();
        }

        private void FormNewAdmission_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT MAX(NAID) FROM NewAdmission";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            Int64 registrationNumber = Convert.ToInt64(dataset.Tables[0].Rows[0][0]);
            registrationNumberLabelPlaceholder.Text = (registrationNumber + 1).ToString();

            cnn.Close();
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
            long mobileNumber = long.Parse(mobileNumberTextBox.Text);
            string emailId = emailIdTextBox.Text;
            string semester = semesterComboBox.Text;
            string programmingLanguage = programmingComboBox.Text;
            string schoolName = schoolNameTextBox.Text;
            string duration = durationYearComboBox.Text;
            string address = addressRichTextBox.Text;

            if (name == "" || mname == "" || (maleGenderRadioButton.Checked == false &&
               femaleGenderRadioButton.Checked == false) || dateOfBirthDateTimePicker.Checked == false ||
               emailId == "" || semesterComboBox.SelectedIndex == -1 || programmingComboBox.SelectedIndex == -1 ||
               durationYearComboBox.SelectedIndex == -1 || address == "")
            {
                MessageBox.Show("At least one of the fields must not have been entered properly or at all. Please, correct that and try again!",
                    "Unsuccessful. Try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "INSERT INTO NewAdmission (fullName,motherName,gender,dateOfBirth,mobileNumber," +
                "email,semester,programmingLanguage,schoolName,duration,addresss) values " +
                "('" + name + "','" + mname + "','" + gender + "','" + dateOfBirth + "','" + mobileNumber + "','" + emailId + "'," +
                "'" + semester + "','" + programmingLanguage + "','" + schoolName + "','" + duration + "','" + address + "')";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            cnn.Close();

            MessageBox.Show("The Admission has been submitted. Please, remember the Registration ID.",
                "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            schoolNameTextBox.Clear();
            durationYearComboBox.Text = "-- Choose an Option --";
            addressRichTextBox.Clear();
        }
    }
}
