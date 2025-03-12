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
    public partial class ManageSetting : Form {
        public ManageSetting() {
            InitializeComponent();
        }

        private void ExitSettingLabel_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
