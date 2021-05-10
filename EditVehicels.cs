using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ceylon_petroleum
{
    public partial class EditVehicels : Form
    {
        public EditVehicels()
        {
            InitializeComponent();
            LoadDataIntoDataGridView();
            FillCombo();
        }

        void FillCombo()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            string sql = "select * from employee_details";
            SqlCommand cmd = new SqlCommand(sql, con);

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

        private void LoadDataIntoDataGridView()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from vehicle_details";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            dataGridView1.DataSource = DS.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtVehicleId.Text.Trim() != string.Empty)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from vehicle_details where VehicleID='"+this.txtVehicleId.Text+"'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show("Data updated Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select NIC  or row to update");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtVehicleId.Text.Trim() != string.Empty)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                                       
                cmd.CommandText = "update vehicle_details set Browser_Type='"+this.txtBrowserType.Text+"' , NoOfTyres ='" + this.txtNoTyres.Text + "',VehicleID='"+this.txtVehicleId.Text+"',AssignDriverID='"+this.txtDriverId.Text+"',StartDate='"+this.dateAddToSetvi.Text+"',TyreSerialNo1='" + this.txtTyreNo.Text + "',TyreSerialNo2='" + this.maskedTextBox1.Text + "',TyreSerialNo3='" + this.maskedTextBox2.Text + "' where VehicleID='"+this.txtVehicleId.Text+"';";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                MessageBox.Show("Data updated Successfully");
                LoadDataIntoDataGridView();
            }
            else
            {
                MessageBox.Show("please select NIC  or row to update");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int bid;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
                //bid = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from vehicle_details where Index_No=" + bid + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = int.Parse(DS.Tables[0].Rows[0][6].ToString());

            txtVehicleId.Text = DS.Tables[0].Rows[0][0].ToString();
            txtDriverId.Text = DS.Tables[0].Rows[0][4].ToString();
            dateAddToSetvi.Text = DS.Tables[0].Rows[0][2].ToString();
            txtNoTyres.Text = DS.Tables[0].Rows[0][3].ToString();
            txtTyreNo.Text = DS.Tables[0].Rows[0][1].ToString();
            maskedTextBox1.Text = DS.Tables[0].Rows[0][5].ToString();
            maskedTextBox2.Text = DS.Tables[0].Rows[0][7].ToString();
            txtBrowserType.Text= DS.Tables[0].Rows[0][8].ToString();
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtvehiID.Text.Trim() != string.Empty)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-F7RFSAJ\\MSSQLSERVER2019;database=ceylon_petroleum;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Select * from vehicle_details where VehicleID=@Veh_Id";
                cmd.Parameters.AddWithValue("@Veh_Id", txtvehiID.Text);
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("Enter Vehicle Id to Search");
            }
        }
    }
}
