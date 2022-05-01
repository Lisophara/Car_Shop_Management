
namespace CarSellerShop.SubItem
{
    partial class staff_Info
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_InfoWrapper = new System.Windows.Forms.Panel();
            this.btn_Delete = new CarSellerShop.Custom.ShadowRoundButton();
            this.btn_Edit = new CarSellerShop.Custom.ShadowRoundButton();
            this.lb_Role = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_Address = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_FullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Nation_ID = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_profile = new CarSellerShop.RJControls.RJCircularPictureBox();
            this.panel_InfoWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_InfoWrapper
            // 
            this.panel_InfoWrapper.BackColor = System.Drawing.Color.White;
            this.panel_InfoWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_InfoWrapper.Controls.Add(this.btn_Delete);
            this.panel_InfoWrapper.Controls.Add(this.btn_Edit);
            this.panel_InfoWrapper.Controls.Add(this.lb_Role);
            this.panel_InfoWrapper.Controls.Add(this.label6);
            this.panel_InfoWrapper.Controls.Add(this.lb_Phone);
            this.panel_InfoWrapper.Controls.Add(this.label5);
            this.panel_InfoWrapper.Controls.Add(this.lb_Gender);
            this.panel_InfoWrapper.Controls.Add(this.lb_Address);
            this.panel_InfoWrapper.Controls.Add(this.label4);
            this.panel_InfoWrapper.Controls.Add(this.lb_FullName);
            this.panel_InfoWrapper.Controls.Add(this.label3);
            this.panel_InfoWrapper.Controls.Add(this.lb_Nation_ID);
            this.panel_InfoWrapper.Controls.Add(this.lb_Id);
            this.panel_InfoWrapper.Controls.Add(this.label7);
            this.panel_InfoWrapper.Controls.Add(this.label2);
            this.panel_InfoWrapper.Controls.Add(this.label1);
            this.panel_InfoWrapper.Controls.Add(this.panel2);
            this.panel_InfoWrapper.Controls.Add(this.pic_profile);
            this.panel_InfoWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_InfoWrapper.Location = new System.Drawing.Point(5, 5);
            this.panel_InfoWrapper.Name = "panel_InfoWrapper";
            this.panel_InfoWrapper.Size = new System.Drawing.Size(450, 450);
            this.panel_InfoWrapper.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete._ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btn_Delete._form = null;
            this.btn_Delete._ShadowColor = System.Drawing.Color.LightGray;
            this.btn_Delete._ShadowSize = 5;
            this.btn_Delete._TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.Black;
            this.btn_Delete.Location = new System.Drawing.Point(248, 400);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(164, 42);
            this.btn_Delete.TabIndex = 9;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit._ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.btn_Edit._form = null;
            this.btn_Edit._ShadowColor = System.Drawing.Color.LightGray;
            this.btn_Edit._ShadowSize = 5;
            this.btn_Edit._TextColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.Black;
            this.btn_Edit.Location = new System.Drawing.Point(39, 400);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(164, 42);
            this.btn_Edit.TabIndex = 9;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // lb_Role
            // 
            this.lb_Role.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Role.Location = new System.Drawing.Point(95, 370);
            this.lb_Role.Name = "lb_Role";
            this.lb_Role.Size = new System.Drawing.Size(340, 22);
            this.lb_Role.TabIndex = 8;
            this.lb_Role.Text = "Cashier";
            this.lb_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Role";
            // 
            // lb_Phone
            // 
            this.lb_Phone.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Phone.Location = new System.Drawing.Point(95, 330);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(340, 22);
            this.lb_Phone.TabIndex = 8;
            this.lb_Phone.Text = "096xxxxxxx";
            this.lb_Phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // lb_Gender
            // 
            this.lb_Gender.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(95, 290);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(340, 22);
            this.lb_Gender.TabIndex = 8;
            this.lb_Gender.Text = "ស្រី";
            this.lb_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Address
            // 
            this.lb_Address.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Address.Location = new System.Drawing.Point(95, 250);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(340, 22);
            this.lb_Address.TabIndex = 8;
            this.lb_Address.Text = "Phnom Penh, RUPP";
            this.lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gender";
            // 
            // lb_FullName
            // 
            this.lb_FullName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FullName.Location = new System.Drawing.Point(95, 210);
            this.lb_FullName.Name = "lb_FullName";
            this.lb_FullName.Size = new System.Drawing.Size(340, 22);
            this.lb_FullName.TabIndex = 8;
            this.lb_FullName.Text = "Group 3";
            this.lb_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // lb_Nation_ID
            // 
            this.lb_Nation_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nation_ID.Location = new System.Drawing.Point(95, 170);
            this.lb_Nation_ID.Name = "lb_Nation_ID";
            this.lb_Nation_ID.Size = new System.Drawing.Size(340, 22);
            this.lb_Nation_ID.TabIndex = 8;
            this.lb_Nation_ID.Text = "#123456789";
            this.lb_Nation_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_Id
            // 
            this.lb_Id.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Id.Location = new System.Drawing.Point(95, 130);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(340, 22);
            this.lb_Id.TabIndex = 8;
            this.lb_Id.Text = "001";
            this.lb_Id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "National ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(10, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 2);
            this.panel2.TabIndex = 7;
            // 
            // pic_profile
            // 
            this.pic_profile.BackColor = System.Drawing.Color.Transparent;
            this.pic_profile.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_profile.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pic_profile.BorderColor2 = System.Drawing.Color.HotPink;
            this.pic_profile.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_profile.BorderSize = 2;
            this.pic_profile.GradientAngle = 50F;
            this.pic_profile.Location = new System.Drawing.Point(181, 2);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(100, 100);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_profile.TabIndex = 6;
            this.pic_profile.TabStop = false;
            // 
            // staff_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel_InfoWrapper);
            this.Name = "staff_Info";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(460, 460);
            this.Load += new System.EventHandler(this.stuff_info_Load);
            this.panel_InfoWrapper.ResumeLayout(false);
            this.panel_InfoWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InfoWrapper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private RJControls.RJCircularPictureBox pic_profile;
        private System.Windows.Forms.Label lb_Role;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_FullName;
        private System.Windows.Forms.Label lb_Id;
        public Custom.ShadowRoundButton btn_Edit;
        public Custom.ShadowRoundButton btn_Delete;
        private System.Windows.Forms.Label lb_Nation_ID;
        private System.Windows.Forms.Label label7;
    }
}
