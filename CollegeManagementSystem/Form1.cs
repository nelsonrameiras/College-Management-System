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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip.Visible = false;
            heyLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = $"SELECT [password], [fullName] FROM [dbo].[UsersLogin] WHERE [username] = '{usernameTextBox.Text}'";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            if (username == $"{usernameTextBox.Text}" &&  password == $"{dataset.Tables[0].Rows[0][0].ToString()}")
            {
                menuStrip.Visible = true;
                loginPanel.Visible = false;
                heyLabel.Visible = true;
                heyLabel.Text = $"Hey, {dataset.Tables[0].Rows[0][1].ToString()}.";
            }
            else
            {
                MessageBox.Show("Either the password you entered is not valid, or that User is not registered in our database. Please, retry.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewAdmission formNewAdmission = new FormNewAdmission();
            formNewAdmission.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpgradeSemester formUpgradeSemester = new FormUpgradeSemester();
            formUpgradeSemester.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFees formFees = new FormFees();
            formFees.Show();
        }

        private void searchPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchStudent formSearchStudent = new FormSearchStudent();
            formSearchStudent.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch1StudentDetails formSearch1StudentDetails = new FormSearch1StudentDetails();
            formSearch1StudentDetails.Show();
        }

        private void addProfessorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewTeacher formNewTeacher = new FormNewTeacher();
            formNewTeacher.Show();
        }

        private void teachersIndividualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch1TeacherDetails formSearch1TeacherDetails = new FormSearch1TeacherDetails();
            formSearch1TeacherDetails.Show();
        }

        private void disenrollPupilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisenrollStudent formDisenrollStudent = new FormDisenrollStudent();
            formDisenrollStudent.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this Software? Any unsaved data shall be lost.",
                "Are you certain?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void exitSoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to close this Software? Any unsaved data shall be lost.",
                "Are you certain?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }

        private void searchProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchTeacher formSearchTeacher = new FormSearchTeacher();
            formSearchTeacher.Show();
        }
    }
}
