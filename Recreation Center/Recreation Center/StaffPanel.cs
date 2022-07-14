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
    public partial class StaffPanel : Form
    {
        public StaffPanel()
        {
            InitializeComponent();
        }
          
        private void dailyReportBtn_Click(object sender, EventArgs e)
        {
            ReportDisplay(dailyReport());
        }
        //Method to read csv file and storing it in the list with the help of various variables
        private List<Customers> ReadFileDemo()
        {
            try
            {
                var lines = File.ReadAllLines(@"F:\ALL\YEAR 3\SEM 1\Application Development\CW\19031659 Gaurab Shrestha\Recreation Center\CustomerData\cd.csv");

                var list = new List<Customers>();

                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    var customerDetails = new Customers()
                    {
                        Category = data[2],
                        Date = data[3],
                        Day = data[4],
                        TotalPrice = data[9]
                    };
                    list.Add(customerDetails);
                }
                return list;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No File Avialable", "File not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return new List<Customers>();
        }

        private string[] dailyReport()
        {
            // this method gets data from csv file
            CustomerFile(@"F:\ALL\YEAR 3\SEM 1\Application Development\CW\19031659 Gaurab Shrestha\Recreation Center\CustomerData");
            int[] totalNumPeople = CustomerFile(@"F:\ALL\YEAR 3\SEM 1\Application Development\CW\19031659 Gaurab Shrestha\Recreation Center\CustomerData");

            //this array is created to store daily report data before displaying in the grid view
            string[] dailyReportTableView = new string[7];
            dailyReportTableView[0] = "Category,Total Visitors";
            dailyReportTableView[1] = "Child (5-12)" + "," + totalNumPeople[0].ToString();
            dailyReportTableView[2] = "Adult > 12" + "," + totalNumPeople[1].ToString();
            dailyReportTableView[3] = "Group of 5" + "," + totalNumPeople[2].ToString();
            dailyReportTableView[4] = "Group of 10" + "," + totalNumPeople[3].ToString();
            dailyReportTableView[5] = "Group of 15" + "," + totalNumPeople[4].ToString();
            dailyReportTableView[6] = "Group of 20" + "," + totalNumPeople[5].ToString();

            return dailyReportTableView;
        }
        //after reading customer details csv file and storing in the class CustomerFile
        private int[] CustomerFile(string fileName)
        {
            String todayDate = DateTime.Now.ToString("yyyy-MM-dd");
            int totalChildNum = 0;
            int totalAdultNum = 0;
            int totalGroupOf5Num = 0;
            int totalGroupOf10Num = 0;
            int totalGroupOf15Num = 0;
            int totalGroupOf20Num = 0;

            
            List<Customers> list = ReadFileDemo();
            try
            {
                list.ForEach(a =>
                {

                    if (a.Date.Trim() == todayDate)
                    {
                        if (a.Category.Trim() == "Child")
                        {
                            totalChildNum ++;
                        }
                        else if (a.Category.Trim() == "Adult")
                        {
                            totalAdultNum++;
                        }
                        else if (a.Category.Trim() == "Group of 5")
                        {
                            totalGroupOf5Num++;
                        }
                        else if (a.Category.Trim() == "Group of 10")
                        {
                            totalGroupOf10Num++;
                        }
                        else if (a.Category.Trim() == "Group of 15")
                        {
                            totalGroupOf15Num++;
                        }
                        else if (a.Category.Trim() == "Group of 20")
                        {
                            totalGroupOf20Num++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                );
            }
            catch (FormatException)
            {
            }
            int[] totalNumberPeopleArray = new int[6] { totalChildNum, totalAdultNum, totalGroupOf5Num, totalGroupOf10Num, totalGroupOf15Num, totalGroupOf20Num };
            return totalNumberPeopleArray;
        }
        //displaying weekly report in grid view
        private void weeklyReportBtn_Click(object sender, EventArgs e)
        {
            //this loop is for clearing the chart for next display
            foreach (var series in weeklyChart.Series)
            {
                series.Points.Clear();
            }

            ReportDisplay(weeklyReport());

            weeklyReportData();
            int[] totalEarningANDVisit = weeklyReportData();
            int sundayEarning = totalEarningANDVisit[0];
            int sundayVisit = totalEarningANDVisit[1];
            int mondayEarning = totalEarningANDVisit[2];
            int mondayVisit = totalEarningANDVisit[3];
            int tueEarning = totalEarningANDVisit[4];
            int tuesdayVisit = totalEarningANDVisit[5];
            int wednesdayEarning = totalEarningANDVisit[6];
            int wednesdayVisit = totalEarningANDVisit[7];
            int thursdayEarning = totalEarningANDVisit[8];
            int thursdayVisit = totalEarningANDVisit[9];
            int fridayEarning = totalEarningANDVisit[10];
            int fridayVisit = totalEarningANDVisit[11];
            int saturdayEarning = totalEarningANDVisit[12];
            int saturdayVisit = totalEarningANDVisit[13];

            //method that displya bar graph in chart
            weeklyBarChart(sundayEarning, sundayVisit, mondayEarning, mondayVisit, tueEarning, tuesdayVisit, wednesdayEarning, wednesdayVisit, thursdayEarning, thursdayVisit, fridayEarning, fridayVisit, saturdayEarning, saturdayVisit);
        }
        //method to display weekly report
        private string[] weeklyReport()
        {
            int[] totalNumEarningVisit = weeklyReportData();

            string[] weeklyReportTableView = new string[8];
            weeklyReportTableView[0] = "Day,Total Earnings,Total Visitors";
            weeklyReportTableView[1] = "Sunday" + "," + totalNumEarningVisit[0] + "," + totalNumEarningVisit[1];
            weeklyReportTableView[2] = "Monday" + "," + totalNumEarningVisit[2] + "," + totalNumEarningVisit[3];
            weeklyReportTableView[3] = "Tuesday" + "," + totalNumEarningVisit[4] + "," + totalNumEarningVisit[5];
            weeklyReportTableView[4] = "Wednesday" + "," + totalNumEarningVisit[6] + "," + totalNumEarningVisit[7];
            weeklyReportTableView[5] = "Thursday" + "," + totalNumEarningVisit[8] + "," + totalNumEarningVisit[9];
            weeklyReportTableView[6] = "Friday" + "," + totalNumEarningVisit[10] + "," + totalNumEarningVisit[11];
            weeklyReportTableView[7] = "Saturday" + "," + totalNumEarningVisit[12] + "," + totalNumEarningVisit[13];

            return weeklyReportTableView;
        }        

        //method that gets all the date of current week
        private string[] weeklyDate()
        {
            var today = DateTime.Now.Date; 
            int day = (int)today.DayOfWeek; 

            int totalDaysOfWeekPassed = day + 1;   

            //arrayDate store all data of a week in array
            string[] arrayDate = new string[totalDaysOfWeekPassed];
            int index = 0;

            for (var i = -day; i < -day + totalDaysOfWeekPassed; i++)
            {
                arrayDate[index] = today.AddDays(i).Date.ToString("yyyy-MM-dd");
                index++;
            }
            return arrayDate;
        }
        //method that returns total earning and visitors for weekly report
        private int[] weeklyReportData()
        {
            int sundayEarning = 0;
            int sundayVisitor = 0;
            int mondayEarning = 0;
            int mondayVisitor = 0;
            int tuesdayEarning = 0;
            int tuesdayVisitor = 0;
            int wednesdayEarning = 0;
            int wednesdayVisitor = 0;
            int thursdayEarning = 0;
            int thursdayVisitor = 0;
            int fridayEarning = 0;
            int fridayVisitor = 0;
            int saturdayEarning = 0;
            int saturdayVisitor = 0;

            string[] weekDates = weeklyDate();

            List<Customers> data = ReadFileDemo();
            data.ForEach(x =>
            {
                for (int i = 0; i < weekDates.Length; i++)
                {
                    if (x.Date.Trim().ToLower() == weekDates[i].ToLower())
                    {

                        if (x.Day.Trim().ToLower() == "sunday")
                        {
                            sundayEarning += Int32.Parse(x.TotalPrice);
                            sundayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "monday")
                        {
                            mondayEarning += Int32.Parse(x.TotalPrice);
                            mondayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "tuesday")
                        {
                            tuesdayEarning += Int32.Parse(x.TotalPrice);
                            tuesdayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "wednesday")
                        {
                            wednesdayEarning += Int32.Parse(x.TotalPrice);
                            wednesdayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "thursday")
                        {
                            thursdayEarning += Int32.Parse(x.TotalPrice);
                            thursdayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "friday")
                        {
                            fridayEarning += Int32.Parse(x.TotalPrice);
                            fridayVisitor++;
                        }
                        else if (x.Day.Trim().ToLower() == "saturday")
                        {
                            saturdayEarning += Int32.Parse(x.TotalPrice);
                            saturdayVisitor++;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            });
            int[] totalEarningandPeople = new int[14] { sundayEarning, sundayVisitor, mondayEarning, mondayVisitor, tuesdayEarning, tuesdayVisitor, wednesdayEarning, wednesdayVisitor,
            thursdayEarning, thursdayVisitor, fridayEarning, fridayVisitor, saturdayEarning, saturdayVisitor};
            return totalEarningandPeople;
        }

        private void weeklyBarChart(int sunEarn, int sunVisit, int monEarn, int monVisit, int tueEarn, int tueVisit, int wedEarn, int wedVisit, int thuEarn, int thuVisit, int friEarn, int friVisit, int satEarn, int satVisit)
        {
            try
            {
                // Sunday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(sunVisit);
                weeklyChart.Series["Total Visitors"].Points[0].AxisLabel = "Sun";
                weeklyChart.Series["Total Visitors"].Points[0].LegendText = "Sun";
                weeklyChart.Series["Total Visitors"].Points[0].Label = sunVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(sunEarn);
                weeklyChart.Series["Total Earnings"].Points[0].Label = sunEarn.ToString();

                // Monday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(monVisit);
                weeklyChart.Series["Total Visitors"].Points[1].AxisLabel = "Mon";
                weeklyChart.Series["Total Visitors"].Points[1].LegendText = "Mon";
                weeklyChart.Series["Total Visitors"].Points[1].Label = monVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(monEarn);
                weeklyChart.Series["Total Earnings"].Points[1].Label = monEarn.ToString();

                // Tuesday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(tueVisit);
                weeklyChart.Series["Total Visitors"].Points[2].AxisLabel = "Tue";
                weeklyChart.Series["Total Visitors"].Points[2].LegendText = "Tue";
                weeklyChart.Series["Total Visitors"].Points[2].Label = tueVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(tueEarn);
                weeklyChart.Series["Total Earnings"].Points[2].Label = tueEarn.ToString();

                // Wednesday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(wedVisit);
                weeklyChart.Series["Total Visitors"].Points[3].AxisLabel = "Wed";
                weeklyChart.Series["Total Visitors"].Points[3].LegendText = "Wed";
                weeklyChart.Series["Total Visitors"].Points[3].Label = wedVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(wedEarn);
                weeklyChart.Series["Total Earnings"].Points[3].Label = wedEarn.ToString();

                // Thursday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(thuVisit);
                weeklyChart.Series["Total Visitors"].Points[4].AxisLabel = "Thu";
                weeklyChart.Series["Total Visitors"].Points[4].LegendText = "Thu";
                weeklyChart.Series["Total Visitors"].Points[4].Label = thuVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(thuEarn);
                weeklyChart.Series["Total Earnings"].Points[4].Label = thuEarn.ToString();

                // Friday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(friVisit);
                weeklyChart.Series["Total Visitors"].Points[5].AxisLabel = "Fri";
                weeklyChart.Series["Total Visitors"].Points[5].LegendText = "Fri";
                weeklyChart.Series["Total Visitors"].Points[5].Label = friVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(friEarn);
                weeklyChart.Series["Total Earnings"].Points[5].Label = friEarn.ToString();

                // Saturday bargraph
                weeklyChart.Series["Total Visitors"].Points.Add(satVisit);
                weeklyChart.Series["Total Visitors"].Points[6].AxisLabel = "Sat";
                weeklyChart.Series["Total Visitors"].Points[6].LegendText = "Sat";
                weeklyChart.Series["Total Visitors"].Points[6].Label = satVisit.ToString();
                weeklyChart.Series["Total Earnings"].Points.Add(satEarn);
                weeklyChart.Series["Total Earnings"].Points[6].Label = satEarn.ToString();
            }
            catch (ArgumentException)
            {
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //calling bubblesort method
            BubbleSort();
        }


        // this is bubble sort method
        private int[] bubbleSort(int[] arrayy)
        {
            int temp;
            for (int j = 0; j <= arrayy.Length - 2; j++)
            {
                for (int i = 0; i <= arrayy.Length - 2; i++)
                {
                    if (arrayy[i] > arrayy[i + 1])
                    {
                        temp = arrayy[i + 1];
                        arrayy[i + 1] = arrayy[i];
                        arrayy[i] = temp;
                    }
                }
            }
            return arrayy;
        }

        private void BubbleSort()
        {
            int a = 0;
            int b = 1;

            int[] totalEarningandVisit = weeklyReportData();
            List<string[]> listOfWeeklyData = new List<string[]>();

            string[] sunday = { "Sunday", totalEarningandVisit[0].ToString(), totalEarningandVisit[1].ToString() };
            string[] monday = { "Monday", totalEarningandVisit[2].ToString(), totalEarningandVisit[3].ToString() };
            string[] tuesday = { "Tuesday", totalEarningandVisit[4].ToString(), totalEarningandVisit[5].ToString() };
            string[] wednesday = { "Wednesday", totalEarningandVisit[6].ToString(), totalEarningandVisit[7].ToString() };
            string[] thursday = { "Thursday", totalEarningandVisit[8].ToString(), totalEarningandVisit[9].ToString() };
            string[] friday = { "Friday", totalEarningandVisit[10].ToString(), totalEarningandVisit[11].ToString() };
            string[] saturday = { "Saturday", totalEarningandVisit[12].ToString(), totalEarningandVisit[13].ToString() };

            listOfWeeklyData.Add(sunday);
            listOfWeeklyData.Add(monday);
            listOfWeeklyData.Add(tuesday);
            listOfWeeklyData.Add(wednesday);
            listOfWeeklyData.Add(thursday);
            listOfWeeklyData.Add(friday);
            listOfWeeklyData.Add(saturday);


            int[] arrayTotalEarning = new int[7];

            foreach (var data in listOfWeeklyData)
            {
                arrayTotalEarning[a] = Int32.Parse(data[1]);
                a++;
            }

            int[] sortArrayEarning = bubbleSort(arrayTotalEarning);

            string[] sortWeeklyTableView = new string[8];
            sortWeeklyTableView[0] = "Days,Total Earnings,Total Visitors";

            for (int j = 0; j < sortArrayEarning.Length; j++)
            {
                if (j == sortArrayEarning.Length - 1)
                {
                    foreach (var data in listOfWeeklyData)
                    {
                        if (sortArrayEarning[j] == Int32.Parse(data[1]))
                        {
                            sortWeeklyTableView[b] = data[0] + "," + data[1] + "," + data[2];
                            b++;
                        }
                    }
                }
                else if (sortArrayEarning[j] == sortArrayEarning[j + 1])
                {
                    continue;
                }
                else
                {
                    foreach (var weeklydata in listOfWeeklyData)
                    {
                        if (sortArrayEarning[j] == Int32.Parse(weeklydata[1]))
                        {

                            sortWeeklyTableView[b] = weeklydata[0] + "," + weeklydata[1] + "," + weeklydata[2];
                            b++;
                        }
                    }
                }
            }

            ReportDisplay(sortWeeklyTableView);
        }
        private void ReportDisplay(string[] reportData)
        {
            DataTable dt = new DataTable();

            
            if (reportData.Length > 0)
            {
                //first line to create header
                string firstLine = reportData[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < reportData.Length; i++)
                {
                    string[] dataWords = reportData[i].Split(',');
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
                dataGrid.DataSource = dt;
            }
        }

        
    }

    [Serializable]
    public class Customers
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public String Category { get; set; }
        public String Date { get; set; }
        public String Day { get; set; }
        public String EntryTime { get; set; }
        public String ExitTime { get; set; }
        public String TotalTime { get; set; }
        public String Rate { get; set; }
        public String TotalPrice { get; set; }



    }
}
