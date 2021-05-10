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
    public partial class View_and_Update : Form
    {
        public View_and_Update()
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

            cmd.CommandText = "Select * from vehicle_details order by VehicleID,StartDate,AssignDriverID,NoOfTyres,TyreSerialNo1, TyreSerialNo2, TyreSerialNo3";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];

            /*MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

            // MySqlCommand cmd = null;
            //string cmdString = "";
            //MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from inventory";

            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dtRecords = new DataTable();
            dtRecords.Load(sdr);

            dataGridView1.DataSource = dtRecords;*/
        }
        private int Index_No;

        private void View_and_Update_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*string vehicleid =txtVehicleId.Text;
           string tyreserialno = txtTyreNo.Text;
           string insurancedate = DateTimeInsurance.Text;
           // float insurancecost = float.Parse(txtInsurenceCost.Text);
           string driverid = txtDriverId.Text;

           MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");
           MySqlDataReader mdr;
           MySqlCommand cmd = null;
           string cmdString = "";
           cnn.Open();

           cmdString = "SELECT * FROM logisticmanagmentsystem.inventory WHERE Driver_Id=" + txtDriverId.Text;

           cmd = new MySqlCommand(cmdString, cnn);
           mdr = cmd.ExecuteReader();
           if (mdr.Read())
           {
               txtVehicleId.Text = mdr.GetString("Vehicle_Id");
               txtTyreNo.Text = mdr.GetString("Tyre_Serial_No");
               DateTimeInsurance.Text = mdr.GetString("Insu_Date");
               txtInsurenceCost.Text = mdr.GetFloat("Insu_Cost").ToString();
               txtDriverId.Text = mdr.GetString("Driver_Id");

           }
           else
           {
               MessageBox.Show("No Data For This Vehicle Id");
           }

           cnn.Close();
           */

            if (txtVehicle.Text.Trim() != string.Empty)
            {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "Select * from vehicle_details where VehicleID=@Vehicle_Id";
                    cmd.Parameters.AddWithValue("@Vehicle_Id", txtVehicle.Text);
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    /*MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                    con.Open();

                    MySqlCommand cmd;
                    cmd = con.CreateCommand();
                    cmd.CommandText = "Select * from inventory where Vehicle_id=@Vehicle_Id";
                    cmd.Parameters.AddWithValue("@Vehicle_Id", txtVehicle.Text);

                    MySqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dtRecords = new DataTable();
                    dtRecords.Load(sdr);

                    dataGridView1.DataSource = dtRecords;
                    con.Close();*/
                }
            else
            {
                MessageBox.Show("Enter Vehicle_id to Search");
            }

        }

        int bid;
        Int64 rowid;

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

            cmd.CommandText = "Select * from vehicle_details where Index_No=" + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][6].ToString());

            txtVehicleId.Text = DS.Tables[0].Rows[0][0].ToString();
            txtTyreNo.Text = DS.Tables[0].Rows[0][1].ToString();
            maskedTextBox2.Text = DS.Tables[0].Rows[0][7].ToString();
            txtDriverId.Text = DS.Tables[0].Rows[0][4].ToString();
            txtNoTyres.Text = DS.Tables[0].Rows[0][3].ToString();
            maskedTextBox1.Text = DS.Tables[0].Rows[0][5].ToString();
            dateAddService.Text = DS.Tables[0].Rows[0][2].ToString();


            /*Index_No = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtVehicleId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTyreNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //dateTimeInsurance.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtInsurenceCost.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDriverId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtMonth.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();*/
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtVehicleId.Text.Trim() != string.Empty)
            {
                string vehicleid = txtVehicleId.Text;
                string tyreserialno = txtTyreNo.Text;
                string startdate = dateAddService.Text;
                //float insurancecost = float.Parse(txtInsurenceCost.Text);
                string NoOftyre = txtNoTyres.Text;
                string driId = txtDriverId.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update vehicle_details set VehicleID='" + this.txtVehicleId.Text + "',TyreSerialNo1='" + this.txtTyreNo.Text + "',TyreSerialNo2='" + this.maskedTextBox1.Text + "',TyreSerialNo3='" + this.maskedTextBox2.Text + "',StartDate='" + this.dateAddService.Text + "',AssignDriverID='" + this.txtDriverId.Text + "', NoOfTyres='" + this.txtNoTyres.Text + "' where VehicleID='" + this.txtVehicleId.Text + "';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //,TyreCost='"+this.txtTyreCost+"'

                /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "update inventory set Vehicle_Id='" + this.txtVehicleId.Text + "',Tyre_Serial_No='" + this.txtTyreNo.Text + "',Insu_Date='" + this.dateTimeInsurance.Text + "',Month='" + this.txtMonth.Text + "',Insu_Cost='" + this.txtInsurenceCost.Text + "',Driver_Id='" + this.txtDriverId.Text + "' where Vehicle_Id='" + this.txtVehicleId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();*/

                MessageBox.Show("Data updated Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select vehicle_id OR select row to update");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtVehicleId.Text.Trim() != string.Empty)
            {
                string vehicleid = txtVehicleId.Text;
                string tyreserialno = txtTyreNo.Text;
                string insurancedate = dateAddService.Text;
                //float insurancecost = float.Parse(txtInsurenceCost.Text);
                string driverid = txtNoTyres.Text;
                string month = txtDriverId.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from vehicle_details where VehicleID='" + this.txtVehicleId.Text + "';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "delete from inventory where Vehicle_Id='" + this.txtVehicleId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();*/

                MessageBox.Show("Data deleted Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select Vehicle_id OR row to delete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
