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
    public partial class StaffForm : Form
    {

        public static BindingList<Customers> customerList =  new BindingList<Customers>();
        public StaffForm()
        {
            InitializeComponent();
        }


        //opens staff panel in staff screen
        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffPanel staffpannel = new StaffPanel();
            staffpannel.TopLevel = false;
            staffPnlContent.Controls.Add(staffpannel);
            staffpannel.BringToFront();
            staffpannel.Show();
        }
        //opens cutomer panel in staff screen
        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerPanel customerpannel = new CustomerPanel();
            customerpannel.TopLevel = false;
            staffPnlContent.Controls.Add(customerpannel);
            customerpannel.BringToFront();
            customerpannel.Show();
        }
        //loggin out user
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are your sure you want to logout?",
                            "Logout Information",
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
    

