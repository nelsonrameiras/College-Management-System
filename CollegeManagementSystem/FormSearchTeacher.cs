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
    public partial class FormSearchTeacher : Form
    {
        public FormSearchTeacher()
        {
            InitializeComponent();
        }

        private void FormSearchTeacher_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT * From Teachers";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            teachersDataGridView.DataSource = dataset.Tables[0];
            teachersDataGridView.ReadOnly = true;

            cnn.Close();
        }

        private void searchTeachersButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            if (registrationNumberTextBox.Text == "")
            {
                MessageBox.Show("Please, enter a Registration Number. Otherwise, that specific query cannot procede.", "Unsuccessful.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormSearchTeacher_Load(sender, e);
                teachersDataGridView.ReadOnly = true;
            }
            else if (registrationNumberTextBox.Text.Length != 0)
            {
                cmd.CommandText = $"SELECT * FROM Teachers WHERE tid = {registrationNumberTextBox.Text}";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                teachersDataGridView.DataSource = dataset.Tables[0];
            }

            teachersDataGridView.ReadOnly = true;
        }
    }
}
