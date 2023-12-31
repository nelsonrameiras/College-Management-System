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
    public partial class FormDisenrollStudent : Form
    {
        public FormDisenrollStudent()
        {
            InitializeComponent();
        }

        private void FormDisenrollStudent_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT * From NewAdmission";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            deleteStudentRecordDataGridView.DataSource = dataset.Tables[0];
            deleteStudentRecordDataGridView.ReadOnly = true;

            cnn.Close();
        }

        private void deleteStudentRecordButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn2 = new SqlConnection();
            cnn2.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = cnn2;

            cmd2.CommandText = $"SELECT * FROM NewAdmission WHERE NAID = '{registrationIdTextBox.Text}';";

            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataSet dataset2 = new DataSet();
            adapter2.Fill(dataset2);

            if (dataset2.Tables[0].Rows.Count != 0)
            {
                if (MessageBox.Show("Are you sure you want to Disenroll this Pupil?", "Are you sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $"DELETE FROM NewAdmission WHERE NAID = '{registrationIdTextBox.Text}'; " +
                        $"DELETE FROM Fees WHERE NAID = '{registrationIdTextBox.Text}';";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);

                    MessageBox.Show($"The student with Registration Id {registrationIdTextBox.Text} has successfully been disenrolled.",
                        "Successfully Disenrolled.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormDisenrollStudent_Load(sender, e);
                }
                else
                {
                    registrationIdTextBox.Clear();
                    FormDisenrollStudent_Load(sender, e);
                }
            }
            else
            { 
                MessageBox.Show("That Pupil does not exist. Please enter a valid Registration ID.", "Enter a valid NAID.",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                registrationIdTextBox.Clear();
            }

        }
    }
}
