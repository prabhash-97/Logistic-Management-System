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
            string tyreserialno1 = maskedTextBox0.Text;
            string tyreserialno2 = maskedTextBox1.Text;
            string tyreserialno3 = maskedTextBox2.Text;
            string startdate = dateAddToSetvi.Text;
            //float insurancecost = float.Parse(txtInsurenceCost.Text);
            string noOftyres = txtNoTyres.Text;
            string driId = txtDriverId.Text;
            string browserType = txtBrowserType.Text;
            //float tyrecost=float.Parse(txtTyreCost.Text);

            dataGridView1.Rows.Add(txtVehicleId.Text , txtBrowserType.Text , maskedTextBox0.Text, dateAddToSetvi.Text, txtDriverId.Text,txtNoTyres.Text);

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
            maskedTextBox0.Text = "";
            txtVehicleId.Text = "";
            txtNoTyres.Text = "";
            dateAddToSetvi.Value = DateTimePicker.MinimumDateTime;
            txtDriverId.Text = "";
            txtBrowserType.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";
            maskedTextBox0.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;
            maskedTextBox3.Visible = false;
            maskedTextBox4.Visible = false;
            maskedTextBox5.Visible = false;
            maskedTextBox6.Visible = false;
            maskedTextBox7.Visible = false;
            maskedTextBox8.Visible = false;
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
               maskedTextBox0.Visible=true;

            }else if (txtNoTyres.Text == "2")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
            }
            else if (txtNoTyres.Text == "3")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
            }
            else if (txtNoTyres.Text == "4")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
            }
            else if (txtNoTyres.Text == "5")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
            }
            else if (txtNoTyres.Text == "6")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
            }
            else if (txtNoTyres.Text == "7")
            {
                maskedTextBox0.Visible = true;
                maskedTextBox1.Visible = true;
                maskedTextBox2.Visible = true;
                maskedTextBox3.Visible = true;
                maskedTextBox4.Visible = true;
                maskedTextBox5.Visible = true;
                maskedTextBox6.Visible = true;
            }
            else if (txtNoTyres.Text == "8")
            {
                maskedTextBox0.Visible = true;
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
                maskedTextBox0.Visible = true;
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
