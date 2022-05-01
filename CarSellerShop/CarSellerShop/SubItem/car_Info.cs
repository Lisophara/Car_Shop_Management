using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSellerShop.SubItem
{
    [ToolboxItem(false)]
    public partial class car_Info : UserControl
    {
        DataRow data;
        RowStyle rowStyle;

        public car_Info()
        {
            InitializeComponent();

            // <----- Front display event ----->
            pic_Car.MouseClick += Hide_MouseClick;
            panel_Image.MouseClick += Hide_MouseClick;
            model.MouseClick += Hide_MouseClick;
            lb_Model.MouseClick += Hide_MouseClick;

            // <----- Back display event ----->
            panel_Info.MouseClick += Show_MouseClick;
            status.MouseClick += Show_MouseClick;
            lb_Status.MouseClick += Show_MouseClick;
            year.MouseClick += Show_MouseClick;
            lb_Year.MouseClick += Show_MouseClick;
            color.MouseClick += Show_MouseClick;
            lb_Color.MouseClick += Show_MouseClick;
            price.MouseClick += Show_MouseClick;
            lb_price.MouseClick += Show_MouseClick;
            identifier.MouseClick += Show_MouseClick;
            lb_Identifier.MouseClick += Show_MouseClick;

        }

        private void Show_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
            if (e.Button != MouseButtons.Left) return;
            Show();
        }

        private void Hide_MouseClick(object sender, MouseEventArgs e)
        {
            this.OnMouseClick(e);
            if (e.Button != MouseButtons.Left) return;
            Hide();
        }
        #region -> Function
        private void Hide()
        {
            panel_Image.Visible = false;
        }

        private void Show()
        {
            panel_Image.Visible = true;
        }



        #endregion

        private void car_Info_Load(object sender, EventArgs e)
        {
            data = (DataRow)this.Tag;

            lb_Identifier.Text = data[0].ToString();
            lb_Model.Text = data[1].ToString();
            lb_Color.Text = data[2].ToString();
            lb_Year.Text = data[3].ToString();
            pic_Car.ImageLocation = data[4].ToString();
            lb_Status.Text = data[5].ToString();
            lb_price.Text = data[6].ToString();
        }
    }
}
