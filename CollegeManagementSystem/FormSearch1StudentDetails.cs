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

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            if(registrationIdTextBox.Text != "")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"SELECT * FROM NewAdmission where NAID = {registrationIdTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count != 0 && registrationIdTextBox.Text.Length != 0)
                {
                    fullNamePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][1].ToString();
                    motherNamePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][2].ToString();
                    genderPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][3].ToString();
                    dateOfBirthPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][4].ToString();
                    mobileNumberPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][5].ToString();
                    emailIdPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][6].ToString();
                    semesterPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][7].ToString();
                    programmingLanguagePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][8].ToString();
                    schoolNamePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][9].ToString();
                    durationPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][10].ToString();
                    addressPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][11].ToString();

                }
                else
                {
                    MessageBox.Show("That Pupil Registration ID is invalid. Please, enter a valid NAID.",
                        "Invalid Registration ID",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resetButton_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("No Pupil Registration ID has been entered. Please, enter a valid NAID.",
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
