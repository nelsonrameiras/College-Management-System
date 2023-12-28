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
    public partial class FormFees : Form
    {
        public FormFees()
        {
            InitializeComponent();
        }

        private void registrationNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if(registrationNumberTextBox.Text != "")
            { 
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"SELECT fullname,mothername,duration FROM NewAdmission where NAID = {registrationNumberTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count != 0 ) 
                {
                    warningLabel.Visible = false;
                    fullNamePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][0].ToString();
                    motherNamePlaceHolderLabel.Text = dataset.Tables[0].Rows[0][1].ToString();
                    durationPlaceHolderLabel.Text = dataset.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    warningLabel.Visible = true;
                    fullNamePlaceHolderLabel.Text = "_________________________________";
                    motherNamePlaceHolderLabel.Text = "_________________________________";
                    durationPlaceHolderLabel.Text = "_________________________________";
                }

                cnn.Close();
            }
            else
            {
                warningLabel.Visible = false;
                registrationNumberTextBox.Text = "";
                fullNamePlaceHolderLabel.Text = "_________________________________";
                motherNamePlaceHolderLabel.Text = "_________________________________";
                durationPlaceHolderLabel.Text = "_________________________________";
                feesTextBox.Text = "";
            }
        }

        private void submitFeesButton_Click(object sender, EventArgs e)
        {

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = $"SELECT * FROM Fees WHERE NAID = "+registrationNumberTextBox.Text+"";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                SqlConnection cnn2 = new SqlConnection();
                cnn2.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = cnn2;

                cmd2.CommandText = $"INSERT INTO Fees (NAID, fees) VALUES ({registrationNumberTextBox.Text}," +
                    $"{feesTextBox.Text})";

                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataSet dataset2 = new DataSet();
                adapter2.Fill(dataset2);

                if (MessageBox.Show("The fee submition was successful.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    registrationNumberTextBox.Text = "";
                    fullNamePlaceHolderLabel.Text = "_________________________________";
                    motherNamePlaceHolderLabel.Text = "_________________________________";
                    durationPlaceHolderLabel.Text = "_________________________________";
                    feesTextBox.Text = "";
                }

                cnn2.Close();
            }
            else
            {
                MessageBox.Show("This pupil's fees have already been submitted.","Already Submitted.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            cnn.Close();
            
        }
    }
}
