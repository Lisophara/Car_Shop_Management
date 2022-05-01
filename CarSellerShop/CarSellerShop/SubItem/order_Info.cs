using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CustomControls;
using System.ComponentModel;

namespace CarSellerShop.SubItem
{
    [ToolboxItem(false)]
    public partial class order_Info : UserControl
    {
        [Browsable(false)]
        public string identify { get; set; }

        public order_Info(string carInfo)
        {
            InitializeComponent();
            string[] data = carInfo.Split(',');
            lb_ID.Text = data[0];
            lb_Model.Text = data[1];
        }
    }
}
