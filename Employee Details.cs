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
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditEmployee edit = new EditEmployee();
            edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
