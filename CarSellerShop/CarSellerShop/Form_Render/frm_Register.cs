using CarSellerShop.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Register : Form
    {
        Data_IO data = new Data_IO();
        DataTable result;
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            result = data.Read_Data(col: "*",
                table: "`stuff_info`",
                conditionStatement: $"WHERE `stuff_id` = {txt_StaffID.TextValue.Trim()} AND `national_id` = '{txt_NationalID.TextValue.Trim()}'");

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Staff Id or National Id not found!", "Not Found", MessageBoxButtons.OK);
                return;
            }
            if (data.Write_Data(table: "`account`",
                dataToInsert: $"DEFAULT," +
                $"'{txt_Username.TextValue.Trim()}'," +
                $"'{txt_Password.TextValue.Trim()}'," +
                $"'{txt_ForgetTip.TextValue.Trim()}'," +
                $"'{txt_StaffID.TextValue.Trim()}'," +
                $"DATE('{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}')," +
                $"FALSE "))
            {
                MessageBox.Show("Success!", "Register", MessageBoxButtons.OK);
                this.Dispose();
            }

        }

        private void pic_Close_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
