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
    public partial class View_and_Update : Form
    {
        public View_and_Update()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

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

            dataGridView1.DataSource = dtRecords;
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
                MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "Select * from inventory where Vehicle_id=@Vehicle_Id";
                cmd.Parameters.AddWithValue("@Vehicle_Id", txtVehicle.Text);

                MySqlDataReader sdr = cmd.ExecuteReader();
                DataTable dtRecords = new DataTable();
                dtRecords.Load(sdr);

                dataGridView1.DataSource = dtRecords;
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter Vehicle_id to Search");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index_No = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txtVehicleId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtTyreNo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //dateTimeInsurance.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtInsurenceCost.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtDriverId.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtMonth.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Index_No != 0)
            {
                string vehicleid = txtVehicleId.Text;
                string tyreserialno = txtTyreNo.Text;
                string insurancedate = dateTimeInsurance.Text;
                //float insurancecost = float.Parse(txtInsurenceCost.Text);
                string driverid = txtDriverId.Text;
                string month = txtMonth.Text;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "update inventory set Vehicle_Id='" + this.txtVehicleId.Text + "',Tyre_Serial_No='" + this.txtTyreNo.Text + "',Insu_Date='" + this.dateTimeInsurance.Text + "',Month='" + this.txtMonth.Text + "',Insu_Cost='" + this.txtInsurenceCost.Text + "',Driver_Id='" + this.txtDriverId.Text + "' where Vehicle_Id='" + this.txtVehicleId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();

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
            if (Index_No != 0)
            {
                string vehicleid = txtVehicleId.Text;
                string tyreserialno = txtTyreNo.Text;
                string insurancedate = dateTimeInsurance.Text;
                float insurancecost = float.Parse(txtInsurenceCost.Text);
                string driverid = txtDriverId.Text;
                string month = txtMonth.Text;

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "delete from inventory where Vehicle_Id='" + this.txtVehicleId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();

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
    }
}
