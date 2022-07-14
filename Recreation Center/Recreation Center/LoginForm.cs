using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //user login 
        private void loginBtn_Click(object sender, EventArgs e)
        {

            String username = usernameBox.Text;
            String password = passwordBox.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameBox.ResetText();
                passwordBox.ResetText();
            }
            //admin login
            else if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Login Successfull", "Admin Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminForm AdminForm = new AdminForm();
                AdminForm.Show();
                this.Hide();
            }
            //staff login
            else if (username == "staff" && password == "staff")
            {
                MessageBox.Show("Login Successfull", "Staff Login!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StaffForm StaffForm = new StaffForm();
                StaffForm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or Password do not match!", "Error Message");
                usernameBox.ResetText();
                passwordBox.ResetText();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
