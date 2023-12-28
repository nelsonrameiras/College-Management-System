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
            // SQL CODE
            
            deleteStudentRecordDataGridView.ReadOnly = true;

        }

        private void deleteStudentRecordButton_Click(object sender, EventArgs e)
        {
            // SQL CODE

            if (/*dataset2.Tables[0].Rows.Count != 0*/ registrationIdTextBox.Text != "") //different from SQL Version
            {
                if (MessageBox.Show("Are you sure you want to Disenroll this Student?", "Sure?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // SQL CODE 2

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
