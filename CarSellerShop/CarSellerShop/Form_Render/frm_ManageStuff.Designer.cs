
namespace CarSellerShop.Form_Render
{
    partial class frm_ManageStuff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ManageStuff));
            this.tb_StuffInfo = new System.Windows.Forms.TableLayoutPanel();
            this.panel_HeadWrapper = new CarSellerShop.Custom.CustomPanel();
            this.txt_Search = new CarSellerShop.RJControls.RJTextBox();
            this.panel_Head = new CarSellerShop.Custom.CustomPanel();
            this.lb_Management_staff = new System.Windows.Forms.Label();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.btn_AddStuff = new CustomControls.IconButton();
            this.panel_HeadWrapper.SuspendLayout();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_StuffInfo
            // 
            this.tb_StuffInfo.ColumnCount = 2;
            this.tb_StuffInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_StuffInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_StuffInfo.Location = new System.Drawing.Point(20, 100);
            this.tb_StuffInfo.Name = "tb_StuffInfo";
            this.tb_StuffInfo.RowCount = 2;
            this.tb_StuffInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_StuffInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tb_StuffInfo.Size = new System.Drawing.Size(970, 480);
            this.tb_StuffInfo.TabIndex = 1;
            // 
            // panel_HeadWrapper
            // 
            this.panel_HeadWrapper.BorderColor = System.Drawing.Color.Transparent;
            this.panel_HeadWrapper.BorderRadius = 0;
            this.panel_HeadWrapper.BorderSize = 0;
            this.panel_HeadWrapper.Color = System.Drawing.Color.White;
            this.panel_HeadWrapper.Color1 = System.Drawing.Color.White;
            this.panel_HeadWrapper.ColorAngle = 45;
            this.panel_HeadWrapper.Controls.Add(this.txt_Search);
            this.panel_HeadWrapper.Controls.Add(this.panel_Head);
            this.panel_HeadWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_HeadWrapper.Location = new System.Drawing.Point(0, 0);
            this.panel_HeadWrapper.MoveForm = this;
            this.panel_HeadWrapper.Name = "panel_HeadWrapper";
            this.panel_HeadWrapper.Padding = new System.Windows.Forms.Padding(20);
            this.panel_HeadWrapper.Size = new System.Drawing.Size(991, 80);
            this.panel_HeadWrapper.TabIndex = 0;
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Search.BorderFocusColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Search.BorderRadius = 10;
            this.txt_Search.BorderSize = 2;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Search.Location = new System.Drawing.Point(330, 24);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = false;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.OnlyNumeric = false;
            this.txt_Search.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Search.PasswordChar = false;
            this.txt_Search.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Search.PlaceholderText = "Search ID / National ID";
            this.txt_Search.Size = new System.Drawing.Size(330, 32);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.Texts = "";
            this.txt_Search.TextValue = "";
            this.txt_Search.UnderlinedStyle = false;
            this.txt_Search._TextChanged += new System.EventHandler(this.txt_Search__TextChanged);
            // 
            // panel_Head
            // 
            this.panel_Head.BorderColor = System.Drawing.Color.Transparent;
            this.panel_Head.BorderRadius = 0;
            this.panel_Head.BorderSize = 0;
            this.panel_Head.Color = System.Drawing.Color.White;
            this.panel_Head.Color1 = System.Drawing.Color.White;
            this.panel_Head.ColorAngle = 45;
            this.panel_Head.Controls.Add(this.lb_Management_staff);
            this.panel_Head.Controls.Add(this.pic_back);
            this.panel_Head.Controls.Add(this.pic_search);
            this.panel_Head.Controls.Add(this.btn_AddStuff);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Head.Location = new System.Drawing.Point(20, 20);
            this.panel_Head.MoveForm = this;
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(951, 40);
            this.panel_Head.TabIndex = 1;
            // 
            // lb_Management_staff
            // 
            this.lb_Management_staff.AutoSize = true;
            this.lb_Management_staff.BackColor = System.Drawing.Color.Transparent;
            this.lb_Management_staff.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Management_staff.Location = new System.Drawing.Point(100, 6);
            this.lb_Management_staff.Name = "lb_Management_staff";
            this.lb_Management_staff.Size = new System.Drawing.Size(161, 29);
            this.lb_Management_staff.TabIndex = 1;
            this.lb_Management_staff.Text = "Manage Staff";
            this.lb_Management_staff.Click += new System.EventHandler(this.lb_Management_staff_Click);
            // 
            // pic_back
            // 
            this.pic_back.BackColor = System.Drawing.Color.Transparent;
            this.pic_back.Image = ((System.Drawing.Image)(resources.GetObject("pic_back.Image")));
            this.pic_back.Location = new System.Drawing.Point(3, 3);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(34, 33);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_back.TabIndex = 1;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.Transparent;
            this.pic_search.Image = ((System.Drawing.Image)(resources.GetObject("pic_search.Image")));
            this.pic_search.Location = new System.Drawing.Point(656, 4);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(34, 33);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search.TabIndex = 1;
            this.pic_search.TabStop = false;
            this.pic_search.Click += new System.EventHandler(this.pic_search_Click);
            // 
            // btn_AddStuff
            // 
            this.btn_AddStuff.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_AddStuff.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btn_AddStuff.BorderRadius = 15;
            this.btn_AddStuff.BorderSize = 0;
            this.btn_AddStuff.ButtonImage = null;
            this.btn_AddStuff.ClickColor = System.Drawing.Color.DeepPink;
            this.btn_AddStuff.EnableImage = false;
            this.btn_AddStuff.FlatAppearance.BorderSize = 0;
            this.btn_AddStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddStuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddStuff.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddStuff.HoverColor = System.Drawing.Color.BlueViolet;
            this.btn_AddStuff.ImageX = 0;
            this.btn_AddStuff.Location = new System.Drawing.Point(804, 5);
            this.btn_AddStuff.MarginFromImage = 0;
            this.btn_AddStuff.Name = "btn_AddStuff";
            this.btn_AddStuff.OnClickEvent = false;
            this.btn_AddStuff.OnHoverEvent = false;
            this.btn_AddStuff.Size = new System.Drawing.Size(133, 30);
            this.btn_AddStuff.SizeOfImage = 30;
            this.btn_AddStuff.TabIndex = 0;
            this.btn_AddStuff.Text = "Add Stuff";
            this.btn_AddStuff.TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AddStuff.TextValueAlign = CarSellerShop.Data.TextAlignment.CENTER;
            this.btn_AddStuff.UseVisualStyleBackColor = false;
            this.btn_AddStuff.Click += new System.EventHandler(this.btn_AddStuff_Click);
            // 
            // frm_ManageStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 581);
            this.Controls.Add(this.tb_StuffInfo);
            this.Controls.Add(this.panel_HeadWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ManageStuff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ManageStuff";
            this.panel_HeadWrapper.ResumeLayout(false);
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom.CustomPanel panel_HeadWrapper;
        private Custom.CustomPanel panel_Head;
        private CustomControls.IconButton btn_AddStuff;
        private RJControls.RJTextBox txt_Search;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.Label lb_Management_staff;
        private System.Windows.Forms.TableLayoutPanel tb_StuffInfo;
    }
}