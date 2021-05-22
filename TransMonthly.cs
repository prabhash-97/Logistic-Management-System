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
    public partial class TransMonthly : Form
    {
        public TransMonthly()
        {
            InitializeComponent();
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

        private void TransMonthly_Load(object sender, EventArgs e)
        {
           // panel1.Visible = false;

        }
        //private int Index_No;

        //private int Transaction_Id;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string month = combMonth.Text;
            if (month == "July")
            {
                //MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                // MySqlCommand cmd = null;
                //string cmdString = "";
                //MySqlConnection con = new MySqlConnection(AppSettings.ConnectionString());
                //con.Open();

                //MySqlCommand cmd;
                //cmd = con.CreateCommand();
                //cmd.CommandText = "Select * from dailytrans where Month='July'";

                //MySqlDataReader sdr = cmd.ExecuteReader();
                //DataTable dtRecords = new DataTable();
                //dtRecords.Load(sdr);

                //dataGridView1.DataSource = dtRecords; 


            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for (int i = 0;i<dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dataGridView1.Rows[i].Cells["Net_Amount"].Value);

            }
            textAmount.Text = sum.ToString();
            txtYear.Text = textBox1.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*if (Index_No != 0)
            {
                string month = txtMthSrch.Text;
                decimal amount = decimal.Parse(textAmount.Text);

                MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=;");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "update monthlytrans  set Month='" + this.txtMthSrch.Text + "',Income='" + this.textAmount.Text + "' where  Month='" + this.txtMthSrch.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();

                MessageBox.Show("Monthly Income update Successfully");
            }
            else
            {
                MessageBox.Show("Not Updated!");
            }

        */
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtMthSrch.Text.Trim() != string.Empty && textBox1.Text.Trim() !=string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from Daily_trans where Month=@Month and Year(Date)=@Year";
                cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);
                cmd.Parameters.AddWithValue("@Year", textBox1.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                /* MySqlConnection con = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                 con.Open();

                 MySqlCommand cmd;
                 cmd = con.CreateCommand();
                 cmd.CommandText = "Select * from dailytrans where Month=@Month";
                 cmd.Parameters.AddWithValue("@Month", txtMthSrch.Text);

                 MySqlDataReader sdr = cmd.ExecuteReader();
                 DataTable dtRecords = new DataTable();
                 dtRecords.Load(sdr);

                 dataGridView1.DataSource = dtRecords;
                 con.Close();*/
            }
            else
            {
                MessageBox.Show("Please enter Month to search");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Int64 Id = Int64.Parse(txtID.Text);

            if (txtMonth.Text.Trim() != string.Empty)
            {
                //string date = dateTimePicker1.Text;
                string month = txtMonth.Text;
                string tripe = txtTripe.Text;
                string bowsertype = txtBowserType.Text;
                float low = float.Parse(textBox3.Text);
                float up = float.Parse(textBox7.Text);
                float netamount = float.Parse(txtNetAmount.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update Daily_trans set Vehicel_id='"+ this.txtVehicleId.Text+"' , Month='" + this.txtMonth.Text + "',Tripe='" + this.txtTripe.Text + "',Browser_type='" + this.txtBowserType.Text + "',Low_Km='" + this.textBox3.Text + "',Up_Km='" + this.textBox7.Text + "',Net_Amount='" + this.txtNetAmount.Text + "' where Transaction_Id=" + rowid + ";";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                

                /* MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                 MySqlCommand cmd = null;
                 string cmdString = "";
                 cnn.Open();

                 cmdString = "update dailytrans set Month='" + this.txtMonth.Text + "',Tripe='" + this.txtTripe.Text + "',BowserType='" + this.txtBowserType.Text + "',Low_km='" + this.textBox3.Text + "',Up_km='" + this.textBox7.Text + "',NetAmount='" + this.txtNetAmount.Text + "' where Transaction_Id='" + this.txtTransId.Text + "';";

                 cmd = new MySqlCommand(cmdString, cnn);
                 cmd.ExecuteNonQuery();

                 cnn.Close();*/

                MessageBox.Show("Data updated Successfully");
                serach();
            }
            else
            {
                MessageBox.Show("Please select row to update");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textAmount.Text.Trim() != string.Empty)
            {
                string month = txtMthSrch.Text;
                decimal amount = decimal.Parse(textAmount.Text);
                string year = txtYear.Text;
                string date = dateTimePicker1.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into monthlytrans(Month,Income,Year,Date) values('" + month + "','" + amount + "','" + year + "','"+date+"')";
                cmd.ExecuteNonQuery();
                con.Close();

                /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=;");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "insert into monthlytrans(Month,Income,Year) values('" + month + "','" + amount + "','" + year + "')";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();
                */
                MessageBox.Show("Monthly Income stored Successfully");
                txtYear.Text = "";
                textAmount.Text = "";
            }
            else
            {
                MessageBox.Show("Please select Month and click on get montly income");
            } 

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtMonth.Text.Trim() != string.Empty)
            {
                //string date = dateTimePicker1.Text;
                string month = txtMonth.Text;
                string tripe = txtTripe.Text;
                string bowsertype = txtBowserType.Text;
                float low = float.Parse(textBox3.Text);
                float up = float.Parse(textBox7.Text);
                float netamount = float.Parse(txtNetAmount.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from Daily_trans where Transaction_Id=" + rowid + ";";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

                MySqlCommand cmd = null;
                string cmdString = "";
                cnn.Open();

                cmdString = "delete from dailytrans where Transaction_Id='" + this.txtTransId.Text + "';";

                cmd = new MySqlCommand(cmdString, cnn);
                cmd.ExecuteNonQuery();

                cnn.Close();*/

                MessageBox.Show("Data deleted Successfully");
                serach();
            }
            else
            {
                MessageBox.Show("please select row to delete");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            income();
        }
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
                        txtNetAmount.Text = ((a * 66000 * 0.01257) + (b * 66000 * 0.01055)).ToString();
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

        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
             {
                 bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
             }

            // panel1.Visible = true;
             SqlConnection con = new SqlConnection();
             con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = con;

             cmd.CommandText = "Select * from Daily_trans where Transaction_Id="+ bid +"";
             SqlDataAdapter DA = new SqlDataAdapter(cmd);
             DataSet DS = new DataSet();
             DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtMonth.Text = DS.Tables[0].Rows[0][2].ToString();
            txtBowserType.Text = DS.Tables[0].Rows[0][4].ToString();
            txtTripe.Text= DS.Tables[0].Rows[0][3].ToString();
            textBox3.Text= DS.Tables[0].Rows[0][5].ToString();
            textBox7.Text= DS.Tables[0].Rows[0][6].ToString();
            txtVehicleId.Text = DS.Tables[0].Rows[0][8].ToString();
            txtNetAmount.Text = DS.Tables[0].Rows[0][7].ToString();
            dateTimePicker2.Text = DS.Tables[0].Rows[0][1].ToString();

        }

        private void txtTransId_TextChanged(object sender, EventArgs e)
        {

        }
        private void serach()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Daily_trans where Month=@Month and Year(Date)=@Year";
            cmd.Parameters.AddWithValue("@Month", txtMonthSearch.Text);
            cmd.Parameters.AddWithValue("@Year", textBox1.Text);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void txtBowserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMthSrch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtTransId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTripe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtVehicleId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
