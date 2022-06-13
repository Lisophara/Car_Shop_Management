
namespace CarSellerShop.Form_Render
{
    partial class frm_Car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Car));
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.panel_BrowseImage = new System.Windows.Forms.Panel();
            this.lb_BrowseImage = new System.Windows.Forms.Label();
            this.pic_BrowseImage = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_Image = new System.Windows.Forms.PictureBox();
            this.txt_CreateYear = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Color = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Model = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Price = new CarSellerShop.RJControls.RJTextBox();
            this.txt_Identifier = new CarSellerShop.RJControls.RJTextBox();
            this.panel_HeadWrapper = new CarSellerShop.Custom.CustomPanel();
            this.panel_Head = new CarSellerShop.Custom.CustomPanel();
            this.btn_Action = new CarSellerShop.Custom.RoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.panel_BrowseImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BrowseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).BeginInit();
            this.panel_HeadWrapper.SuspendLayout();
            this.panel_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Developed by RUPP Group 3 Year 3";
            // 
            // cmb_Type
            // 
            this.cmb_Type.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Truck",
            "Bus",
            "Family"});
            this.cmb_Type.Location = new System.Drawing.Point(185, 397);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(129, 31);
            this.cmb_Type.TabIndex = 6;
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Font = new System.Drawing.Font("Mongolian Baiti", 16F);
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "Original",
            "Second Hand"});
            this.cmb_Status.Location = new System.Drawing.Point(23, 397);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(129, 31);
            this.cmb_Status.TabIndex = 5;
            // 
            // panel_BrowseImage
            // 
            this.panel_BrowseImage.BackColor = System.Drawing.Color.White;
            this.panel_BrowseImage.Controls.Add(this.lb_BrowseImage);
            this.panel_BrowseImage.Controls.Add(this.pic_BrowseImage);
            this.panel_BrowseImage.Location = new System.Drawing.Point(441, 285);
            this.panel_BrowseImage.Name = "panel_BrowseImage";
            this.panel_BrowseImage.Size = new System.Drawing.Size(293, 191);
            this.panel_BrowseImage.TabIndex = 28;
            this.panel_BrowseImage.Click += new System.EventHandler(this.BrowseImage);
            // 
            // lb_BrowseImage
            // 
            this.lb_BrowseImage.AutoSize = true;
            this.lb_BrowseImage.BackColor = System.Drawing.Color.Transparent;
            this.lb_BrowseImage.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_BrowseImage.Location = new System.Drawing.Point(86, 119);
            this.lb_BrowseImage.Name = "lb_BrowseImage";
            this.lb_BrowseImage.Size = new System.Drawing.Size(125, 21);
            this.lb_BrowseImage.TabIndex = 10;
            this.lb_BrowseImage.Text = "Upload Image";
            this.lb_BrowseImage.Click += new System.EventHandler(this.BrowseImage);
            // 
            // pic_BrowseImage
            // 
            this.pic_BrowseImage.Image = ((System.Drawing.Image)(resources.GetObject("pic_BrowseImage.Image")));
            this.pic_BrowseImage.Location = new System.Drawing.Point(125, 55);
            this.pic_BrowseImage.Name = "pic_BrowseImage";
            this.pic_BrowseImage.Size = new System.Drawing.Size(50, 50);
            this.pic_BrowseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_BrowseImage.TabIndex = 0;
            this.pic_BrowseImage.TabStop = false;
            this.pic_BrowseImage.Click += new System.EventHandler(this.BrowseImage);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(181, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Create year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Identifier / Car ID";
            // 
            // pic_Image
            // 
            this.pic_Image.BackColor = System.Drawing.Color.Transparent;
            this.pic_Image.Location = new System.Drawing.Point(441, 285);
            this.pic_Image.Name = "pic_Image";
            this.pic_Image.Size = new System.Drawing.Size(292, 191);
            this.pic_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Image.TabIndex = 25;
            this.pic_Image.TabStop = false;
            this.pic_Image.Click += new System.EventHandler(this.pic_Image_Click);
            // 
            // txt_CreateYear
            // 
            this.txt_CreateYear.BackColor = System.Drawing.SystemColors.Window;
            this.txt_CreateYear.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_CreateYear.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_CreateYear.BorderRadius = 0;
            this.txt_CreateYear.BorderSize = 2;
            this.txt_CreateYear.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txt_CreateYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CreateYear.Location = new System.Drawing.Point(443, 204);
            this.txt_CreateYear.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CreateYear.Multiline = false;
            this.txt_CreateYear.Name = "txt_CreateYear";
            this.txt_CreateYear.OnlyNumeric = true;
            this.txt_CreateYear.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_CreateYear.PasswordChar = false;
            this.txt_CreateYear.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_CreateYear.PlaceholderText = "";
            this.txt_CreateYear.Size = new System.Drawing.Size(291, 34);
            this.txt_CreateYear.TabIndex = 3;
            this.txt_CreateYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CreateYear.Texts = "";
            this.txt_CreateYear.TextValue = "";
            this.txt_CreateYear.UnderlinedStyle = false;
            // 
            // txt_Color
            // 
            this.txt_Color.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Color.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Color.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Color.BorderRadius = 0;
            this.txt_Color.BorderSize = 2;
            this.txt_Color.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txt_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Color.Location = new System.Drawing.Point(23, 204);
            this.txt_Color.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Color.Multiline = false;
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.OnlyNumeric = false;
            this.txt_Color.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Color.PasswordChar = false;
            this.txt_Color.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Color.PlaceholderText = "";
            this.txt_Color.Size = new System.Drawing.Size(291, 34);
            this.txt_Color.TabIndex = 2;
            this.txt_Color.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Color.Texts = "";
            this.txt_Color.TextValue = "";
            this.txt_Color.UnderlinedStyle = false;
            // 
            // txt_Model
            // 
            this.txt_Model.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Model.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Model.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Model.BorderRadius = 0;
            this.txt_Model.BorderSize = 2;
            this.txt_Model.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txt_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Model.Location = new System.Drawing.Point(441, 121);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Model.Multiline = false;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.OnlyNumeric = false;
            this.txt_Model.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Model.PasswordChar = false;
            this.txt_Model.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Model.PlaceholderText = "";
            this.txt_Model.Size = new System.Drawing.Size(291, 34);
            this.txt_Model.TabIndex = 1;
            this.txt_Model.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Model.Texts = "";
            this.txt_Model.TextValue = "";
            this.txt_Model.UnderlinedStyle = false;
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Price.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Price.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Price.BorderRadius = 0;
            this.txt_Price.BorderSize = 2;
            this.txt_Price.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Price.Location = new System.Drawing.Point(23, 300);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Multiline = false;
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.OnlyNumeric = true;
            this.txt_Price.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Price.PasswordChar = false;
            this.txt_Price.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Price.PlaceholderText = "";
            this.txt_Price.Size = new System.Drawing.Size(291, 34);
            this.txt_Price.TabIndex = 4;
            this.txt_Price.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Price.Texts = "";
            this.txt_Price.TextValue = "";
            this.txt_Price.UnderlinedStyle = false;
            // 
            // txt_Identifier
            // 
            this.txt_Identifier.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Identifier.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Identifier.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Identifier.BorderRadius = 0;
            this.txt_Identifier.BorderSize = 2;
            this.txt_Identifier.Font = new System.Drawing.Font("Mongolian Baiti", 13F);
            this.txt_Identifier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Identifier.Location = new System.Drawing.Point(23, 121);
            this.txt_Identifier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Identifier.Multiline = false;
            this.txt_Identifier.Name = "txt_Identifier";
            this.txt_Identifier.OnlyNumeric = false;
            this.txt_Identifier.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Identifier.PasswordChar = false;
            this.txt_Identifier.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Identifier.PlaceholderText = "";
            this.txt_Identifier.Size = new System.Drawing.Size(291, 34);
            this.txt_Identifier.TabIndex = 0;
            this.txt_Identifier.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Identifier.Texts = "";
            this.txt_Identifier.TextValue = "";
            this.txt_Identifier.UnderlinedStyle = false;
            // 
            // panel_HeadWrapper
            // 
            this.panel_HeadWrapper.BorderColor = System.Drawing.Color.Transparent;
            this.panel_HeadWrapper.BorderRadius = 0;
            this.panel_HeadWrapper.BorderSize = 0;
            this.panel_HeadWrapper.Color = System.Drawing.Color.White;
            this.panel_HeadWrapper.Color1 = System.Drawing.Color.White;
            this.panel_HeadWrapper.ColorAngle = 45;
            this.panel_HeadWrapper.Controls.Add(this.panel_Head);
            this.panel_HeadWrapper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_HeadWrapper.Location = new System.Drawing.Point(0, 0);
            this.panel_HeadWrapper.MoveForm = this;
            this.panel_HeadWrapper.Name = "panel_HeadWrapper";
            this.panel_HeadWrapper.Padding = new System.Windows.Forms.Padding(20);
            this.panel_HeadWrapper.Size = new System.Drawing.Size(753, 80);
            this.panel_HeadWrapper.TabIndex = 12;
            // 
            // panel_Head
            // 
            this.panel_Head.BorderColor = System.Drawing.Color.Transparent;
            this.panel_Head.BorderRadius = 0;
            this.panel_Head.BorderSize = 0;
            this.panel_Head.Color = System.Drawing.Color.White;
            this.panel_Head.Color1 = System.Drawing.Color.White;
            this.panel_Head.ColorAngle = 45;
            this.panel_Head.Controls.Add(this.btn_Action);
            this.panel_Head.Controls.Add(this.label1);
            this.panel_Head.Controls.Add(this.pic_back);
            this.panel_Head.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Head.Location = new System.Drawing.Point(20, 20);
            this.panel_Head.MoveForm = this;
            this.panel_Head.Name = "panel_Head";
            this.panel_Head.Size = new System.Drawing.Size(713, 40);
            this.panel_Head.TabIndex = 1;
            // 
            // btn_Action
            // 
            this.btn_Action._ActivateBorderHover = false;
            this.btn_Action._ActivateInnerHover = false;
            this.btn_Action._ActivateTextHover = false;
            this.btn_Action._BorderColor = System.Drawing.Color.Black;
            this.btn_Action._BorderSize = 0;
            this.btn_Action._InnerButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btn_Action._OnHoverBorderColor = System.Drawing.Color.Green;
            this.btn_Action._OnHoverInnerColor = System.Drawing.Color.Cyan;
            this.btn_Action._OnHoverTextColor = System.Drawing.Color.Red;
            this.btn_Action._TextColor = System.Drawing.Color.White;
            this.btn_Action.BackColor = System.Drawing.Color.Transparent;
            this.btn_Action.FlatAppearance.BorderSize = 0;
            this.btn_Action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Action.Font = new System.Drawing.Font("Mongolian Baiti", 15F);
            this.btn_Action.Location = new System.Drawing.Point(595, 3);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Size = new System.Drawing.Size(115, 32);
            this.btn_Action.TabIndex = 9;
            this.btn_Action.TabStop = false;
            this.btn_Action.Text = "Add";
            this.btn_Action.UseVisualStyleBackColor = false;
            this.btn_Action.Click += new System.EventHandler(this.btn_Action_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Car";
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
            // frm_Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 490);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CreateYear);
            this.Controls.Add(this.txt_Color);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.panel_BrowseImage);
            this.Controls.Add(this.pic_Image);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Identifier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_HeadWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Car";
            this.Text = "Car";
            this.panel_BrowseImage.ResumeLayout(false);
            this.panel_BrowseImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_BrowseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Image)).EndInit();
            this.panel_HeadWrapper.ResumeLayout(false);
            this.panel_Head.ResumeLayout(false);
            this.panel_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.Label label2;
        private Custom.RoundButton btn_Action;
        private System.Windows.Forms.Label label5;
        private Custom.CustomPanel panel_Head;
        private System.Windows.Forms.Label label1;
        private RJControls.RJTextBox txt_Color;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Panel panel_BrowseImage;
        private System.Windows.Forms.Label lb_BrowseImage;
        private System.Windows.Forms.PictureBox pic_BrowseImage;
        private System.Windows.Forms.PictureBox pic_Image;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private RJControls.RJTextBox txt_Model;
        private RJControls.RJTextBox txt_Price;
        private RJControls.RJTextBox txt_Identifier;
        private Custom.CustomPanel panel_HeadWrapper;
        private System.Windows.Forms.Label label3;
        private RJControls.RJTextBox txt_CreateYear;
    }
}