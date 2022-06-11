
namespace CarSellerShop.Form_Render
{
    partial class frm_Sell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sell));
            this.panel_OrderLists = new System.Windows.Forms.Panel();
            this.panel_SellWrapper = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_BrowseImage = new System.Windows.Forms.Panel();
            this.lb_BrowseImage = new System.Windows.Forms.Label();
            this.pic_BrowseImage = new System.Windows.Forms.PictureBox();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.cmb_Gender = new CustomControls.RJControls.RJComboBox();
            this.dp_Dob = new CarSellerShop.CustomDatePicker();
            this.txt_Address = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Phone1 = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Phone = new CarSellerShop.RJControls.RJTextBox();
            this.txt_NationalID = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Lname = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Fname = new CarSellerShop.RJControls.RJTextBox();
            this.btn_Sell = new CarSellerShop.Custom.ShadowRoundButton();
            this.panel_header = new CarSellerShop.Custom.CustomPanel();
            this.btn_Minimize = new CustomControls.IconButton();
            this.btn_Close = new CustomControls.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Payment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_SellWrapper.SuspendLayout();
            this.panel_BrowseImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BrowseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_OrderLists
            // 
            this.panel_OrderLists.Location = new System.Drawing.Point(329, 62);
            this.panel_OrderLists.Name = "panel_OrderLists";
            this.panel_OrderLists.Size = new System.Drawing.Size(275, 50);
            this.panel_OrderLists.TabIndex = 51;
            // 
            // panel_SellWrapper
            // 
            this.panel_SellWrapper.Controls.Add(this.lb_Payment);
            this.panel_SellWrapper.Controls.Add(this.label11);
            this.panel_SellWrapper.Controls.Add(this.btn_Sell);
            this.panel_SellWrapper.Location = new System.Drawing.Point(329, 118);
            this.panel_SellWrapper.Name = "panel_SellWrapper";
            this.panel_SellWrapper.Size = new System.Drawing.Size(275, 97);
            this.panel_SellWrapper.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 92;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 19);
            this.label8.TabIndex = 93;
            this.label8.Text = "Day of Birth";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 95;
            this.label5.Text = "Secondary Phone";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 96;
            this.label4.Text = "Primary Phone";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "National ID";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(165, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 98;
            this.label7.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "First Name";
            // 
            // panel_BrowseImage
            // 
            this.panel_BrowseImage.BackColor = System.Drawing.Color.White;
            this.panel_BrowseImage.Controls.Add(this.lb_BrowseImage);
            this.panel_BrowseImage.Controls.Add(this.pic_BrowseImage);
            this.panel_BrowseImage.Location = new System.Drawing.Point(11, 535);
            this.panel_BrowseImage.Name = "panel_BrowseImage";
            this.panel_BrowseImage.Size = new System.Drawing.Size(226, 157);
            this.panel_BrowseImage.TabIndex = 103;
            this.panel_BrowseImage.Click += new System.EventHandler(this.BrowsImage_Click);
            // 
            // lb_BrowseImage
            // 
            this.lb_BrowseImage.AutoSize = true;
            this.lb_BrowseImage.BackColor = System.Drawing.Color.Transparent;
            this.lb_BrowseImage.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BrowseImage.Location = new System.Drawing.Point(53, 100);
            this.lb_BrowseImage.Name = "lb_BrowseImage";
            this.lb_BrowseImage.Size = new System.Drawing.Size(125, 21);
            this.lb_BrowseImage.TabIndex = 10;
            this.lb_BrowseImage.Text = "Upload Image";
            this.lb_BrowseImage.Click += new System.EventHandler(this.BrowsImage_Click);
            // 
            // pic_BrowseImage
            // 
            this.pic_BrowseImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_BrowseImage.Image")));
            this.pic_BrowseImage.Location = new System.Drawing.Point(92, 36);
            this.pic_BrowseImage.Name = "pic_BrowseImage";
            this.pic_BrowseImage.Size = new System.Drawing.Size(50, 50);
            this.pic_BrowseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_BrowseImage.TabIndex = 0;
            this.pic_BrowseImage.TabStop = false;
            this.pic_BrowseImage.Click += new System.EventHandler(this.BrowsImage_Click);
            // 
            // pic_Image
            // 
            this.pic_Image.BackColor = System.Drawing.Color.Transparent;
            this.pic_Image.Location = new System.Drawing.Point(11, 535);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(226, 157);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 102;
            this.pic_Image.TabStop = false;
            this.pic_Image.Click += new System.EventHandler(this.pic_Image_Click);
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.cmb_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Gender.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_Gender.BorderSize = 1;
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmb_Gender.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Gender.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_Gender.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmb_Gender.ListTextColor = System.Drawing.Color.DimGray;
            this.cmb_Gender.Location = new System.Drawing.Point(11, 499);
            this.cmb_Gender.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Padding = new System.Windows.Forms.Padding(1);
            this.cmb_Gender.Size = new System.Drawing.Size(295, 30);
            this.cmb_Gender.TabIndex = 101;
            this.cmb_Gender.Texts = "";
            // 
            // dp_Dob
            // 
            this.dp_Dob.Angle = 45F;
            this.dp_Dob.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dp_Dob.BorderSize = 0;
            this.dp_Dob.CalendarIcon = ((System.Drawing.Image)(resources.GetObject("dp_Dob.CalendarIcon")));
            this.dp_Dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dp_Dob.Location = new System.Drawing.Point(11, 437);
            this.dp_Dob.MinimumSize = new System.Drawing.Size(215, 35);
            this.dp_Dob.Name = "dp_Dob";
            this.dp_Dob.Size = new System.Drawing.Size(295, 35);
            this.dp_Dob.SkinColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.dp_Dob.SkinColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(194)))), ((int)(((byte)(235)))));
            this.dp_Dob.TabIndex = 100;
            this.dp_Dob.TextColor = System.Drawing.Color.White;
            // 
            // txt_Address
            // 
            this.txt_Address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Address.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Address.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Address.BorderRadius = 8;
            this.txt_Address.BorderSize = 2;
            this.txt_Address.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Address.Location = new System.Drawing.Point(13, 303);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.OnlyNumeric = false;
            this.txt_Address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Address.PasswordChar = false;
            this.txt_Address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Address.PlaceholderText = "";
            this.txt_Address.Size = new System.Drawing.Size(293, 105);
            this.txt_Address.TabIndex = 91;
            this.txt_Address.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Address.Texts = "";
            this.txt_Address.TextValue = "";
            this.txt_Address.UnderlinedStyle = false;
            // 
            // txt_Phone1
            // 
            this.txt_Phone1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Phone1.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Phone1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Phone1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Phone1.BorderRadius = 8;
            this.txt_Phone1.BorderSize = 2;
            this.txt_Phone1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Phone1.Location = new System.Drawing.Point(14, 243);
            this.txt_Phone1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone1.Multiline = false;
            this.txt_Phone1.Name = "txt_Phone1";
            this.txt_Phone1.OnlyNumeric = false;
            this.txt_Phone1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Phone1.PasswordChar = false;
            this.txt_Phone1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Phone1.PlaceholderText = "";
            this.txt_Phone1.Size = new System.Drawing.Size(293, 34);
            this.txt_Phone1.TabIndex = 90;
            this.txt_Phone1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Phone1.Texts = "";
            this.txt_Phone1.TextValue = "";
            this.txt_Phone1.UnderlinedStyle = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Phone.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Phone.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Phone.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Phone.BorderRadius = 8;
            this.txt_Phone.BorderSize = 2;
            this.txt_Phone.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Phone.Location = new System.Drawing.Point(14, 181);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Phone.Multiline = false;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.OnlyNumeric = false;
            this.txt_Phone.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Phone.PasswordChar = false;
            this.txt_Phone.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Phone.PlaceholderText = "";
            this.txt_Phone.Size = new System.Drawing.Size(293, 34);
            this.txt_Phone.TabIndex = 89;
            this.txt_Phone.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Phone.Texts = "";
            this.txt_Phone.TextValue = "";
            this.txt_Phone.UnderlinedStyle = false;
            // 
            // txt_NationalID
            // 
            this.txt_NationalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NationalID.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NationalID.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_NationalID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_NationalID.BorderRadius = 8;
            this.txt_NationalID.BorderSize = 2;
            this.txt_NationalID.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NationalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_NationalID.Location = new System.Drawing.Point(13, 62);
            this.txt_NationalID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NationalID.Multiline = false;
            this.txt_NationalID.Name = "txt_NationalID";
            this.txt_NationalID.OnlyNumeric = true;
            this.txt_NationalID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_NationalID.PasswordChar = false;
            this.txt_NationalID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_NationalID.PlaceholderText = "";
            this.txt_NationalID.Size = new System.Drawing.Size(293, 34);
            this.txt_NationalID.TabIndex = 86;
            this.txt_NationalID.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_NationalID.Texts = "";
            this.txt_NationalID.TextValue = "";
            this.txt_NationalID.UnderlinedStyle = false;
            // 
            // txt_Lname
            // 
            this.txt_Lname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Lname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Lname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Lname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Lname.BorderRadius = 8;
            this.txt_Lname.BorderSize = 2;
            this.txt_Lname.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Lname.Location = new System.Drawing.Point(164, 122);
            this.txt_Lname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Lname.Multiline = false;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.OnlyNumeric = false;
            this.txt_Lname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Lname.PasswordChar = false;
            this.txt_Lname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Lname.PlaceholderText = "";
            this.txt_Lname.Size = new System.Drawing.Size(143, 34);
            this.txt_Lname.TabIndex = 87;
            this.txt_Lname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Lname.Texts = "";
            this.txt_Lname.TextValue = "";
            this.txt_Lname.UnderlinedStyle = false;
            // 
            // txt_Fname
            // 
            this.txt_Fname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Fname.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Fname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Fname.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Fname.BorderRadius = 8;
            this.txt_Fname.BorderSize = 2;
            this.txt_Fname.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Fname.Location = new System.Drawing.Point(13, 122);
            this.txt_Fname.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Fname.Multiline = false;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.OnlyNumeric = false;
            this.txt_Fname.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Fname.PasswordChar = false;
            this.txt_Fname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Fname.PlaceholderText = "";
            this.txt_Fname.Size = new System.Drawing.Size(143, 34);
            this.txt_Fname.TabIndex = 88;
            this.txt_Fname.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Fname.Texts = "";
            this.txt_Fname.TextValue = "";
            this.txt_Fname.UnderlinedStyle = false;
            // 
            // btn_Sell
            // 
            this.btn_Sell._ButtonColor = System.Drawing.Color.MediumPurple;
            this.btn_Sell._form = this;
            this.btn_Sell._ShadowColor = System.Drawing.Color.LightGray;
            this.btn_Sell._ShadowSize = 5;
            this.btn_Sell._TextColor = System.Drawing.Color.White;
            this.btn_Sell.BackColor = System.Drawing.Color.Black;
            this.btn_Sell.FlatAppearance.BorderSize = 0;
            this.btn_Sell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sell.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Sell.Location = new System.Drawing.Point(102, 52);
            this.btn_Sell.Name = "btn_Sell";
            this.btn_Sell.Size = new System.Drawing.Size(173, 45);
            this.btn_Sell.TabIndex = 86;
            this.btn_Sell.Text = "Sell";
            this.btn_Sell.UseVisualStyleBackColor = false;
            this.btn_Sell.Click += new System.EventHandler(this.btn_Sell_Click);
            // 
            // panel_header
            // 
            this.panel_header.BorderColor = System.Drawing.Color.Transparent;
            this.panel_header.BorderRadius = 0;
            this.panel_header.BorderSize = 0;
            this.panel_header.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.panel_header.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.panel_header.ColorAngle = 45;
            this.panel_header.Controls.Add(this.btn_Minimize);
            this.panel_header.Controls.Add(this.btn_Close);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.MoveForm = this;
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(634, 30);
            this.panel_header.TabIndex = 1;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Red;
            this.btn_Minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btn_Minimize.BorderRadius = 15;
            this.btn_Minimize.BorderSize = 0;
            this.btn_Minimize.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Minimize.ButtonImage")));
            this.btn_Minimize.ClickColor = System.Drawing.Color.DeepPink;
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.EnableImage = true;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.HoverColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Minimize.ImageX = 0;
            this.btn_Minimize.Location = new System.Drawing.Point(574, 0);
            this.btn_Minimize.MarginFromImage = 0;
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.OnClickEvent = false;
            this.btn_Minimize.OnHoverEvent = false;
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.SizeOfImage = 30;
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.TextColor = System.Drawing.Color.White;
            this.btn_Minimize.TextValueAlign = CarSellerShop.Data.TextAlignment.CENTER;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Minimize_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btn_Close.BorderRadius = 15;
            this.btn_Close.BorderSize = 0;
            this.btn_Close.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Close.ButtonImage")));
            this.btn_Close.ClickColor = System.Drawing.Color.DeepPink;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.EnableImage = true;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.HoverColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Close.ImageX = 0;
            this.btn_Close.Location = new System.Drawing.Point(604, 0);
            this.btn_Close.MarginFromImage = 0;
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OnClickEvent = false;
            this.btn_Close.OnHoverEvent = false;
            this.btn_Close.Size = new System.Drawing.Size(30, 30);
            this.btn_Close.SizeOfImage = 30;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.TextColor = System.Drawing.Color.White;
            this.btn_Close.TextValueAlign = CarSellerShop.Data.TextAlignment.CENTER;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Close_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Selling";
            // 
            // lb_Payment
            // 
            this.lb_Payment.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.lb_Payment.Location = new System.Drawing.Point(58, 18);
            this.lb_Payment.Name = "lb_Payment";
            this.lb_Payment.Size = new System.Drawing.Size(217, 20);
            this.lb_Payment.TabIndex = 87;
            this.lb_Payment.Text = "$0";
            this.lb_Payment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.label11.Location = new System.Drawing.Point(4, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 88;
            this.label11.Text = "Pay :";
            // 
            // frm_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 700);
            this.Controls.Add(this.panel_BrowseImage);
            this.Controls.Add(this.pic_Image);
            this.Controls.Add(this.cmb_Gender);
            this.Controls.Add(this.dp_Dob);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_Phone1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NationalID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Lname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_SellWrapper);
            this.Controls.Add(this.panel_OrderLists);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Sell";
            this.Text = "frm_order";
            this.Load += new System.EventHandler(this.frm_Sell_Load);
            this.panel_SellWrapper.ResumeLayout(false);
            this.panel_SellWrapper.PerformLayout();
            this.panel_BrowseImage.ResumeLayout(false);
            this.panel_BrowseImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BrowseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.CustomPanel panel_header;
        private CustomControls.IconButton btn_Minimize;
        private CustomControls.IconButton btn_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_OrderLists;
        private System.Windows.Forms.Panel panel_SellWrapper;
        private Custom.ShadowRoundButton btn_Sell;
        private CustomControls.RJControls.RJComboBox cmb_Gender;
        private CustomDatePicker dp_Dob;
        private RJControls.RJTextBox txt_Address;
        private RJControls.RJTextBox txt_Phone1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private RJControls.RJTextBox txt_Phone;
        private System.Windows.Forms.Label label5;
        private RJControls.RJTextBox txt_NationalID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private RJControls.RJTextBox txt_Lname;
        private System.Windows.Forms.Label label7;
        private RJControls.RJTextBox txt_Fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_BrowseImage;
        private System.Windows.Forms.Label lb_BrowseImage;
        private System.Windows.Forms.PictureBox pic_BrowseImage;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Label lb_Payment;
        private System.Windows.Forms.Label label11;
    }
}