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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void dailyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransDaily Daily = new TransDaily();
            Daily.Show();
        }
        private void monthlyInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransMonthly Monthly = new TransMonthly();
            Monthly.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void dailyInputToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TransDaily Daily = new TransDaily();
            Daily.Show();
        }

        private void monthlyIncomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TransMonthly Monthly = new TransMonthly();
            Monthly.Show();
        }

        private void otherExpenditureToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Vehicle_Details vehicle = new Vehicle_Details();
            vehicle.Show();
        }

        private void monthlyIcomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminstExpen ad = new AdminstExpen();
            ad.Show();
        }

        private void transpotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Revenue Monthly = new Revenue();
            Monthly.Show();
        }

        private void licenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_Details empld = new Employee_Details();
            empld.Show();
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Inventory add = new Add_Inventory();
            add.Show();
        }

        private void licenceDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_and_Update vi = new View_and_Update();
            vi.Show();

        }

        private void netProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profit pro = new Profit();
            pro.Show();
        }

        private void employeeDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditEmployee edit = new EditEmployee();
            edit.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult answer;
            answer = MessageBox.Show("Do you want to exit?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void managerExpenditureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Expenditure ex = new Expenditure();
            ex.Show();
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dailyInputToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            opexpe op = new opexpe();
            op.Show();
        }
    }
}
