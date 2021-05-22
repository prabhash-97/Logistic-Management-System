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
using System.Data.SqlClient;

namespace ceylon_petroleum
{
    public partial class helper_salary : Form
    {
        public helper_salary()
        {
            InitializeComponent();
            FillCombo();
        }

        void sum_salary()
        {
            float a, b, c;

            bool isAValid = float.TryParse(helperpaid.Text, out a);
            bool isBValid = float.TryParse(helperpaya.Text, out b);
            bool isCValid = float.TryParse(helpercomm.Text, out c);

            if (isAValid && isBValid && isCValid)
                txtTotal.Text = (a + b + c).ToString();
            else
                MessageBox.Show("invalid Input");
        }

        void FillCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select * from employee_details";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string driId = myreader.GetString(2);
                    txtEmp.Items.Add(driId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEmp.Text="";
            helperopen.Value= DateTimePicker.MinimumDateTime; ;
            helperclos.Value= DateTimePicker.MinimumDateTime; ;
            helpercomm.Text="";
            helperpaid.Text="";
            helperpaya.Text="";
            txtTotal.Text = "";

        }

        private void helpersub_Click(object sender, EventArgs e)
        {
            sum_salary();
            string employee_id = txtEmp.Text;
            string open_date = helperopen.Text;
            string end_date = helperclos.Text;
            Int64 commission = Int64.Parse(helpercomm.Text);
            Int64 advance = Int64.Parse(helperpaid.Text);
            float salary_payable = float.Parse(helperpaya.Text);

            dataGridView2.Rows.Add(txtEmp.Text , helperopen.Text , helperclos.Text , helpercomm.Text , helperpaid.Text , helperpaya.Text , txtTotal.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into helper_sal(employee_id,open_date,end_date,commission,advance,salary_payable, Total)values('" + employee_id + "','" + open_date + "','" + end_date + "','" + commission + "','" + advance + "','" + salary_payable + "','"+txtTotal.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Stored Successfully");
        }

        private void helper_salary_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminstExpen ex = new AdminstExpen();
            ex.Show();
            this.Close();
        }

        private void helpercomm_TextChanged(object sender, EventArgs e)
        {

        }

        private void helperpaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void helbow_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
