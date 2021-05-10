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
    public partial class driver_salary : Form
    {
        public driver_salary()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private int Index_No;
        private void LoadDataIntoDataGridView()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from helper_sal";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

            private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Expenditure ex = new Expenditure();
            //ex.Show();
            //this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int bid;
        Int64 rowid;

        private void drisubmit_Click(object sender, EventArgs e)
        {
            if (Index_No != 0)
            {

                string employee_id = empid.Text;
                string open_date = dristartdate.Text;
                string end_date = drienddate.Text;
                Int64 commission = Int64.Parse(dricomm.Text);
                Int64 advance = Int64.Parse(dripaid.Text);
                float salary_payable = float.Parse(dripaya.Text);


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update helper_sal set employee_id='" + this.empid.Text + "',open_date='" + this.dristartdate.Text + "',end_date='" + this.drienddate.Text + "',commision='" + this.dricomm.Text + "',advance='" + this.dripaid.Text + "',salary_payable='" + this.dripaya.Text + "' where employee_id='" + this.txtEmployee.Text + "';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show("Data Upadted Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Please select the row!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminstExpen ex = new AdminstExpen();
            ex.Show();
            this.Close();
        }

        private void drienddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtEmployee.Text.Trim()!=string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from helper_sal where employee_id=@Emp_Id";
                cmd.Parameters.AddWithValue("@Emp_Id", txtEmployee.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (empid.Text.Trim() != string.Empty)
            {

                string employee_id = empid.Text;
                string open_date = dristartdate.Text;
                string end_date = drienddate.Text;
                string commission = dricomm.Text;
                string advance = dripaid.Text;
                string salary_payable = dripaya.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from helper_sal where employee_id='" + this.empid.Text + "';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show("Data Deleted Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Please select the row!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from helper_sal where Index_No=" + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][6].ToString());

            empid.Text = DS.Tables[0].Rows[0][0].ToString();
            dristartdate.Text = DS.Tables[0].Rows[0][1].ToString();
            drienddate.Text = DS.Tables[0].Rows[0][2].ToString();
            dricomm.Text = DS.Tables[0].Rows[0][3].ToString();
            dripaid.Text = DS.Tables[0].Rows[0][4].ToString();
            dripaya.Text = DS.Tables[0].Rows[0][5].ToString();
        }
    }
}
