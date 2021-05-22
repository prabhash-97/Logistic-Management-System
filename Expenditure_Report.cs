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
    public partial class Expenditure_Report : Form
    {
        public Expenditure_Report()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalForm_OpExpenditure ce = new CrystalForm_OpExpenditure();
            ce.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalForm_AdExpenditure ca = new CrystalForm_AdExpenditure();
            ca.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expenditure ex = new Expenditure();
            ex.Show();
            this.Close();
        }
    }
}
