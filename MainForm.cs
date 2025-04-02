using System;
using System.Collections.Generic;
using System.Drawing;
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
            ShowPopupNotification("A new setting was applied.");
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

        //Start of AI integrated notification center
        private List<string> notifications = new List<string>();
        private Panel notificationPopup;
        private Timer popupTimer;
        private Panel notificationDropdown;
        private Label popupLabel;

        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormUsername.Text = "Welcome " + username;

            // Setup popup
            notificationPopup = new Panel
            {
                Size = new Size(250, 50),
                BackColor = Color.DarkViolet,
                Visible = false,
                BorderStyle = BorderStyle.FixedSingle
            };

            popupLabel = new Label
            {
                AutoSize = false,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White
            };

            notificationPopup.Controls.Add(popupLabel);
            this.Controls.Add(notificationPopup);
            popupTimer = new Timer();
            popupTimer.Interval = 3000;
            popupTimer.Tick += PopupTimer_Tick;

            // Setup dropdown list
            notificationDropdown = new Panel
            {
                Size = new Size(250, 150),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Visible = false,
                AutoScroll = true
            };
            this.Controls.Add(notificationDropdown);
        }

        private void PopupTimer_Tick(object sender, EventArgs e)
        {
            popupTimer.Stop();
            notificationPopup.Visible = false;
        }

        private void ShowPopupNotification(string message)
        {
            popupLabel.Text = message;
            notificationPopup.Location = new Point(this.Width - notificationPopup.Width - 20, 40);
            notificationPopup.BringToFront();
            notificationPopup.Visible = true;
            popupTimer.Start();

            notifications.Add(message);
        }

        private void notificationBell_Click(object sender, EventArgs e)
        {
            if (notificationDropdown.Visible)
            {
                notificationDropdown.Visible = false;
                return;
            }

            notificationDropdown.Controls.Clear();
            int y = 5;

            foreach (string msg in notifications)
            {
                Label lbl = new Label
                {
                    Text = msg,
                    AutoSize = false,
                    Width = notificationDropdown.Width - 10,
                    Height = 30,
                    Location = new Point(5, y),
                    BackColor = Color.Lavender,
                    ForeColor = Color.Black,
                    Padding = new Padding(5)
                };
                notificationDropdown.Controls.Add(lbl);
                y += 35;
            }

            notificationDropdown.Location = new Point(bell_icon.Left, bell_icon.Bottom + 5);
            notificationDropdown.BringToFront();
            notificationDropdown.Visible = true;
        }


    }
}
