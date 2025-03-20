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
    public partial class ManageAccount : UserControl {
        public ManageAccount() {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e) {

        }

        private void ManageAccount_Load(object sender, EventArgs e) {
            
        }
        public void setData(int userID, string username, string email, DateTime dateCreated) {
            idInfo.Text = userID.ToString();
            usernameInfo.Text = username;
            emailInfo.Text = email;
            createdAtInfo.Text = dateCreated.ToString();
        }
    }
}
