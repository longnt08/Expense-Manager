using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseManager {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void labelExitMain_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = true;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
        }

        private void manageTransactionBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = true;
        }

        private void manageGoalBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = true;
            manageTransaction1.Visible = false;
        }

        private void manageBudgetBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = true;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
        }

        private void manageAccBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = true;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
        }

        private void BtnSetting_Click(object sender, EventArgs e) {
            ManageSetting manageSettingForm = new ManageSetting();
            manageSettingForm.Show();
        }
    }
}
