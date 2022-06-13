using System;
using System.Drawing;
using System.Windows.Forms;
using CarSellerShop.SubItem;
using CarSellerShop.Data;
using System.Data;
using System.Collections.Generic;
using CustomControls;
using System.Diagnostics;

namespace CarSellerShop.Form_Render
{
    public partial class frm_Product : Form
    {

        #region -> Variable

        private Timer timer = new Timer();
        private Image image = new Bitmap("Design/ShowArrow.png");
        private Data_IO data = new Data_IO();
        private DataTable staff_info;
        private DataTable result;
        private car_Info carInfo;
        private order_Info order;
        private List<string> orderList = new List<string>();
        private bool isHide = true;
        private int slideSize = 15;
        private int orderCount = 1;
        decimal price = 0;
        // Milisecond
        private int speed = 10;

        #endregion

        public frm_Product()
        {
            InitializeComponent();
            //this.Tag = "1";
            StaffInfo();
            AllowMethod(staff_info.Rows[0][2].ToString());
            pic_ToggleMenu.Image = image;
            txt_Search.PlaceholderText = "Identifier / Name";
            Load();
            timer.Interval = speed;
            timer.Tick += Timer_Tick;
        }

        #region -> Event

        private void Timer_Tick(object sender, EventArgs e)
        {
            // <----- For show ----->
            if (panel_StuffInfo.Width <= 300 && panel_StuffInfo.Width >= 60 && isHide == true)
            {
                panel_StuffInfo.Width += slideSize;
                btn_Bills.Width += slideSize;
                btn_Histories.Width += slideSize;
                btn_Logout.Width += slideSize;
                btn_Staff.Width += slideSize;
                btn_AddNewCar.Width += slideSize;

                if (panel_StuffInfo.Width >= 120)
                {
                    pic_staff.Location = new Point(6, 6);
                    pic_staff.Width = 120;
                    pic_staff.Height = 120;
                    lb_FullName.Visible = true;
                    lb_Role.Visible = true;
                    btn_Histories.Text = "Histories";
                    btn_Bills.Text = "Bills";
                    btn_Logout.Text = "Logout";
                    btn_Staff.Text = "New Staff";
                    btn_AddNewCar.Text = "Add New Car";
                }

                pic_ToggleMenu.Location = new Point(pic_ToggleMenu.Location.X + slideSize, pic_ToggleMenu.Location.Y);
                panel_StuffInfo.Invalidate();
                panel_bar.Invalidate();
            }

            if (panel_StuffInfo.Width >= 300 && isHide == true)
            {
                panel_StuffInfo.Width = 300;
                timer.Enabled = false;
                isHide = false;
            }

            // <----- For hide ----->

            if (panel_StuffInfo.Width <= 300 && panel_StuffInfo.Width > 60 && isHide == false)
            {
                panel_StuffInfo.Width -= slideSize;
                btn_Bills.Width -= slideSize;
                btn_Histories.Width -= slideSize;
                btn_Logout.Width -= slideSize;
                btn_Staff.Width -= slideSize;
                btn_AddNewCar.Width -= slideSize;

                if (panel_StuffInfo.Width <= 120)
                {
                    pic_staff.Location = new Point(0, 30);
                    pic_staff.Width = panel_StuffInfo.Width;
                    pic_staff.Height = panel_StuffInfo.Width;
                    btn_Histories.Text = "";
                    btn_Bills.Text = "";
                    btn_Logout.Text = "";
                    btn_Staff.Text = "";
                    btn_AddNewCar.Text = "";
                }
                else if(panel_StuffInfo.Width <= 210)
                {
                    lb_FullName.Visible = false;
                    lb_Role.Visible = false;

                }
                pic_ToggleMenu.Location = new Point(pic_ToggleMenu.Location.X - slideSize, pic_ToggleMenu.Location.Y);
            }
            
            if (panel_StuffInfo.Width <= 60 && isHide == false)
            {
                panel_StuffInfo.Width = 60;
                timer.Enabled = false;
                isHide = true;
            }

            if( panel_StuffInfo.Width <= 150)
            {
                image = new Bitmap("Design/ShowArrow.png");
            }
            else
            {
                image = new Bitmap("Design/HideArrow.png");
            }
            pic_ToggleMenu.Image = image; 
        }

        // Use for close the form
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Use for minimize the form
        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Logout_MouseUp(object sender, MouseEventArgs e)
        {
            Properties.Settings.Default.staff_id = "";
            Properties.Settings.Default.Save();
            this.Dispose();
            new frm_Login().Visible = true;
        }

        private void pic_ToggleMenu_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
        }

        private void btn_Histories_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("This feature is under Maintain!", "Maintain feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Bills_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("This feature is under Maintain!", "Maintain feature", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Staff_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
            new frm_ManageStaff().ShowDialog();
        }

