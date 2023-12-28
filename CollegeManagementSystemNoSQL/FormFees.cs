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
    public partial class FormFees : Form
    {
        public FormFees()
        {
            InitializeComponent();
        }

        //// Does not fully Work without SQL

        private void registrationNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
            if(registrationNumberTextBox.Text != "")
            { 

                // SQL CODE with checks
                // warningLabel functionality does not work without SQL. Spin up SQL version to see it.

            }
            else
            {
                warningLabel.Visible = false;
                registrationNumberTextBox.Text = "";
                fullNamePlaceHolderLabel.Text = "_________________________________";
                motherNamePlaceHolderLabel.Text = "_________________________________";
                durationPlaceHolderLabel.Text = "_________________________________";
                feesTextBox.Text = "";
            }
        }

        private void submitFeesButton_Click(object sender, EventArgs e)
        {

            // SQL CODE

            if (feesTextBox.Text != "") // different check from SQL Version
            {
                // SQL CODE 2

                if (MessageBox.Show("The fee submition was successful.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    registrationNumberTextBox.Text = "";
                    fullNamePlaceHolderLabel.Text = "_________________________________";
                    motherNamePlaceHolderLabel.Text = "_________________________________";
                    durationPlaceHolderLabel.Text = "_________________________________";
                    feesTextBox.Text = "";
                }

            }
            else
            {
                MessageBox.Show("This pupil's fees have already been submitted.","Already Submitted.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
