using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ceylon_petroleum
{
    public partial class EditEmployee : Form
    {
        public EditEmployee()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }
        private void LoadDataIntoDataGridView()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from employee_details";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private int Emp_Id;
        //Int64 rowid;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtemId.Text.Trim() != string.Empty)
            {
                //Int64 jobid = Int64.Parse(jobidTxt.Text);
                string dob = DatetimeDob.Text;
                string fname = firTxt.Text;
                string lname = JobStartDate.Text;
                string nic = nicTxt.Text;
                string address = txtAddres.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                //string jobtitle = jobtitleTxt.Text;
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


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update employee_details set F_name='" + this.firTxt.Text + "',Job_Start_date='" + this.JobStartDate.Text + "',NIC='" + this.nicTxt.Text + "',Address='" + this.txtAddres.Text + "',Mobile_No='" + this.txtMobile.Text + "',gender='" + gender + "',DOB='" + this.DatetimeDob.Text + "' where Employee_Id='" + this.txtemId.Text + "';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "update employee_details set F_name='" + this.firTxt.Text + "',Job_Start_date='" + this.JobStartDate.Text + "',NIC='" + this.nicTxt.Text + "',Address='" + this.AddTxt.Text + "',Mobile_No='" + this.txtMobile.Text + "',gender='"+gender+"',DOB='" + this.DatetimeDob.Text + "' where Job_Id='" +this.txtJobId.Text+ "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();*/

                MessageBox.Show("Data updated Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select NIC  or row to update");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtemId.Text.Trim() != string.Empty)
            {
                /*
                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "delete from employee where Job_Id='" + this.txtJobId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();*/

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from employee_details where Employee_Id = '" + this.txtemId.Text + "'; ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


                MessageBox.Show("Data deleted Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select NIC to update");
            }
        }

        //int bid;
        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                //bid = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from employee_details where Index_No=" + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = int.Parse(DS.Tables[0].Rows[0][9].ToString());
            txtemId.Text = DS.Tables[0].Rows[0][2].ToString();
            firTxt.Text = DS.Tables[0].Rows[0][0].ToString();
            JobStartDate.Text = DS.Tables[0].Rows[0][1].ToString();
            nicTxt.Text = DS.Tables[0].Rows[0][3].ToString();
            txtAddres.Text = DS.Tables[0].Rows[0][4].ToString();
            txtMobile.Text = DS.Tables[0].Rows[0][5].ToString();
            //gender = DS.Tables[0].Rows[0][7].ToString();
            DatetimeDob.Text = DS.Tables[0].Rows[0][7].ToString();
            
            string gender = DS.Tables[0].Rows[0][6].ToString();
           // bool isChecked = radioButton1.Checked;
            if (gender.Equals( "Male"))
            {
                radioButton1.Checked=true;
            }
            else
            {
                radioButton2.Checked = true;
            }


            /* firTxt.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
             txtJobStaDat.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             txtJobId.Text =dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
             nicTxt.Text =dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
             AddTxt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
             txtMobile.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
             // radioButton1.Checked
             DatetimeDob.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
             jobtitleTxt.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() != string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from employee_details where Employee_Id=@Emp_Id";
                cmd.Parameters.AddWithValue("@Emp_Id", maskedTextBox1.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Enter NIC to Search");
            }
        }

        private void lasTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtemId_TextChanged(object sender, EventArgs e)
        {

        }

        private void nicTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /* private void search()
{
MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

con.Open();

MySqlCommand cmd;
cmd = con.CreateCommand();
cmd.CommandText = "Select * from employee where NIC=@NIC";
cmd.Parameters.AddWithValue("@NIC", txtempId.Text);

MySqlDataReader sdr = cmd.ExecuteReader();
DataTable dtRecords = new DataTable();
dtRecords.Load(sdr);

dataGridView1.DataSource = dtRecords;
con.Close();
}*/
    }
}