        private void btn_AddNewCar_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
            new frm_Car().ShowDialog();
        }

        private void txt_Search__TextChanged(object sender, EventArgs e)
        {
            if (txt_Search.TextValue == "") { Load(); return; }
            string search;
            char[] searchData = txt_Search.TextValue.ToCharArray();
            if(searchData[0] == '#')
            {
                search = $"AND LOWER(`identifier`) LIKE '{txt_Search.TextValue.Replace('#', ' ').Trim().ToLower()}%'";
            }
            else
            {
                search = $"AND LOWER(`model_name`) LIKE '{txt_Search.TextValue.Trim().ToLower()}%'";
            }
            Load($"WHERE `is_sold` IS NOT TRUE {search}");
        }

        private void panel_Charge_Click(object sender, EventArgs e)
        {
            if(orderList.Count <= 0)
            {
                MessageBox.Show("Please select items first!", "No items selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            //this.Dispose();
            var frm = new frm_Sell();
            frm.Tag = orderList;
            frm.ShowDialog();
            Load();
            panel_OrderLists.Controls.Clear();
            panel_OrderLists.Height = 50;

        }
        #endregion

        #region -> Function

        // Load data for car_Info
        private void Load(string condition = "WHERE `is_sold` IS NOT TRUE")
        {
            result = data.Read_Data(col: "`identifier`, `model_name`, `color`, `create_year`, `image`, `car_status`, `price`",
                table: "`car`",
                condition
                );

            OnLoad();
        }

        // Add car_Info to TableLayout
        private void OnLoad()
        {
            if (result.Rows.Count == 0) return;
            try
            {
                int row = 1, col = 1;
                bool firstLoad = true;

                // <----- Clear Tablelayout ----->
                tb_Car.Controls.Clear();

                tb_Car.AutoScroll = false;
                // disable horizontal scrollbar
                tb_Car.HorizontalScroll.Enabled = false;
                // restore AutoScroll
                tb_Car.AutoScroll = true;

                // <----- Set row to Tablelayout ----->
                if (result.Rows.Count == 0) return;
                tb_Car.RowCount = result.Rows.Count / 3 * 2;

                // <----- Set style to TableLayout ----->
                TableLayoutRowStyleCollection setRowStyle = tb_Car.RowStyles;
                for (int i = 1; i <= result.Rows.Count; i++)
                {
                    RowStyle rowStyle = new RowStyle();
                    rowStyle.SizeType = SizeType.Absolute;
                    if (i % 2 == 0)
                    {
                        rowStyle.Height = 20;
                    }
                    else
                    {
                        rowStyle.Height = 221;
                    }
                    setRowStyle.Add(rowStyle);
                    
                    carInfo = new car_Info();
                    carInfo.Tag = result.Rows[i - 1];
                    carInfo.MouseClick += (sender, e) =>
                    {
                        price = 0;
                        string identifier = ((DataRow)((car_Info)sender).Tag)[0].ToString();
                        if (orderList.Contains(identifier)) return;
                        if (e.Button != MouseButtons.Right) return;
                        orderList.Add(identifier);
                        order = new order_Info($"{orderCount++},{((DataRow)((car_Info)sender).Tag)[1]}");
                        order.Tag = identifier;
                        order.btn_Delete.MouseUp += (senderOrder, eOrder) =>
                        {
                            price = 0;
                            string currentIdentifier = (string)((IconButton)senderOrder).Parent.Tag;
                            orderList.Remove(currentIdentifier);
                            foreach (var item in orderList)
                            {
                                price = Decimal.Add(price, getPrice(item));
                                lb_Charge.Text = "$" + price.ToString();
                                lb_SubTotal.Text = lb_Charge.Text;
                            }
                            lb_Charge.Text = "$" + price.ToString();
                            if (panel_OrderLists.Controls.Count > 1)
                            {
                                panel_OrderLists.Height -= 50;
                            }
                            ((IconButton)senderOrder).Parent.Dispose();
                            foreach (var item in orderList)
                            {
                                Debug.WriteLine(item);
                            }
                        };
                        order.Dock = DockStyle.Bottom;
                        panel_OrderLists.Controls.Add(order);
                        if(panel_OrderLists.Controls.Count > 1)
                        {
                            panel_OrderLists.Height += 50;
                        }
                        
                        foreach (var item in orderList)
                        {
                            price = Decimal.Add(price, getPrice(item));
                            lb_Charge.Text = "$" + price.ToString();
                            lb_SubTotal.Text = lb_Charge.Text;
                        }

                    };
                    tb_Car.Controls.Add(carInfo, col, row);
                    if (i % 3 == 0)
                    {
                        row += 2;
                        col = 1;
                    }
                    else
                    {
                        col += 2;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurred!", "Something gone wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Allow some method depend on staff Role
        private void AllowMethod(string role)
        {
            if(role.ToLower().Equals("cashier")){
                btn_Staff.Visible = false;
                btn_Staff.Enabled = false;

                btn_AddNewCar.Visible = false;
                btn_AddNewCar.Enabled = false;
            }
        }

        private void StaffInfo()
        {
            staff_info = data.Read_Data(col: "CONCAT(st.stuff_first_name,' ', st.stuff_last_name), st.stuff_image_path, stt.stuff_state_name",
                table: "`stuff_info` st",
                joinStatement: "JOIN `stuff_state` stt ON st.stuff_state_id = stt.stuff_state_id",
                conditionStatement: $"WHERE `stuff_id` = {Properties.Settings.Default.staff_id}");

            // Show Staff data
            lb_FullName.Text = staff_info.Rows[0][0].ToString();
            pic_staff.ImageLocation = staff_info.Rows[0][1].ToString();
            lb_Role.Text = staff_info.Rows[0][2].ToString();
        }

        private decimal getPrice(string identify)
        {
            decimal price;
            string result = data.Read_Data("`price`", "`car`", conditionStatement: $"WHERE `identifier` = '{identify}'").Rows[0][0].ToString();
            Decimal.TryParse(result, out price);
            return price;
        }
        #endregion
    }
}
