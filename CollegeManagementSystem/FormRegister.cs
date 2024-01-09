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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string fullName = fullNameTextBox.Text;

            if(username != "" && (password.Length > 8 && password.Length < 14) 
                && password.Any(char.IsUpper) && !password.Contains(" ") && fullName != "")
            {
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"INSERT INTO [dbo].[UsersLogin] VALUES ('{username}','{password}','{fullName}')";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                MessageBox.Show("User successfully registered.",
                                    "Registered.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("User not registered.\nTo meet the criteria, the password must range from 8 through 14 characters and must contain at least one upper case letter. Moreover, naturally, it mustn't contain any white spaces.\n" +
                    "Furthermore, all fields must be filled.\nPlease, check what you have missed and try again.",
                                    "Unsuccessfuly registered.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void requerimentsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To meet the criteria, the password must range from 8 through 14 characters and must contain at least one upper case letter. Moreover, naturally, it mustn't contain any white spaces.\n" +
                    "Furthermore, all fields must be filled.",
                                    "Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }
    }
}
