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
using System.Windows;

namespace CollegeManagementSystem
{
    public partial class FormUpgradeSemester : Form
    {
        public FormUpgradeSemester()
        {
            InitializeComponent();
        }

        private void FormUpgradeSemester_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            cmd.CommandText = "SELECT NAID, fullName FROM NewAdmission";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            studentListComboBox.DataSource = dataset.Tables[0];
            studentListComboBox.DisplayMember = "fullName";

            studentListComboBox.SelectedIndex = -1;
            fromSemesterUpgradeComboBox.SelectedIndex = -1;
            fromSemesterUpgradeComboBox.Text = "-- Choose an Option --";
            toSemesterUpgradeComboBox.SelectedIndex = -1;
            toSemesterUpgradeComboBox.Text = "-- Choose an Option --";
            specificStudentRadioButton.Checked = false;

            cnn.Close();
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {

            if(specificStudentRadioButton.Checked == true)
            {
                if (MessageBox.Show("Are you sure you want to upgrade the Semester?", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = "UPDATE NewAdmission SET semester = '" + toSemesterUpgradeComboBox.Text + "'" +
                        " where semester = '" + fromSemesterUpgradeComboBox.Text + "' AND fullName = '" + studentListComboBox.GetItemText(this.studentListComboBox.SelectedItem) + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);

                    cnn.Close();

                    MessageBox.Show("Upgrade Successful.", "Sucess.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Upgrade Canceled.", "Canceled.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to upgrade the Semester?", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection cnn = new SqlConnection();
                    cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = "UPDATE NewAdmission SET semester = '" + toSemesterUpgradeComboBox.Text + "'" +
                        " where semester = '" + fromSemesterUpgradeComboBox.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);

                    cnn.Close();

                    MessageBox.Show("Upgrade Successful.", "Sucess.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Upgrade Canceled.", "Canceled.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            FormUpgradeSemester_Load(sender, e);
        }

        private void studentListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            specificStudentRadioButton.Checked = true;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;

            string selectedStudent = studentListComboBox.GetItemText(this.studentListComboBox.SelectedItem);

            cmd.CommandText = $"SELECT semester FROM NewAdmission WHERE fullName = '{selectedStudent}'";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);


            if (dataset.Tables[0].Rows.Count != 0 && studentListComboBox.SelectedIndex != -1)
            {
                fromSemesterUpgradeComboBox.Text = dataset.Tables[0].Rows[0][0].ToString();
            }

            cnn.Close();
        }
    }
}
