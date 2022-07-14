
namespace Recreation_Center
{
    partial class CustomerPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalPriceBox = new System.Windows.Forms.TextBox();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.totalTimeBox = new System.Windows.Forms.TextBox();
            this.exitTimeBox = new System.Windows.Forms.TextBox();
            this.entryTimeBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBox = new System.Windows.Forms.TextBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.additionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(200, 22);
            this.nameBox.TabIndex = 3;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(121, 69);
            this.addressBox.Multiline = true;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(200, 38);
            this.addressBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Entry Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Exit Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Rate:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Total Price:";
            // 
            // totalPriceBox
            // 
            this.totalPriceBox.Location = new System.Drawing.Point(121, 410);
            this.totalPriceBox.Name = "totalPriceBox";
            this.totalPriceBox.ReadOnly = true;
            this.totalPriceBox.Size = new System.Drawing.Size(200, 22);
            this.totalPriceBox.TabIndex = 11;
            this.totalPriceBox.TextChanged += new System.EventHandler(this.totalPriceBox_TextChanged);
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(121, 361);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(200, 22);
            this.rateBox.TabIndex = 12;
            this.rateBox.TextChanged += new System.EventHandler(this.rateBox_TextChanged);
            this.rateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateBox_KeyPress);
            // 
            // totalTimeBox
            // 
            this.totalTimeBox.Location = new System.Drawing.Point(121, 312);
            this.totalTimeBox.Name = "totalTimeBox";
            this.totalTimeBox.Size = new System.Drawing.Size(200, 22);
            this.totalTimeBox.TabIndex = 13;
            this.totalTimeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.totalTimeBox_KeyPress);
            // 
            // exitTimeBox
            // 
            this.exitTimeBox.Location = new System.Drawing.Point(121, 266);
            this.exitTimeBox.Name = "exitTimeBox";
            this.exitTimeBox.Size = new System.Drawing.Size(200, 22);
            this.exitTimeBox.TabIndex = 14;
            // 
            // entryTimeBox
            // 
            this.entryTimeBox.Location = new System.Drawing.Point(121, 214);
            this.entryTimeBox.Name = "entryTimeBox";
            this.entryTimeBox.Size = new System.Drawing.Size(200, 22);
            this.entryTimeBox.TabIndex = 15;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Child",
            "Adult",
            "Group of 5",
            "Group of 10",
            "Group of 15",
            "Group of 20"});
            this.categoryComboBox.Location = new System.Drawing.Point(121, 126);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(200, 24);
            this.categoryComboBox.TabIndex = 17;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(204, 476);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(83, 30);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 410);
            this.dataGridView1.TabIndex = 20;
            // 
            // viewBox
            // 
            this.viewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBox.Location = new System.Drawing.Point(447, 478);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(660, 28);
            this.viewBox.TabIndex = 21;
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(346, 476);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(83, 30);
            this.viewBtn.TabIndex = 22;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(121, 173);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 23;
            // 
            // additionBtn
            // 
            this.additionBtn.Location = new System.Drawing.Point(34, 476);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(83, 30);
            this.additionBtn.TabIndex = 26;
            this.additionBtn.Text = "Add";
            this.additionBtn.UseVisualStyleBackColor = true;
            this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
            // 
            // CustomerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 573);
            this.ControlBox = false;
            this.Controls.Add(this.additionBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.entryTimeBox);
            this.Controls.Add(this.exitTimeBox);
            this.Controls.Add(this.totalTimeBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.totalPriceBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomerPanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalPriceBox;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.TextBox totalTimeBox;
        private System.Windows.Forms.TextBox exitTimeBox;
        private System.Windows.Forms.TextBox entryTimeBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox viewBox;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button additionBtn;
    }
}