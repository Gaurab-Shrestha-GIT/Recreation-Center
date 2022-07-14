using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recreation_Center
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            viewBox.Text = openFileDialog1.FileName;
            BindData(viewBox.Text);
           
        }
        private void BindData(string filePath)
        {
            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void childBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void childBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //save customer details
        private void saveBtn_Click(object sender, EventArgs e)
        {

            String ticketoptions = ticketComboBox.Text;

            if (ticketComboBox.Text.Trim() == "" || oneHourBox.Text.Trim() == "" || twoHourBox.Text.Trim() == "" || threeHourBox.Text.Trim() == "" || fourHourBox.Text.Trim() == "" || wholeDayBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all details", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 

            else
            {
                string FileName = @"F:\ALL\YEAR 3\SEM 1\Application Development\CW\19031659 Gaurab Shrestha\Recreation Center\TicketData\ticketdata.csv";

                if (!File.Exists(FileName))
                {
                    string HeaderText = "Ticket Rate" + ", " + "1 Hour" + ", " + "2 Hours" +
                        ", " + "3 Hours" + ", " + "4 Hours" + ", " + "Whole Day" + Environment.NewLine;
                    File.WriteAllText(FileName, HeaderText);
                }
                string ticketdetails = ticketComboBox.Text + ", " + oneHourBox.Text + ", " + "" + twoHourBox.Text +
                                ", " + threeHourBox.Text + ", " + fourHourBox.Text + ", " + wholeDayBox.Text + "\n";
                File.AppendAllText(FileName, ticketdetails);
                MessageBox.Show("Ticket Price Data Successfully Inserted", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearBtn_Click(new object(), new EventArgs());

            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ticketComboBox.ResetText();
            oneHourBox.ResetText();
            twoHourBox.ResetText();
            threeHourBox.ResetText();
            fourHourBox.ResetText();
            wholeDayBox.ResetText();
        }

        private void oneHourBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                 MessageBox.Show("Accept Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void twoHourBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Accept Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void threeHourBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Accept Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fourHourBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Accept Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wholeDayBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Accept Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
