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
    public partial class TransDaily : Form
    {
        public TransDaily()
        {
            InitializeComponent();
            //LoadDataIntoDataGridView();
            FillCombo();
        }


        void FillCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select * from vehicle_details";
            SqlCommand cmd = new SqlCommand(sql, con);

            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    string driId = myreader.GetString(0);
                    txtVehicleId.Items.Add(driId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        /* private void LoadDataIntoDataGridView()
         {
             MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=username;username=root;password=;");

             // MySqlCommand cmd = null;
             string cmdString = "";
             //MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
             con.Open();

             MySqlCommand cmd;
             cmd = con.CreateCommand();
             cmd.CommandText = "Select * from user";

             MySqlDataReader sdr = cmd.ExecuteReader();
             DataTable dtRecords = new DataTable();
             dtRecords.Load(sdr);

             dataGridView1.DataSource = dtRecords;
         }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            income();
            // Int64 Id = Int64.Parse(txtID.Text);
            string date = dateTimePicker1.Text;
            string month = txtMonth.Text;
            string tripe = txtTripe.Text;
            string bowsertype = txtBowserType.Text;
            float low = float.Parse(textBox3.Text);
            float up = float.Parse(textBox7.Text);
            float netamount = float.Parse(txtNetAmount.Text);
            string vehicleid = txtVehicleId.Text;
            //txtID.Text,
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into Daily_trans(Date, Month, Tripe, Browser_type , Vehicel_id , Low_Km, Up_Km, Net_Amount)values('" + date + "', '" + month + "', '" + tripe + "', '" + bowsertype + "', '"+ vehicleid + "','" + low + "', '" + up + "', '" + netamount + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            dataGridView1.Rows.Add( dateTimePicker1.Text, txtMonth.Text, txtTripe.Text, txtBowserType.Text,txtVehicleId.Text, textBox3.Text, textBox7.Text, txtNetAmount.Text);
           /* MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=;");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into dailytrans(Date,Month,Tripe,BowserType,Low_km,Up_km,NetAmount)values('" + date + "','" + month + "','" + tripe + "','" + bowsertype + "','" + low + "','" + up + "','" + netamount + "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();
           */
            MessageBox.Show("Data Stored Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            income();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* private void Multiply()
         {
             if (comboBox1.Text == "66000 Litres")
             {
                 float a, b;

                 bool isAValid = float.TryParse(textBox5.Text, out a);
                 bool isBValid = float.TryParse(textBox4.Text, out b);

                 if (isAValid && isBValid)
                     textBox8.Text = ((a * 110) + (b * 100)).ToString();
                 else
                     textBox8.Text = "Invalid input";
             }
             else
             {
                 float a, b;

                 bool isAValid = float.TryParse(textBox5.Text, out a);
                 bool isBValid = float.TryParse(textBox4.Text, out b);

                 if (isAValid && isBValid)
                     textBox8.Text = ((a * 2) + (b * 10)).ToString();
                 else
                     textBox8.Text = "Invalid input";

             }
         }*/
        private void income()
        {
            try
            {

                // string tripe = txtTripe.Text;
                string bowsertype = txtBowserType.Text;

                if (bowsertype == "66000 Ltrs.")
                {
                    //double low =6600*0.01055;
                    // double up = 6600*0.01257;
                    float a, b;

                    bool isAValid = float.TryParse(textBox3.Text, out a);
                    bool isBValid = float.TryParse(textBox7.Text, out b);

                    if (isAValid && isBValid)
                        txtNetAmount.Text = ((a * 66000 * 0.01257)+ (b * 66000 * 0.01055)).ToString();
                    else
                        MessageBox.Show("invalid Input");
                }
                else if (bowsertype == "33000 Ltrs.")
                {
                    float a, b;

                    bool isAValid = float.TryParse(textBox3.Text, out a);
                    bool isBValid = float.TryParse(textBox7.Text, out b);

                    if (isAValid && isBValid)
                        txtNetAmount.Text = ((a * 33000 * 0.00878) + (b * 33000 * 0.00996)).ToString();
                    else
                        MessageBox.Show("invalid Input");

                }
                else
                {
                    MessageBox.Show("Not Avalible in Database or incorrect format");
                }
            }
            catch
            {

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //txtID.Text = " ";
            txtMonth.Text = " ";
            txtBowserType.Text = " ";
            txtTripe.Text = " ";
            txtNetAmount.Text = "";
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
            textBox3.Text = "";
            textBox7.Text = "";
            txtVehicleId.Text = "";
        }

        private void txtBowserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
