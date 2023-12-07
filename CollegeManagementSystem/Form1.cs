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
    }
}
