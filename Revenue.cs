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
    public partial class Revenue : Form
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransDaily Daily = new TransDaily();
            Daily.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransMonthly Monthly = new TransMonthly();
            Monthly.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CrystalForm_Monthly crymonth = new CrystalForm_Monthly();
            crymonth.ShowDialog();
        }
    }
}
