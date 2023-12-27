using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if(username == "admin" &&  password == "admin")
            {
                menuStrip.Visible = true;
                loginPanel.Visible = false;
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
    }
}
