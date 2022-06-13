using CarSellerShop.Data;
using System;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_ChangePassword : Form
    {
        private Data_IO data = new Data_IO();
        public frm_ChangePassword()
        {
            InitializeComponent();
        }

        private void pic_Close_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            string email = txt_Email.TextValue.Trim();
            string password = txt_Password.TextValue.Trim();
            string newPassword = txt_NewPassword.TextValue.Trim();
            string confirm = txt_ConfirmPassword.TextValue.Trim();
            if(newPassword != confirm)
            {
                MessageBox.Show("Confirm password is not match with your new password!", "Not match password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (data.Update_Data("account", $"`password` = '{newPassword}'", $"`user_name` = '{email}' AND `password` = '{password}' AND `account_disable` IS NOT TRUE"))
            {
                MessageBox.Show("Change success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username and Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
