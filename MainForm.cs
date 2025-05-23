﻿using System;
using System.Windows.Forms;

namespace ExpenseManager {
    public partial class MainForm : Form {

        private int userID;
        private string username;
        private string email;
        private DateTime dateCreated;

        public MainForm() {
            InitializeComponent();
            //manageAccount1.LogoutClicked += ManageAccount1_LogoutClicked;
        }

        public MainForm(int userID, string username, string email, DateTime dateCreated) {
            InitializeComponent();
            this.userID = userID;
            this.username = username;
            this.email = email;
            this.dateCreated = dateCreated;

            //dashboard1.LoadData(userID);
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
            manageFund1.Visible = false;
            manageDebt1.Visible = false;

            //dashboard1.LoadData(userID);
        }

        private void manageTransactionBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageFund1.Visible = false;
            manageTransaction1.Visible = true;
            manageDebt1.Visible = false;

            //manageTransaction1.setUserID(userID);
        }

        private void manageGoalBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = true;
            manageTransaction1.Visible = false;
            manageFund1.Visible = false;
            manageDebt1.Visible = false;

            //manageGoal1.setUserID(userID);
        }

        private void manageBudgetBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = true;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
            manageFund1.Visible = false;
            manageDebt1.Visible = false;
        }

        private void manageAccBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = true;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
            manageFund1.Visible = false;
            manageDebt1.Visible = false;

            //manageAccount1.setData(userID, username, email, dateCreated);
        }

        private void BtnSetting_Click(object sender, EventArgs e) {
            //ManageSetting manageSettingForm = new ManageSetting();
            //manageSettingForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            MainFormUsername.Text = "Welcome " + username;
        }

        private void SignoutBtn_Click(object sender, EventArgs e) {
            //DialogResult dialog = MessageBox.Show("Do you want to sign out?", "Confirm", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes) {
            //    this.Hide();
            //    frmLogin loginForm = new frmLogin();
            //    loginForm.ShowDialog();
            //    this.Close();
            //}
        }

        private void ManageAccount1_LogoutClicked(object sender, EventArgs e) {
            //DialogResult dialog = MessageBox.Show("Do you want to sign out?", "Confirm", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes) {
            //    this.Hide();
            //    frmLogin loginForm = new frmLogin();
            //    loginForm.ShowDialog();
            //    this.Close();
            //}
        }

        private void manageFundBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
            manageFund1.Visible = true;
            manageDebt1.Visible = false;

            manageFund1.LoadData();
        }

        private void manageBtn_Click(object sender, EventArgs e) {
            dashboard1.Visible = false;
            manageAccount1.Visible = false;
            manageBudget1.Visible = false;
            manageGoal1.Visible = false;
            manageTransaction1.Visible = false;
            manageFund1.Visible = false;
            manageDebt1.Visible = true;
        }
    }
}
