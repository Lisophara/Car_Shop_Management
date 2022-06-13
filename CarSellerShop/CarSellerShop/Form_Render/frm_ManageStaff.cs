using System;
using System.Data;
using System.Windows.Forms;
using CarSellerShop.Data;
using CarSellerShop.SubItem;
using System.Linq;
using CarSellerShop.Custom;

namespace CarSellerShop.Form_Render
{
    public partial class frm_ManageStaff : Form
    {
        #region -> Variable

        private Data_IO data = new Data_IO();
        private DataTable result = new DataTable();
        private staff_Info info;
        private RowStyle rowStyle = new RowStyle();
        private TableLayoutRowStyleCollection setRowStyle;

        private string query_col = "st.stuff_id AS ID, CONCAT(st.stuff_first_name, ' ', st.stuff_last_name) AS 'Full Name', " +
            "st.stuff_addr AS Address, st.stuff_gender AS Gender, " +
            "st.stuff_phone_num AS Phone, stt.stuff_state_name AS Role, " +
            "st.stuff_image_path AS Image," +
            "st.national_id";
        private string query_table = "`stuff_info` st";
        private string query_join = " JOIN `stuff_state` stt ON st.stuff_state_id = stt.stuff_state_id";

        #endregion

        public frm_ManageStaff()
        {
            InitializeComponent();
            Load();
            txt_Search.Visible = false;
            txt_Search.Enabled = false;
            txt_Search.PlaceholderText = "Search ID / National ID";
        }

        #region -> Load Data

        private void Load()
        {
            result = data.Read_Data(col: query_col,
                table: query_table,
                joinStatement: query_join,
                conditionStatement: "WHERE `is_deleted` IS NOT TRUE",
                sort:"ORDER BY `stuff_id` ASC");
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                int row = 0, col = 0;

                tb_StuffInfo.Controls.Clear();

                tb_StuffInfo.AutoScroll = false;
                // disable horizontal scrollbar
                tb_StuffInfo.HorizontalScroll.Enabled = false;
                // restore AutoScroll
                tb_StuffInfo.AutoScroll = true;
                
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = 480;
                setRowStyle = tb_StuffInfo.RowStyles;
                setRowStyle.Clear();
                setRowStyle.Add(rowStyle);

                for (int i = 0; i < result.Rows.Count; i++)
                {
                    if(Properties.Settings.Default.staff_id != "1" && i == 0)
                    {
                        continue;
                    }
                    info = new staff_Info();
                    info.Tag = result.Rows[i];
                    info.btn_Delete.Click += (sender, e) =>
                    {
                        if(MessageBox.Show("Do you want to delete this information?", "Delete Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if(data.Delete("`stuff_info`", "`stuff_id`", (string)(((ShadowRoundButton)sender).Parent).Tag))
                            {
                                Load();
                                MessageBox.Show("Information success deleted!", "Success", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Delete fail!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    };
                    info.btn_Edit.Click += (sender, e) =>
                    {
                        this.Visible = false;
                        new frm_Staff((string)(((ShadowRoundButton)sender).Parent).Tag, true).ShowDialog();
                        this.Dispose();
                    };
                    tb_StuffInfo.Controls.Add(info, col, row);
                    if (i % 2 == 0 && i != 0)
                    {
                        row++;
                        col = 0;
                    }
                    else
                    {
                        col++;
                    } 
                }
            }
            catch (Exception) 
            {
                MessageBox.Show("Can not load data!", "Load Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region -> Event

        private void txt_Search__TextChanged(object sender, EventArgs e)
        {
            int a;
            string search = "";
            if(txt_Search.TextValue != "")
            {
                try
                {
                    char[] txt = txt_Search.TextValue.ToCharArray();
                    if (txt[0] == '#')
                    {
                        search = $"AND st.national_id LIKE '{txt_Search.TextValue.Replace('#', ' ').Trim()}%'";
                    }
                    else if (int.TryParse(txt_Search.TextValue, out a))
                    {
                        search = $"AND st.stuff_id LIKE '{txt_Search.TextValue}%'";
                        
                    }
                    else
                    {
                        if(txt_Search.TextValue.Contains(" ") && txt_Search.TextValue.Count(f => (f == ' ')) == 1)
                        {
                            string[] split = txt_Search.TextValue.Split(' ');
                            search = $"AND st.stuff_first_name LIKE '{split[0]}%' AND st.stuff_last_name LIKE '{split[1]}%'";
                        }
                        else if(txt_Search.TextValue.Count(f => (f == ' ')) == 0)
                        {
                            search = $"AND st.stuff_first_name LIKE '{txt_Search.TextValue}%'";
                        }
                    }
                }
                catch (Exception)
                {
                    search = "";
                }
                finally
                {
                    result = data.Read_Data(col: query_col,
                        table: query_table,
                        joinStatement: query_join,
                        conditionStatement: $"WHERE `is_deleted` IS NOT TRUE {search} AND st.stuff_state_id <> 1");
                    LoadData();
                }
            }
        }

        private void pic_search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Enabled)
            {
                txt_Search.Visible = false;
                txt_Search.Enabled = false;
            }
            else
            {
                txt_Search.Visible = true;
                txt_Search.Enabled = true;
            }
        }

        private void btn_AddStuff_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new frm_Staff().ShowDialog();
        }

        private void lb_Management_staff_Click(object sender, EventArgs e)
        {
            tb_StuffInfo.Controls.Clear();
            Load();
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frm_Product().Visible = true;
        }

        #endregion
    }
}
