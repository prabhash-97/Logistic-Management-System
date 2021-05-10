using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ceylon_petroleum
{
    public partial class Profit : Form
    {
        public Profit()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtMthSrch.Text.Trim() != string.Empty)
            {
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "Select max(m.income) as Income,m.Year,i.Insu_Cost from monthlytrans m,inventory i where i.Month=@Month and m.Month=@Month ";
                cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);

                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtRecords = new DataTable();
                dtRecords.Load(sdr);

                dataGridView1.DataSource = dtRecords;
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter Month to search");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIncome.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtYear.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtInsuranceCost.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a;
            bool isAValid = float.TryParse(txtIncome.Text, out a);
            txtNetIncome.Text = ((a)-(a * 0.11)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a, b;

            bool isAValid = float.TryParse(txtNetIncome.Text, out a);
            bool isBValid = float.TryParse(txtInsuranceCost.Text, out b);

            if (isAValid && isBValid)
                txtNetProfit.Text = (a-b).ToString();
            else
                MessageBox.Show("invalid Input");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float income = float.Parse(txtIncome.Text);
            float insurancecost = float.Parse(txtYear.Text);
            float profit = float.Parse(txtNetProfit.Text);
            float netincome = float.Parse(txtNetIncome.Text);
            string month = txtMthSrch.Text;
            string year = txtInsuranceCost.Text;


            dataGridView2.Rows.Add(txtInsuranceCost.Text, txtMthSrch.Text,txtIncome.Text,txtYear.Text,txtNetIncome.Text,txtNetProfit.Text);
            MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=;");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into profit(Year,Month,Income,Insu_Cost,Net_Income,Profit)values('" + year + "','" + month + "','" + income+ "','" + insurancecost + "','" + netincome + "','" +profit + "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();

            MessageBox.Show("Data Stored Successfully");
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profit_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
