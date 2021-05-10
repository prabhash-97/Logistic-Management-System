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
    public partial class AdminstExpen : Form
    {
        public AdminstExpen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            helper_salary hel = new helper_salary();
            hel.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            driver_salary dri = new driver_salary();
            dri.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Expenditure ex = new Expenditure();
            ex.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expenditure ex = new Expenditure();
            ex.Show();
            this.Close();
        }
    }
}
