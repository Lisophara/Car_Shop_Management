using CarSellerShop.Data;
using CarSellerShop.SubItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Sell : Form
    {

        #region -> Field

        private Data_IO data = new Data_IO();
        private DataTable car_info = new DataTable();
        private string image;
        private int i = 1;
        private decimal price = 0;
        private bool isCustomerExist = false;

        #endregion

        #region -> Constructor

        public frm_Sell()
        {
            InitializeComponent();
            txt_NationalID.LostFocus += Txt_NationalID_LostFocus;
        }

        #endregion

        #region -> Event

        private void frm_Sell_Load(object sender, EventArgs e)
        {
            List<string> lists = (List<string>)this.Tag;
            if (lists.Count <= 0) return;
            foreach (var identifier in lists)
            {
                car_info = data.Read_Data("`model_name`, `price`", table: "`car`", conditionStatement: $"WHERE `identifier` = '{identifier}'");
                order_Info order_info = new order_Info($"{i},{car_info.Rows[0][0]}");
                order_info.btn_Delete.Visible = false;
                order_info.Dock = DockStyle.Bottom;
                panel_OrderLists.Controls.Add(order_info);
                price = decimal.Add(price, decimal.Parse(car_info.Rows[0][1].ToString()));
                if (i > 1)
                {
                    panel_OrderLists.Height += 50;
                    int y = panel_SellWrapper.Location.Y;
                    int x = panel_SellWrapper.Location.X;
                    panel_SellWrapper.Location = new Point(x, y += 57);
                    Debug.WriteLine(i);

                }
                lb_Payment.Text = "$" + price;
                i++;
            }
        }

        private void btn_Minimize_MouseUp(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Close_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void BrowsImage_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void pic_Image_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this image?", "Change Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pic_Image.ImageLocation = "";
                image = "";
                panel_BrowseImage.Visible = true;
            }
            Sold();
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            Customer();
        }

        private void Txt_NationalID_LostFocus(object sender, EventArgs e)
        {
            DataTable customer = data.Read_Data(col: "*", table: "customer", conditionStatement: $"WHERE `identifier` = '{txt_NationalID.TextValue}'");
            isCustomerExist = customer.Rows.Count <= 0;
            if (isCustomerExist)
            {

            }
        }

        #endregion

        #region -> Function

        private void BrowseImage()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                image = file.FileName;
                pic_Image.ImageLocation = image;
                panel_BrowseImage.Visible = false;
            }
        }

        private void Customer()
        {
            
            if (txt_Fname.TextValue == "" || txt_Lname.TextValue == "" || txt_Phone.TextValue == "" || pic_Image.Image == null ||
                txt_NationalID.TextValue == "")
            {
                MessageBox.Show("Please fill all field box like \nFirst or Last name \nNational ID \nPhone number \nBrowse Image",
                    "Fill Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (txt_Phone.TextValue.Length > 10 || txt_NationalID.TextValue.Length > 14)
            {
                MessageBox.Show("Phone number should be less than 10 digit and National ID should be less than 14 digit",
                                    "Fill Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            char gender = cmb_Gender.SelectedIndex == 0 ? 'M' : 'F';
            var dp = dp_Dob.Value;
            data.Write_Data(table: "`customer`", $"`national_id` = '{txt_NationalID.TextValue}'," +
                $"`fname` = {txt_Fname.TextValue},"+
                $"`lname` = {txt_Lname.TextValue},"+
                $"`gender` = {gender},"+
                $"`dob` = DATE('{dp.Year}-{dp.Month}-{dp.Day}')," +
                $"`phone` = {txt_Phone.TextValue},"+
                $"`phone1` = {txt_Phone1.TextValue},"+
                $"`address` = {txt_Address.TextValue},"+
                $"`image_path` = {image},"+
                $"DEFAULT");
        }
    
        
        private void Sold()
        {
            List<string> lists = (List<string>)this.Tag;
            if (lists.Count <= 0) return;
            foreach (var identifier in lists)
            {
                data.Update_Data("`car`", $"`is_sold` = 1", $"WHERE `identifier` = '{identifier}'");
            }
            MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }

}
