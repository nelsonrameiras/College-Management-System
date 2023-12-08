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

            cmd.CommandText = "SELECT NewAdmission.NAID AS Student_ID, NewAdmission.fullName AS Full_Name, NewAdmission.motherName AS Mother_Name, NewAdmission.gender as Gender, " +
                "NewAdmission.dateOfBirth AS Date_Of_Birth, NewAdmission.mobileNumber AS Mobile, NewAdmission.email AS Email_ID, NewAdmission.semester AS Semester, " +
                "NewAdmission.programmingLanguage AS Programming_Language, NewAdmission.schoolName AS School_Name, NewAdmission.duration AS Duration, NewAdmission.addresss AS Address, Fees.fees AS Fees " +
                "from NewAdmission INNER JOIN Fees ON NewAdmission.NAID=Fees.NAID";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            studentsDataGridView.DataSource = dataset.Tables[0];

            cnn.Close();
        }

        private void searchStudentsButton_Click(object sender, EventArgs e)
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
        }
    }
}
