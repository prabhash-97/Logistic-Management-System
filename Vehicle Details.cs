using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceylon_petroleum
{
    public partial class Vehicle_Details : Form
    {
        public Vehicle_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Inventory add = new Add_Inventory();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditVehicels vi = new EditVehicels();
            vi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrystalForm_VehicleDet cry = new CrystalForm_VehicleDet();
            cry.ShowDialog();
        }

        private void Vehicle_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
