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
    public partial class FormUpgradeSemester : Form
    {
        public FormUpgradeSemester()
        {
            InitializeComponent();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to upgrade the Semester?","Confirm?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // SQL CODE

                MessageBox.Show("Upgrade Successful.","Sucess.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Upgrade Canceled.", "Canceled.", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
