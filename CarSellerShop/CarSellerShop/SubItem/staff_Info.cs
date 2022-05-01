using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;

namespace CarSellerShop.SubItem
{
    [ToolboxItem(false)]
    public partial class staff_Info : UserControl
    {
        DataRow data;
        public staff_Info()
        {
            InitializeComponent();
            this.MinimumSize = new Size(460, 460);
            this.MaximumSize = new Size(460, 460);
            this.BackColor = Color.FromArgb(20,195, 195, 195);

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //this.Tag = data[0].ToString();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            //this.Tag = data[0].ToString();
        }

        private void stuff_info_Load(object sender, EventArgs e)
        {
            OnLoadData();
            RenderData();
        }

        private void OnLoadData()
        {
            if(this.Tag == null)
            {
                return;
            }
            data = (DataRow)this.Tag;
            panel_InfoWrapper.Tag = data[0].ToString();
        }

        private void RenderData()
        {
            lb_Id.Text = data[0].ToString();
            lb_FullName.Text = data[1].ToString();
            lb_Address.Text = data[2].ToString();
            lb_Gender.Text = data[3].ToString();
            lb_Phone.Text = data[4].ToString();
            lb_Role.Text = data[5].ToString();
            lb_Nation_ID.Text = $"# {data[7]}";
            pic_profile.ImageLocation = data[6].ToString();

        }
    }
}
