using CarSellerShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Car : Form
    {
        private string identifier;
        private bool update = false;
        private string image = "";
        private DataTable result;
        private Data_IO data;

        public frm_Car()
        {
            InitializeComponent();
            cmb_Type.SelectedIndex = 2;
            cmb_Status.SelectedIndex = 0;
        }
        public frm_Car(string identifier, bool update = false)
        {
            InitializeComponent();
            this.update = update;
            this.identifier = identifier;
            txt_Identifier.Enabled = false;
            result = data.Read_Data(col: "`identifier`, `model_name`, `color`, `create_year`, `image`, `car_status`, `car_type`, `price`", 
                                    table: "`car`",
                                    conditionStatement: $"WHERE identifier = {identifier}");
            txt_Identifier.TextValue = result.Rows[0][0].ToString();
            txt_Model.TextValue = result.Rows[0][1].ToString();
            txt_Color.TextValue = result.Rows[0][2].ToString();
            txt_CreateYear.TextValue = result.Rows[0][3].ToString();
            // 4 image
            pic_BrowseImage.ImageLocation = result.Rows[0][4].ToString();
            if(result.Rows[0][5].ToString().ToLower()  == "original")
            {
                cmb_Status.SelectedIndex = 0;
            }
            else
            {
                cmb_Status.SelectedIndex = 1;
            }

            if(result.Rows[0][6].ToString().ToLower() == "family")
            {
                cmb_Type.SelectedIndex = 2;
            }
            else if(result.Rows[0][6].ToString().ToLower() == "bus")
            {
                cmb_Type.SelectedIndex = 1;
            }
            else
            {
                cmb_Type.SelectedIndex = 0;
            }

            txt_Price.TextValue = result.Rows[0][7].ToString();

        }


        #region -> Event

        private void pic_Image_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this image?", "Change Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pic_Image.ImageLocation = "";
                image = "";
                panel_BrowseImage.Visible = true;
            }
        }

        private void BrowseImage(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            data = new Data_IO();
            //`identifier`, `model_name`, `color`, `create_year`, `image`, `car_status`, `car_type`, `price`
            if (!update)
            {
                if(MessageBox.Show("Do you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string image_path = data.SaveImage(image);
                    bool save_success = false;
                    save_success = data.Write_Data(table: "car",
                                    dataToInsert: $"'{txt_Identifier.TextValue}'," +
                                    $"'{txt_Model.TextValue}'," +
                                    $"'{txt_Color.TextValue}'," +
                                    $"{txt_CreateYear}," +
                                    $"'{image_path}'," +
                                    $"{cmb_Status.SelectedIndex + 1}," +
                                    $"{cmb_Type.SelectedIndex + 1}," +
                                    $"{txt_Price.TextValue}"+
                                    $"FALSE");
                    if (save_success)
                    {
                        MessageBox.Show("Save!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Model.TextValue = "";
                        txt_Color.TextValue = "";
                        txt_CreateYear.TextValue = "";
                        image_path = "";
                        cmb_Type.SelectedIndex = 2;
                        cmb_Status.SelectedIndex = 0;
                        txt_Price.TextValue = "";
                        panel_BrowseImage.Visible = true;
                        panel_BrowseImage.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Some information are missing or Incorrect format!", "Something gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if(MessageBox.Show("Do you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string image_path = data.SaveImage(image);
                    bool update_success = false;
                    update_success = data.Update_Data(table: "car",
                                     //identifier, model_name, color, create_year, image, car_status, car_type, price, is_sold
                                     col_Value: $"`model_name` = '{txt_Model.TextValue}'" +
                                         $"`color` = '{txt_Color.TextValue}'" +
                                         $"`create_year` = {txt_CreateYear.TextValue}" +
                                         $"`image` = '{image_path}'" +
                                         $"`car_status` = {cmb_Status.SelectedIndex + 1}" +
                                         $"`car_type` = {cmb_Type.SelectedIndex + 1}" +
                                         $"`price` = {txt_Price.TextValue}",
                                     condition: $"WHERE identifier = {identifier}");
                    if (update_success)
                    {
                        MessageBox.Show("Update!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_Model.TextValue = "";
                        txt_Color.TextValue = "";
                        txt_CreateYear.TextValue = "";
                        image_path = "";
                        cmb_Type.SelectedIndex = 2;
                        cmb_Status.SelectedIndex = 0;
                        txt_Price.TextValue = "";
                        panel_BrowseImage.Visible = true;
                        panel_BrowseImage.Enabled = true;
                    }

                    else
                    {
                        MessageBox.Show("Some information are missing or Incorrect format!", "Something gone wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
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


        #endregion

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frm_Product().ShowDialog();
        }
    }
}
