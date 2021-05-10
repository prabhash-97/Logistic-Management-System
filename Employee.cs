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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        //string EmpID = "emp";

        private void GenerateautoID()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select max(Employee_Id) from employee_details where job_Title= 'Helper'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var maxid = cmd.ExecuteScalar() as string;

            
                if (maxid == null)
                {
                    txtEmpId.Text = "H-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6));
                    intval++;
                    txtEmpId.Text = string.Format("H-{0:000000}", intval);
                }
                con.Close();
        }

        private void GenerateautoID1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select max(Employee_Id) from employee_details where job_Title= 'Driver'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var maxid = cmd.ExecuteScalar() as string;

                if (maxid == null)
                {
                    txtEmpId.Text = "D-000001";
                }
                else
                {
                    int intval = int.Parse(maxid.Substring(2, 6));
                    intval++;
                    txtEmpId.Text = string.Format("D-{0:000000}", intval);
                }
            
            con.Close();
        }

        private void GenerateautoID2()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select max(Employee_Id) from employee_details where job_Title= 'Supply Manager'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var maxid = cmd.ExecuteScalar() as string;

            if (maxid == null)
            {
                txtEmpId.Text = "S-000001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(2, 6));
                intval++;
                txtEmpId.Text = string.Format("S-{0:000000}", intval);
            }

            con.Close();
        }

        private void GenerateautoID3()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select max(Employee_Id) from employee_details where job_Title= 'Account Manager'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            var maxid = cmd.ExecuteScalar() as string;

            if (maxid == null)
            {
                txtEmpId.Text = "A-000001";
            }
            else
            {
                int intval = int.Parse(maxid.Substring(2, 6));
                intval++;
                txtEmpId.Text = string.Format("A-{0:000000}", intval);
            }

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
             //GenerateautoID();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg *.gif *.bmp; *.png) | *.jpg; *.jpeg *.gif *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
                    {
                pictureBox1.Image = new System.Drawing.Bitmap(open.FileName);
                    }*/
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string jobid =txtEmpId.Text;
            string dob = DatetimeDob.Text;
            string fname = firTxt.Text;
           string jobstartdate =txtJobStaDat.Text;
            string nic = nicTxt.Text;
            string address = txtAddr.Text;
            Int64 mobile = Int64.Parse(mobTxt.Text);
            string jobtitle = jobtitleTxt.Text;
            string gender = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }

            dataGridView1.Rows.Add(txtEmpId.Text, jobtitleTxt.Text, txtJobStaDat.Text, firTxt.Text, DatetimeDob.Text, nicTxt.Text, gender, mobTxt.Text,txtAddr.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into employee_details(F_name,Job_Start_date,Employee_Id,NIC,Address,Mobile_No,Gender,DOB,Job_Title)values('" + fname + "','"+jobstartdate+"','" + jobid + "','" + nic + "','" + address + "','" + mobile + "','" + gender + "','" + dob + "','" + jobtitle + "')";
            cmd.ExecuteNonQuery();
            con.Close();


            /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=;");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into employee(F_name,Job_Id,NIC,Address,Mobile_No,Gender,DOB,Job_Title)values('" + fname + "','" + jobid + "','" + nic + "','" + address + "','" + mobile + "','" +gender + "','"+dob+"','" + jobtitle + "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();*/

            MessageBox.Show("Data Stored Successfully");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            firTxt.Text = "";
            txtEmpId.Text = "";
            txtAddr.Text = "";
            txtJobStaDat.Text = "";
            mobTxt.Text = "";
            jobtitleTxt.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
           // pictureBox1.Image = null;
            DatetimeDob.Value = DateTimePicker.MinimumDateTime;
 
        }

private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    if (jobtitleTxt.Text == "Helper")
    {
        GenerateautoID();
    }
    else if (jobtitleTxt.Text == "Driver")
    {
        GenerateautoID1();
    }
    else if (jobtitleTxt.Text == "Supplier Manager")
    {
        GenerateautoID2();
    }
    else if (jobtitleTxt.Text == "Account Manager")
    {
        GenerateautoID3();
    }
}

        private void nicTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
