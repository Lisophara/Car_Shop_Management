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
    public partial class frm_AddCar : Form
    {
        private string identifier;
        private bool update = false;
        private string image = "";
        private string imageDes = "Image/Car";
        private DataTable result;
        private Data_IO data;

        public frm_AddCar()
        {
            InitializeComponent();
            cmb_Type.SelectedIndex = 2;
            cmb_Status.SelectedIndex = 0;
        }
        public frm_AddCar(string identifier, bool update = false)
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
            //`identifier`, `model_name`, `color`, `create_year`, `image`, `car_status`, `car_type`, `price`
            string image_path = data.SaveImage(image, imageDes);
            if (!update)
            {
                bool success = data.Write_Data(table: "car",
                                dataToInsert: $"'{txt_Identifier.TextValue}'," +
                                $"'{txt_Model.TextValue}'," +
                                $"'{txt_Color.TextValue}'," +
                                $"{txt_CreateYear}," +
                                $"'{image_path}'," +
                                $"{cmb_Status.SelectedIndex + 1}," +
                                $"{cmb_Type.SelectedIndex + 1}," +
                                $"{txt_Price.TextValue}");
                if (success)
                {
                    MessageBox.Show("Add ")
                }
                else
                {

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

    }
}
