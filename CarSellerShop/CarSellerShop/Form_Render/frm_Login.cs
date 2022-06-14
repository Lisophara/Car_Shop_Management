using CarSellerShop.Data;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Login : Form
    {
       
        public frm_Login()
        {
            InitializeComponent();
            Data_IO data = new Data_IO();
            if(data.Read_Data("*", "`account`", conditionStatement: "WHERE `id` = 1").Rows.Count <= 0)
            {
                new DbSeeder();
            }

        }

        // Event to Close Application

        private void pic_Close_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        // Minimize Application
        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Event Login Button
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.TextValue.Trim();
            string password = txt_Password.TextValue.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("User name or Password can not be Empty or White space!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            Data_IO data = new Data_IO();
            DataTable result = data.Read_Data("acc.stuff_id, stt.stuff_state_name", "`account` acc",
                joinStatement: "JOIN `stuff_info` st ON acc.stuff_id = st.stuff_id JOIN `stuff_state` stt ON st.stuff_state_id = stt.stuff_state_name",
                conditionStatement: $"WHERE acc.user_name = '{username}' AND acc.password = '{password}' AND is_deleted IS NOT TRUE;"
                );

            if(result.Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username and Password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Properties.Settings.Default.staff_id = result.Rows[0][0].ToString();
            Properties.Settings.Default.Save();
            
            this.Visible = false;
            Form frm_sell = new frm_Product();
            frm_sell.Tag = result.Rows[0][0].ToString();
            frm_sell.ShowDialog();
            txt_Username.TextValue = "";
            txt_Password.TextValue = "";
            txt_Username.Focus();
        }
        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.ColorAngle = -45;
        }
        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.ColorAngle = 45;
        }

        // Label Event
        private void lb_ForgotPassword_Click(object sender, EventArgs e)
        {
            new frm_ForgotPassword().ShowDialog();
        }

        private void lb_ForgotPassword_MouseHover(object sender, EventArgs e)
        {
            lb_ForgotPassword.ForeColor = Color.LightGray;
        }

        private void lb_ForgotPassword_MouseLeave(object sender, EventArgs e)
        {
            lb_ForgotPassword.ForeColor = Color.White;
        }

        private void lb_Register_Click(object sender, EventArgs e)
        {
            new frm_Register().ShowDialog();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.staff_id = "";
            Properties.Settings.Default.Save();
        }

        private void lb_ChangePassword_Click(object sender, EventArgs e)
        {
            new frm_ChangePassword().ShowDialog();
        }
    }
}
