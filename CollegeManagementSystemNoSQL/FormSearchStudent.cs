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

        //// Does Not Fully Work without SQL

        private void FormSearchStudent_Load(object sender, EventArgs e)
        {
            // SQL CODE
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
                // SQL CODE

                studentsDataGridView.ReadOnly = true;
            }
        }
    }
}
