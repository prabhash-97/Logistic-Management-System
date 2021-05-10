using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceylon_petroleum
{
    public partial class View_And_Update_Inventory : Form
    {
        public View_And_Update_Inventory()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVehicalReport_Click(object sender, EventArgs e)
        {
            Cystalform_vehicals vehi = new Cystalform_vehicals();
            vehi.Show();



            
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
