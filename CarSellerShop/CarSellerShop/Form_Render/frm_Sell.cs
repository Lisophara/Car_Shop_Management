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

            txt_NationalID.Leave += Txt_NationalID_Leave;
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

        private void btn_Close_Click(object sender, EventArgs e)
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
        }

        private void btn_Sell_Click(object sender, EventArgs e)
        {
            if(!Customer()) return;
            Sold(txt_NationalID.TextValue);
        }

        private void Txt_NationalID_Leave(object sender, EventArgs e)
        {
            DataTable customers = data.Read_Data(col: "*", table: "customer", conditionStatement: $"WHERE `national_id` = '{txt_NationalID.TextValue}'");
            isCustomerExist = customers.Rows.Count > 0;
            if (isCustomerExist)
            {
                var customer = customers.Rows[0];
                txt_Fname.TextValue = customer[1].ToString();
                txt_Lname.TextValue = customer[2].ToString();
                cmb_Gender.SelectedIndex = customer[3].ToString() == "M" ? 0 : 1;
                dp_Dob.Text = customer[4].ToString();
                txt_Phone.TextValue = customer[5].ToString();
                txt_Phone1.TextValue = customer[6].ToString();
                txt_Address.TextValue = customer[7].ToString();
                pic_Image.ImageLocation = customer[8].ToString();
                panel_BrowseImage.Visible = false;
                image = customer[8].ToString();
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

        private bool Customer()
        {

            if (txt_Fname.TextValue == "" || txt_Lname.TextValue == "" || txt_Phone.TextValue == "" || pic_Image.Image == null ||
                txt_NationalID.TextValue == "")
            {
                MessageBox.Show("Please fill all field box like \nFirst or Last name \nNational ID \nPhone number \nBrowse Image",
                    "Fill Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            else if (txt_Phone.TextValue.Length > 10 || txt_NationalID.TextValue.Length > 14)
            {
                MessageBox.Show("Phone number should be less than 10 digit and National ID should be less than 14 digit",
                                    "Fill Requirement", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            char gender = cmb_Gender.SelectedIndex == 0 ? 'M' : 'F';
            var dp = dp_Dob.Value;
            if (isCustomerExist)
            {
                string image_path = data.SaveImage(image);
                return data.Update_Data(table: "customer", col_Value: 
                    $"`first_name` = '{txt_Fname.TextValue}'," +
                    $"`last_name` = '{txt_Lname.TextValue}'," +
                    $"`gender` = '{gender}'," +
                    $"`dob` = DATE('{dp.Year}-{dp.Month}-{dp.Day}')," +
                    $"`phone` = '{txt_Phone1.TextValue}'," +
                    $"`phone2` = '{txt_Phone.TextValue}'," +
                    $"`addr` = '{txt_Address.TextValue}'," +
                    $"`image_path` = '{image_path}'",
                    condition: $"`national_id` = {txt_NationalID.TextValue}");
            }
            else
            {
                return data.Write_Data(table: "`customer`", $"`national_id` = '{txt_NationalID.TextValue}'," +
                    $"'{txt_Fname.TextValue}',"+
                    $"'{txt_Lname.TextValue}',"+
                    $"'{gender}',"+
                    $"DATE('{dp.Year}-{dp.Month}-{dp.Day}')," +
                    $"'{txt_Phone.TextValue}',"+
                    $"'{txt_Phone1.TextValue}',"+
                    $"'{txt_Address.TextValue}',"+
                    $"'{image}',"+
                    $"DEFAULT");
            }
            return true;
        }
    
        
        private void Sold(string customer_national_id)
        {
            bool success = false;
            DateTime date = DateTime.Today;
            DateTime time = DateTime.Now;
            //date.TimeOfDay
            List<string> lists = (List<string>)this.Tag;
            if (lists.Count <= 0) return;
            foreach (var identifier in lists)
            {
                success = data.Update_Data("car", $"`is_sold` = 1", $"`identifier` = '{identifier}'");
                //{ Properties.Settings.Default.staff_id}
                data.Write_Data("sell_record", $"DEFAULT, '{date.Year}-{date.Month}-{date.Day}', '{time.Hour}:{time.Minute}:{time.Second}', 1, '{customer_national_id}' ,'{identifier}', 0, 0, 'null'");
            }
            if(success) MessageBox.Show("Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                MessageBox.Show("Something gone wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion
    }

}
