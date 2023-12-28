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
    public partial class FormSearchStudent : Form
    {
        public FormSearchStudent()
        {
            InitializeComponent();
        }

        private void FormSearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT * From NewAdmission";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            studentsDataGridView.DataSource = dataset.Tables[0];
            studentsDataGridView.ReadOnly = true;

            cnn.Close();
        }

        private void searchStudentsButton_Click(object sender, EventArgs e)
        {
            bool allIsChecked = searchAllRadioButton.Checked;
            bool wFeesIsChecked = searchOnlyWithFeesRadioButton.Checked;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if (registrationNumberTextBox.Text == "" && (!allIsChecked && !wFeesIsChecked))
            {
                MessageBox.Show("Please Enter a Registration Number or select an option. Otherwise, that specific query cannot procede.", "Unsuccessful.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormSearchStudent_Load(sender, e);
                studentsDataGridView.ReadOnly = true;
            }
            else if (((allIsChecked || (!allIsChecked && !wFeesIsChecked)) && registrationNumberTextBox.Text != ""))
            {
                cmd.CommandText = $"SELECT * From NewAdmission WHERE NAID = {registrationNumberTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                studentsDataGridView.DataSource = dataset.Tables[0];
            }
            else if (((allIsChecked || (!allIsChecked && !wFeesIsChecked)) && registrationNumberTextBox.Text == ""))
            {
                cmd.CommandText = "SELECT * From NewAdmission";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                studentsDataGridView.DataSource = dataset.Tables[0];
            }
            else if (((wFeesIsChecked) && registrationNumberTextBox.Text != ""))
            {
                cmd.CommandText = $"SELECT * From NewAdmission WHERE NAID = {registrationNumberTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                studentsDataGridView.DataSource = dataset.Tables[0];
            }
            else if (((wFeesIsChecked) && registrationNumberTextBox.Text == ""))
            {
                cmd.CommandText = $"SELECT NewAdmission.NAID, NewAdmission.fullName, NewAdmission.motherName," +
                               $"NewAdmission.gender, NewAdmission.dateOfBirth, NewAdmission.mobileNumber, NewAdmission.email," +
                               $"NewAdmission.semester, NewAdmission.programmingLanguage, NewAdmission.schoolName," +
                               $"NewAdmission.duration, NewAdmission.addresss, Fees.fees FROM NewAdmission INNER JOIN Fees " +
                               $"ON NewAdmission.NAID = Fees.NAID";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                studentsDataGridView.DataSource = dataset.Tables[0];
            }
                
            studentsDataGridView.ReadOnly = true;

            }
    }
}