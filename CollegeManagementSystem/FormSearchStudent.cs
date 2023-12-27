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
            if (registrationNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Enter a Registration Number. Otherwise, the query cannot procede.", "Unsuccessful.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormSearchStudent_Load(sender, e);
                studentsDataGridView.ReadOnly = true;
            }
            else
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"SELECT * FROM NewAdmission where NAID = {registrationNumberTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                studentsDataGridView.DataSource = dataset.Tables[0];
                studentsDataGridView.ReadOnly = true;
            }
        }
    }
}
