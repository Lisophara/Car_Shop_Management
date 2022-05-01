using CarSellerShop.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Register : Form
    {
        Data_IO data;
        DataTable result;
        public frm_Register()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            result = data.Read_Data(col: "*",
                table: "`stuff_info`",
                conditionStatement: $"WHERE `stuff_id` = {txt_StaffID.TextValue} AND `national_id` = '{txt_NationalID.TextValue}'");
            if(result.Rows.Count == 0) { return; }
            if(data.Write_Data(table: "`account`",
                dataToInsert:$"DEFAULT," +
                $"'{txt_Username.TextValue}'," +
                $"'{txt_Password}'," +
                $"'{txt_ForgetTip.TextValue}'," +
                $"'{txt_StaffID.TextValue}'," +
                $"DATE('{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}')," +
                $"FALSE "))
            {

            }

        }
    }
}
