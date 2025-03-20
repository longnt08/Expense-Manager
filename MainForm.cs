using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseManager.Helpers;

namespace ExpenseManager {
    public partial class MainForm : Form {

        private int userID;
        private string username;
        private string email;
        private DateTime dateCreated;
        public MainForm() {
            InitializeComponent();
        }
        
        public MainForm(int userID, string username, string email, DateTime dateCreated) {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            this.email = email;
            this.dateCreated = dateCreated;
        }
        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void labelExitMain_Click(object sender, EventArgs e) {
            Application.Exit();
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

            manageAccount1.setData(userID, username, email, dateCreated);
        }

        private void BtnSetting_Click(object sender, EventArgs e) {
            ManageSetting manageSettingForm = new ManageSetting();
            manageSettingForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            MainFormUsername.Text = "Welcome " + username;
        }

        private void SignoutBtn_Click(object sender, EventArgs e) {
            DialogResult dialog = MessageBox.Show("Do you watn to sign out?", "Confirm", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes) {
                frmLogin loginForm = new frmLogin();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
