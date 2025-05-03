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

        public event EventHandler LogoutClicked;
        public ManageAccount() {
            InitializeComponent();
        }

        public void setData(int userID, string username, string email, DateTime dateCreated) {
            idInfo.Text = userID.ToString();
            usernameInfo.Text = username;
            emailInfo.Text = email;
            createdAtInfo.Text = dateCreated.ToString();
        }

        private void logoutBtnManageAcc_Click(object sender, EventArgs e) {
            MessageBox.Show("button clicked");
            LogoutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ChangeAvatar() {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Title = "Select Avatar Image";
                ofd.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK) {
                    try {
                        string imagePath = ofd.FileName;
                        picAvatar.Image = Image.FromFile(imagePath);
                        picAvatar.SizeMode = PictureBoxSizeMode.Zoom;

                        // Optionally store the path or convert to byte[] for DB
                        // byte[] imageData = File.ReadAllBytes(imagePath);

                        MessageBox.Show("Avatar updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } catch (Exception ex) {
                        MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void changeAvatarBtn_Clicks(object sender, EventArgs e) {
            ChangeAvatar();
        }
    }
}
