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
    public partial class CustomerPanel : Form
    {
        
        public CustomerPanel()
        {
            InitializeComponent();
            this.categoryComboBox.SelectedIndex = 0;
        }

        
        //button to display csv file using open file dialog
        private void viewBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            viewBox.Text = openFileDialog1.FileName;
            BindData(viewBox.Text);
        }
        //method to display csv file
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
        //clear fields
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameBox.ResetText();
            addressBox.ResetText();
            entryTimeBox.ResetText();
            exitTimeBox.ResetText();
            totalPriceBox.ResetText();
            categoryComboBox.ResetText();
        }
        //calculate the total price using total time and rate
        private void rateBox_TextChanged(object sender, EventArgs e)
        {
            int totalTime, rate, total;

            totalTime = int.Parse(totalTimeBox.Text);
            rate = int.Parse(rateBox.Text);
            total = rate * totalTime;


            totalPriceBox.Text = total.ToString();

            
            
        }

        

        private void totalPriceBox_TextChanged(object sender, EventArgs e)
        {

        }
        //only allow numeric value
        private void totalTimeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Time must be in Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //only allow numeric value
        private void rateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Rate must be in Numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       //add customer
        private void additionBtn_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String address = addressBox.Text;
            String category = categoryComboBox.Text;
            String entryTime = entryTimeBox.Text;
            String exitTime = exitTimeBox.Text;
            String date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            String day = dateTimePicker.Value.DayOfWeek.ToString();


            if (nameBox.Text.Trim() == "" || addressBox.Text.Trim() == "" || categoryComboBox.Text.Trim() == "" || entryTimeBox.Text.Trim() == "" || exitTimeBox.Text.Trim() == "" || totalTimeBox.Text.Trim() == "" || rateBox.Text.Trim() == "" || totalPriceBox.Text.Trim() == "")
            {
                
                MessageBox.Show("Please enter all details", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string FileName = @"F:\ALL\YEAR 3\SEM 1\Application Development\CW\19031659 Gaurab Shrestha\Recreation Center\CustomerData\cd.csv";

                if (!File.Exists(FileName))
                {
                    string HeaderText = "CustomerName" + ", " + "Address" + ", " + "Category" +
                        ", " + "Date" + ", " + "Day" + ", " + "EntryTime" + ", " + "ExitTime" + ", " + "TotalTime" + ", " + "Rate" + ", " + "TotalPrice" + Environment.NewLine;
                    File.WriteAllText(FileName, HeaderText);
                }
                string customerDetails = name + ", " + address + ", " + "" + category +
                                ", " + date +", "+day +  ", "+ entryTime + ", " + exitTime + ", " + totalTimeBox.Text + ", " + rateBox.Text + ", " + totalPriceBox.Text + "\n";
                File.AppendAllText(FileName, customerDetails);
                MessageBox.Show("Customer Data Successfully Inserted", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearBtn_Click(new object(), new EventArgs());
            }
        }
    }
}
