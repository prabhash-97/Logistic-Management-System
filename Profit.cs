using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
               
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();

                cmd.CommandText="  select sum(Total) as Monthly_salary_expenditure from helper_sal where YEAR(open_date) = @Year and Datename(Month, open_date)= @Month";
               /* cmd.CommandText = "Select * from Daily_trans where Month=@Month and Year(Date)=@Year";*/
                cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);
                cmd.Parameters.AddWithValue("@Year", txtYear.Text);
                SqlDataReader myread;
                myread = cmd.ExecuteReader();
                if (myread.Read())
                {
                    txtMonSalExp.Text = myread["Monthly_salary_expenditure"].ToString();
                }

                search2();
                search1();

            }
            else
            {
                MessageBox.Show("Please enter Month to search");
            }
        }

        void search1()
        {
            if (txtMthSrch.Text.Trim() != string.Empty)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " select income  from monthlytrans where Date=( select max(Date) from monthlytrans where Month=@Month and Year=@Year);";
                /* cmd.CommandText = "Select * from Daily_trans where Month=@Month and Year(Date)=@Year";*/
                cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);
                cmd.Parameters.AddWithValue("@Year", txtYear.Text);
                SqlDataReader myread;
                myread = cmd.ExecuteReader();
                if (myread.Read())
                {
                    txtIncome.Text = myread["income"].ToString();
                }

            }
            else
            {
                MessageBox.Show("Please enter Month to search");
            }
        }

        void search2()
        {
            if (txtMthSrch.Text.Trim() != string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = " select sum(Amount) as Total_Amount_Expenditure from expenditure  where Datename(Month,Date)='may' and YEAR(Date)='2021';";
                /* cmd.CommandText = "Select * from Daily_trans where Month=@Month and Year(Date)=@Year";*/
                cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);
                cmd.Parameters.AddWithValue("@Year", txtYear.Text);
                SqlDataReader myread;
                myread = cmd.ExecuteReader();
                if (myread.Read())
                {
                    txtTotalAExpe.Text = myread["Total_Amount_Expenditure"].ToString();
                }

            }
            else
            {
                MessageBox.Show("Please enter Month to search");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a;
            bool isAValid = float.TryParse(txtIncome.Text, out a);
            txtNetIncome.Text = ((a)-(a * 0.11)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float a, b, c;

            bool isAValid = float.TryParse(txtMonSalExp.Text, out a);
            bool isBValid = float.TryParse(txtNetIncome.Text, out b);
            bool isCValid = float.TryParse(txtTotalAExpe.Text, out c);

            if (isBValid)
                txtNetProfit.Text = (b-(a+c)).ToString();
            else
                MessageBox.Show("invalid Input");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float totalExpe = float.Parse(txtTotalAExpe.Text);
            float netincome = float.Parse(txtNetIncome.Text);
            float netprofit = float.Parse(txtNetProfit.Text);
            float monSalExpe = float.Parse(txtMonSalExp.Text);
            string month = txtMthSrch.Text;
            string income = txtIncome.Text;
            
            dataGridView2.Rows.Add(txtMthSrch.Text,txtYear.Text,txtIncome.Text,txtMonSalExp.Text,txtTotalAExpe.Text, txtNetIncome.Text,txtNetProfit.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "insert into profit(Year,Month,Income,Mon_Sal_Expe,Total_Expe,Net_Income,Profit)values('" +txtYear.Text + "','" + month + "','" + income + "','" + monSalExpe+ "','" + totalExpe+ "','"+netincome+"','" + netprofit + "')";
            cmd.ExecuteNonQuery();
            con.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalForm_MonthlyProfit cp = new CrystalForm_MonthlyProfit();
            cp.ShowDialog();
        }
    }
}
