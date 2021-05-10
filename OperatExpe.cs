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
    public partial class opexpe : Form
    {
        public opexpe()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
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
                    txtvehiID.Items.Add(driId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void LoadDataIntoDataGridView()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select TyreSerialNo1 , TyreSerialNo2 , TyreSerialNo3 , VehicleID from vehicle_details where TyreSerialNo1 is not null or TyreSerialNo2 is not null or TyreSerialNo3 is not null ";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView2.DataSource = DS.Tables[0];
        }

        void update_delete_vehicel_table()
        {
            if (exptype.Text == "TYRE REMOVE")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update vehicle_details set NoOfTyres = NoOfTyres-'" + this.txtNoTyres.Text + "' where Vehicle_Id='"+this.txtvehiID.Text+"';";
                //vehicleId='" + this.expbow.Text + "';"; TyreSerialNo1='" + this.txtTyreNo.Text + "',TyreSerialNo2='" + this.maskedTextBox1.Text + "',TyreSerialNo3='" + this.maskedTextBox2.Text + "';";
                cmd.CommandText = "delete from vehicle_details where TyreSerialNo1='" + this.txtTyreNo.Text + "' or TyreSerialNo2='" + this.maskedTextBox1.Text + "' or TyreSerialNo3='" + this.maskedTextBox2.Text + "';";
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (exptype.Text == "TYRE ADD")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "update vehicle_details set NoOfTyres=NoOfTyres+'" + this.txtNoTyres.Text + "' where VehicleID='" + this.txtvehiID.Text + "';";
                //,TyreSerialNo1='" + this.txtTyreNo.Text + "',TyreSerialNo2='" + this.maskedTextBox1.Text + "',TyreSerialNo3='" + this.maskedTextBox2.Text + "';";
                cmd.CommandText = "update vehicle_details set TyreSerialNo1 = case TyreSerialNo1 when null then '"+ this.txtNoTyres.Text +"' else end where VehicleID='" + this.txtvehiID.Text + "'; ";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void expsubmit_Click(object sender, EventArgs e)
        {
            string EXP_TYPE = exptype.Text;
            string BOWSER_NUMBER = txtvehiID.Text;
            string DATE = expdate.Text;
            string AMOUNT = expamount.Text;

            dataGridView1.Rows.Add(exptype.Text,txtNoTyres.Text,txtTyreNo.Text,maskedTextBox1.Text,maskedTextBox2.Text, txtvehiID.Text, expdate.Text, expamount.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into expenditure(Exp_type,Vehicle_Id,Date,Amount)values('" + EXP_TYPE + "','" + BOWSER_NUMBER + "','" + DATE + "','" + AMOUNT + "')";
            update_delete_vehicel_table();
            cmd.ExecuteNonQuery();
            con.Close();

            /*MySqlConnection cnn = new MySqlConnection("datasource=127.0.0.1;port=3306;database=logisticmanagmentsystem;username=root;password=; convert zero datetime=TRUE");

            MySqlCommand cmd = null;
            string cmdString = "";
            cnn.Open();

            cmdString = "insert into expenditure(EXP_TYP,BOWSER_NUMBER,DATE,AMOUNT)values('" + EXP_TYPE + "','" + BOWSER_NUMBER + "','" + DATE + "','" + AMOUNT + "')";

            cmd = new MySqlCommand(cmdString, cnn);
            cmd.ExecuteNonQuery();

            cnn.Close();*/

            MessageBox.Show("Data Stored Successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            exptype.Text="";
            txtvehiID.Text="";
            expdate.Text="";
            expamount.Text="";
            txtNoTyres.Text = "";
            maskedTextBox1.Text = " ";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = " ";
            txtTyreNo.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void expexit_Click(object sender, EventArgs e)
        {
            Expenditure ex = new Expenditure();
            ex.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(exptype.Text=="TYRE REMOVE")
            {
                txtNoTyres.Visible = true;

            }
            else if (exptype.Text == "TYRE ADD")
            {

                txtNoTyres.Visible = true;
            }
        }

        private void txtNoTyres_TextChanged(object sender, EventArgs e)
        {
            if (txtNoTyres.Text == "1")
            {
                txtTyreNo.Visible = true;

            }
            else if (txtNoTyres.Text == "2")
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
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
