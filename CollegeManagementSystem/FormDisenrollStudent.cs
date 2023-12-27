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

            cnn.Close();
        }

        private void deleteStudentRecordButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Disenroll this Student?","Sure?",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"DELETE FROM NewAdmission WHERE NAID = '{registrationIdTextBox.Text}'";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                MessageBox.Show($"The student with Registration Id {registrationIdTextBox.Text} has successfully been disenrolled.",
                    "Successfully Disenrolled.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormDisenrollStudent_Load(sender, e);
            }
            else {
                FormDisenrollStudent_Load(sender, e);
            }
        }
    }
}
