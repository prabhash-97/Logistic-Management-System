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
    public partial class Add_Inventory : Form
    {
        public Add_Inventory()
        {
            InitializeComponent();
            FillCombo();
        }

        void FillCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select * from employee_details where Job_Title= 'Driver'";
            SqlCommand cmd = new SqlCommand(sql,con);
            
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string driId = myreader.GetString(2);
                    txtDriverId.Items.Add(driId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string vehicleid = txtVehicleId.Text;
            string tyreserialno1 = txtTyreNo.Text;
            string tyreserialno2 = maskedTextBox1.Text;
            string tyreserialno3 = maskedTextBox2.Text;
            string startdate = dateAddToSetvi.Text;
            //float insurancecost = float.Parse(txtInsurenceCost.Text);
            string noOftyres = txtNoTyres.Text;
            string driId = txtDriverId.Text;
            string browserType = txtBrowserType.Text;
            //float tyrecost=float.Parse(txtTyreCost.Text);

            dataGridView1.Rows.Add(txtVehicleId.Text , txtBrowserType.Text , txtTyreNo.Text, dateAddToSetvi.Text, txtDriverId.Text,txtNoTyres.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into vehicle_details(VehicleID , Browser_Type , NoOfTyres,StartDate,AssignDriverID,TyreSerialNo1,TyreSerialNo2,TyreSerialNo3)values('" + vehicleid + "','"+browserType+"','" + noOftyres + "','" + startdate + "','" + driId + "','"+tyreserialno1+ "','" + tyreserialno2 + "','" + tyreserialno3 + "')";
            cmd.ExecuteNonQuery();
            con.Close();


            /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into inventory(vehicle_Id,Tyre_Serial_No,Insu_Date, Month,Insu_Cost,Driver_Id)values('" + vehicleid + "','" + tyreserialno + "','" + insurancedate + "','" + month + "','" + insurancecost + "','" + driverid + "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();*/

            MessageBox.Show("Data Stored Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVehicleId.Text = "";
            txtTyreNo.Text = "";
            txtVehicleId.Text = "";
           // txtInsurenceCost.Text = "";
            txtNoTyres.Text = "";
            dateAddToSetvi.Value = DateTimePicker.MinimumDateTime;
            txtDriverId.Text = "";
            // txtTyreCost.Text = "";
            txtBrowserType.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeInsurance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtInsurenceCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNoTyres_TextChanged(object sender, EventArgs e)
        {
            if (txtNoTyres.Text == "1")
            {
                txtTyreNo.Visible=true;

            }else if (txtNoTyres.Text == "2")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
            }
            else if (txtNoTyres.Text == "3")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
            }
            else if (txtNoTyres.Text == "4")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
            }
            else if (txtNoTyres.Text == "5")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
            }
            else if (txtNoTyres.Text == "6")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
            }
            else if (txtNoTyres.Text == "7")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox6.Visible = true;
            }
            else if (txtNoTyres.Text == "8")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox6.Visible = true;
                maskedTextBox7.Visible = true;
            }
            else if (txtNoTyres.Text == "9")
            {
                txtTyreNo.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox6.Visible = true;
                maskedTextBox7.Visible = true;
                maskedTextBox8.Visible = true;
            }
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
