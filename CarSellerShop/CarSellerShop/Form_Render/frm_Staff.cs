using System;
using System.Windows.Forms;
using CarSellerShop.Data;
using System.Data;
using System.Drawing;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Staff : Form
    {

        #region -> Variable

        private string image = "";
        private string imageDes = "Image/Staffs";
        private Data_IO data = new Data_IO();
        private DataTable result;
        private bool update = false;
        private string id;
        #endregion

        public frm_Staff()
        {
            InitializeComponent();

            //result = data.Read_Data(col: "`dob`", table: "`stuff_info`", conditionStatement: "WHERE stuff_id = 1");

        }

        public frm_Staff(string id, bool update = false)
        {
            InitializeComponent();
            this.update = update;
            this.id = id;
            btn_Action.Text = "Update";
            result = data.Read_Data(col: "`stuff_first_name`, `stuff_last_name`, `national_id`, `dob`, `stuff_addr`, `stuff_phone_num`, `stuff_gender`, `stuff_state_name`, `stuff_image_path`",
                table: "`stuff_info` st",
                joinStatement: "JOIN `stuff_state` stt ON st.stuff_state_id = stt.stuff_state_id",
                conditionStatement: $"WHERE `stuff_id` = {id}");

            txt_FirstName.TextValue = result.Rows[0][0].ToString();
            txt_LastName.TextValue = result.Rows[0][1].ToString();
            txt_NationalID.TextValue = result.Rows[0][2].ToString();
            dp_Dob.Value = DateTime.Parse(result.Rows[0][3].ToString());
            txt_Address.TextValue = result.Rows[0][4].ToString();
            txt_Phone.TextValue = result.Rows[0][5].ToString();
            if(result.Rows[0][6].ToString() == "M")
            {
                cmb_Gender.SelectedIndex = 0;
            }
            else
            {
                cmb_Gender.SelectedIndex = 1;
            }
            if(result.Rows[0][7].ToString().ToLower() == "editor")
            {
                cmb_Role.SelectedIndex = 1;
            }
            else
            {
                cmb_Role.SelectedIndex = 0;
            }
            if (result.Rows[0][8].ToString() != "")
            {
                panel_BrowseImage.Visible = false;
                pic_Image.ImageLocation = result.Rows[0][8].ToString();
            }

        }

        #region -> Event

        private void frm_AddStuff_Load(object sender, EventArgs e)
        {
            cmb_Gender.SelectedIndex = 0;
            cmb_Role.SelectedIndex = 0;
        }

        private void BrowseImage_Click(object sender, EventArgs e)
        {
            BrowseImage();
        }

        private void pic_Image_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to change this image?", "Change Image",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                pic_Image.ImageLocation = "";
                image = "";
                panel_BrowseImage.Visible = true;
            }
        }

        private void btn_Action_Click(object sender, EventArgs e)
        {
            char gender;
            int role;
            string day = dp_Dob.Value.Day.ToString();
            string mounth = dp_Dob.Value.Month.ToString();
            string year = dp_Dob.Value.Year.ToString();
            
            gender = cmb_Gender.SelectedIndex == 0 ? 'M' : 'F';
            role = cmb_Role.SelectedIndex == 0 ? 3 : 2;

            if (txt_FirstName.TextValue == "" || txt_LastName.TextValue == "" || txt_Phone.TextValue == "" || pic_Image.Image == null ||
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

            if (!update)
            {
                if (MessageBox.Show("Do you want to save this record?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string image_path = data.SaveImage(image);
                    bool save_success = false;
                    save_success = data.Write_Data(table: "`stuff_info`",
                            dataToInsert: $"DEFAULT, " +
                            $"'{txt_NationalID.TextValue}', " +
                            $"'{txt_FirstName.TextValue}', " +
                            $"'{txt_LastName.TextValue}', " +
                            $"'{gender}', " +
                            $"DATE('{year}-{mounth}-{day}'), " +
                            $"'{txt_Phone.TextValue}', " +
                            $"'{txt_Address.TextValue}', " +
                            $"'{image_path}', " +
                            $"{role}, " +
                            $"DEFAULT");
                    if (save_success)
                    {
                        MessageBox.Show("Saved!", "Save Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_FirstName.TextValue = "";
                        txt_LastName.TextValue = "";
                        txt_NationalID.TextValue = "";
                        txt_Address.TextValue = "";
                        txt_Phone.TextValue = "";
                        dp_Dob.Value = new DateTime(2000, 1, 1);
                        cmb_Gender.SelectedIndex = 0;
                        cmb_Role.SelectedIndex = 0;
                        image = "";
                        image_path = "";
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
                if (MessageBox.Show("Do you want to update this record?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string image_path = data.SaveImage(image);
                    bool update_success = false;
                    //stuff_id, national_id, stuff_first_name, stuff_last_name, stuff_gender, dob, stuff_phone_num, stuff_addr, stuff_image_path, stuff_state_id, is_deleted

                    update_success = data.Update_Data(table: "stuff_info",
                                col_Value:
                                $"`national_id` = '{txt_NationalID.TextValue}', " +
                                $"`stuff_first_name` = '{txt_FirstName.TextValue}', " +
                                $"`stuff_last_name` = '{txt_LastName.TextValue}', " +
                                $"`stuff_gender` = '{gender}', " +
                                $"`dob` = DATE('{year}-{mounth}-{day}'), " +
                                $"`stuff_phone_num` = '{txt_Phone.TextValue}', " +
                                $"`stuff_addr` = '{txt_Address.TextValue}', " +
                                $"`stuff_image_path` = '{image_path}', " +
                                $"`stuff_state_id` = {role}, ",
                                condition: $"WHERE stuff_id = {id}");
                    if (update_success)
                    {
                        MessageBox.Show("Update!", "Update Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_FirstName.TextValue = "";
                        txt_LastName.TextValue = "";
                        txt_NationalID.TextValue = "";
                        txt_Address.TextValue = "";
                        txt_Phone.TextValue = "";
                        dp_Dob.Value = new DateTime(2000, 1, 1);
                        cmb_Gender.SelectedIndex = 0;
                        cmb_Role.SelectedIndex = 0;
                        image = "";
                        image_path = "";
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

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frm_ManageStaff().ShowDialog();
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
