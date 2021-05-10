namespace ceylon_petroleum
{
    partial class View_and_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_and_Update));
            this.txtVehicleId = new System.Windows.Forms.MaskedTextBox();
            this.txtTyreNo = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeInsurance = new System.Windows.Forms.DateTimePicker();
            this.txtDriverId = new System.Windows.Forms.TextBox();
            this.txtInsurenceCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtVehicle = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMonth = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVehicleId
            // 
            this.txtVehicleId.Location = new System.Drawing.Point(152, 3);
            this.txtVehicleId.Mask = "LL/0000";
            this.txtVehicleId.Name = "txtVehicleId";
            this.txtVehicleId.Size = new System.Drawing.Size(89, 20);
            this.txtVehicleId.TabIndex = 55;
            // 
            // txtTyreNo
            // 
            this.txtTyreNo.Location = new System.Drawing.Point(151, 49);
            this.txtTyreNo.Mask = "LL/00-0000";
            this.txtTyreNo.Name = "txtTyreNo";
            this.txtTyreNo.Size = new System.Drawing.Size(89, 20);
            this.txtTyreNo.TabIndex = 46;
            // 
            // dateTimeInsurance
            // 
            this.dateTimeInsurance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInsurance.Location = new System.Drawing.Point(145, 93);
            this.dateTimeInsurance.Name = "dateTimeInsurance";
            this.dateTimeInsurance.Size = new System.Drawing.Size(95, 20);
            this.dateTimeInsurance.TabIndex = 47;
            this.dateTimeInsurance.Value = new System.DateTime(2020, 8, 13, 0, 0, 0, 0);
            // 
            // txtDriverId
            // 
            this.txtDriverId.Location = new System.Drawing.Point(145, 178);
            this.txtDriverId.Name = "txtDriverId";
            this.txtDriverId.Size = new System.Drawing.Size(229, 20);
            this.txtDriverId.TabIndex = 49;
            // 
            // txtInsurenceCost
            // 
            this.txtInsurenceCost.Location = new System.Drawing.Point(145, 131);
            this.txtInsurenceCost.Name = "txtInsurenceCost";
            this.txtInsurenceCost.Size = new System.Drawing.Size(229, 20);
            this.txtInsurenceCost.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 171);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label5.Size = new System.Drawing.Size(85, 27);
            this.label5.TabIndex = 54;
            this.label5.Text = "Driver ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "Insurence Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "Insurence Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label2.Size = new System.Drawing.Size(120, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Tyre Serial No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 50;
            this.label1.Text = "Vehicle ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.txtVehicle);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(39, 3);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(489, 104);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Enter Vehicle Id To View Data";
            // 
            // txtVehicle
            // 
            this.txtVehicle.Location = new System.Drawing.Point(186, 42);
            this.txtVehicle.Mask = "LL/0000";
            this.txtVehicle.Name = "txtVehicle";
            this.txtVehicle.Size = new System.Drawing.Size(89, 27);
            this.txtVehicle.TabIndex = 63;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(304, 38);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 31);
            this.button6.TabIndex = 5;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Vehicle ID";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Location = new System.Drawing.Point(548, 234);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 40);
            this.button7.TabIndex = 57;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button8.Location = new System.Drawing.Point(546, 179);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 38);
            this.button8.TabIndex = 58;
            this.button8.Text = "Update";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 186);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(548, 282);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 62;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 96);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Month";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txtMonth);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtVehicleId);
            this.panel1.Controls.Add(this.txtTyreNo);
            this.panel1.Controls.Add(this.dateTimeInsurance);
            this.panel1.Controls.Add(this.txtDriverId);
            this.panel1.Controls.Add(this.txtInsurenceCost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 213);
            this.panel1.TabIndex = 63;
            // 
            // txtMonth
            // 
            this.txtMonth.FormattingEnabled = true;
            this.txtMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.txtMonth.Location = new System.Drawing.Point(291, 92);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(79, 21);
            this.txtMonth.TabIndex = 56;
            // 
            // View_and_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 516);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.groupBox3);
            this.Name = "View_and_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_and_Update";
            this.Load += new System.EventHandler(this.View_and_Update_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtVehicleId;
        private System.Windows.Forms.MaskedTextBox txtTyreNo;
        private System.Windows.Forms.DateTimePicker dateTimeInsurance;
        private System.Windows.Forms.TextBox txtDriverId;
        private System.Windows.Forms.TextBox txtInsurenceCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtVehicle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtMonth;
    }
}