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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminPnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //opens staff panel in admin screen
        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffPanel staffpannel = new StaffPanel();
            staffpannel.TopLevel = false;
            adminPnlContent.Controls.Add(staffpannel);
            staffpannel.BringToFront();
            staffpannel.Show();
        }
        //opens admin panel in admin screen
        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminPanel adminpannel = new AdminPanel();
            adminpannel.TopLevel = false;
            adminPnlContent.Controls.Add(adminpannel);
            adminpannel.BringToFront();
            adminpannel.Show();
        }
        //for logging out user to login screen
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are your sure you want to logout?",
                            "Logout",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    LoginForm loginform = new LoginForm();
                    loginform.Show();
                    this.Hide();
                    break;

                case DialogResult.No:
                    break;


            }
        }
    }
}
