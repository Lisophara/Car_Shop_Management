using CarSellerShop.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_ForgotPassword : Form
    {
        public frm_ForgotPassword()
        {
            InitializeComponent();
        }

        private void frm_ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            //new frm_Login().Visible = true;
        }

        private void pic_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_GetPassword_Click(object sender, EventArgs e)
        {
            Data_IO data = new Data_IO();
            if(string.IsNullOrWhiteSpace(txt_Username.TextValue) || string.IsNullOrWhiteSpace(txt_ForgotTip.TextValue) || string.IsNullOrWhiteSpace(txt_NationalID.TextValue))
            {
                MessageBox.Show("You must fill all field to get your forgot password back!", "Fill Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            DataTable result = data.Read_Data("acc.password", "`account` acc",
                 joinStatement: "JOIN `stuff_info` st ON acc.stuff_id = st.stuff_id",
                 conditionStatement: $"WHERE acc.user_name = '{txt_Username.TextValue.Trim()}' AND acc.forget_tip = '{txt_ForgotTip.TextValue.Trim()}' AND st.national_id = '{txt_NationalID.TextValue.Trim()}' AND `is_deleted` IS NOT TRUE;"
                 );

            if(result.Rows.Count > 0)
            {
                MessageBox.Show("Your password is: " + result.Rows[0][0].ToString(),"Remain Password",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Account not found!", "Not found", MessageBoxButtons.OK);
            }
        }

        private void lb_BackToLogin_MouseHover(object sender, EventArgs e)
        {
            lb_BackToLogin.ForeColor = System.Drawing.Color.LightGray;
            
        }

        private void lb_BackToLogin_MouseLeave(object sender, EventArgs e)
        {
            lb_BackToLogin.ForeColor = System.Drawing.Color.White;
        }

        private void lb_BackToLogin_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_GetPassword_MouseHover(object sender, EventArgs e)
        {
            btn_GetPassword.ColorAngle = -45;
        }

        private void btn_GetPassword_MouseLeave(object sender, EventArgs e)
        {
            btn_GetPassword.ColorAngle = 45;
        }

        private void pic_Close_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
