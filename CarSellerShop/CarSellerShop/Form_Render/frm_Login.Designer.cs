
namespace CarSellerShop.Form_Render
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.customPanel1 = new CarSellerShop.Custom.CustomPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_Minimize = new CarSellerShop.RJControls.RJCircularPictureBox();
            this.pic_Close = new CarSellerShop.RJControls.RJCircularPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new CarSellerShop.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new CarSellerShop.RJControls.RJTextBox();
            this.btn_Login = new CustomControls.RJControls.CustomButton();
            this.lb_ForgotPassword = new System.Windows.Forms.Label();
            this.lb_Register = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ChangePassword = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customPanel1
            // 
            this.customPanel1.BorderColor = System.Drawing.Color.Black;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.customPanel1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(44)))), ((int)(((byte)(79)))));
            this.customPanel1.ColorAngle = 45;
            this.customPanel1.Controls.Add(this.label1);
            this.customPanel1.Controls.Add(this.pic_Minimize);
            this.customPanel1.Controls.Add(this.pic_Close);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.MoveForm = this;
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(400, 30);
            this.customPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Car Selling";
            // 
            // pic_Minimize
            // 
            this.pic_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.pic_Minimize.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_Minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.pic_Minimize.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.pic_Minimize.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_Minimize.BorderSize = 3;
            this.pic_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Minimize.GradientAngle = 50F;
            this.pic_Minimize.Image = ((System.Drawing.Image)(resources.GetObject("pic_Minimize.Image")));
            this.pic_Minimize.Location = new System.Drawing.Point(340, 0);
            this.pic_Minimize.Name = "pic_Minimize";
            this.pic_Minimize.Size = new System.Drawing.Size(30, 30);
            this.pic_Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Minimize.TabIndex = 2;
            this.pic_Minimize.TabStop = false;
            this.pic_Minimize.Click += new System.EventHandler(this.pic_Minimize_Click);
            // 
            // pic_Close
            // 
            this.pic_Close.BackColor = System.Drawing.Color.Red;
            this.pic_Close.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pic_Close.BorderColor = System.Drawing.Color.Red;
            this.pic_Close.BorderColor2 = System.Drawing.Color.Red;
            this.pic_Close.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pic_Close.BorderSize = 3;
            this.pic_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_Close.GradientAngle = 50F;
            this.pic_Close.Image = ((System.Drawing.Image)(resources.GetObject("pic_Close.Image")));
            this.pic_Close.Location = new System.Drawing.Point(370, 0);
            this.pic_Close.Name = "pic_Close";
            this.pic_Close.Size = new System.Drawing.Size(30, 30);
            this.pic_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Close.TabIndex = 2;
            this.pic_Close.TabStop = false;
            this.pic_Close.Click += new System.EventHandler(this.pic_Close_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "User Name";
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Username.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Username.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Username.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Username.BorderRadius = 8;
            this.txt_Username.BorderSize = 2;
            this.txt_Username.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Username.Location = new System.Drawing.Point(16, 347);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.OnlyNumeric = false;
            this.txt_Username.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Username.PasswordChar = false;
            this.txt_Username.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Username.PlaceholderText = "Example@gmail.com";
            this.txt_Username.Size = new System.Drawing.Size(371, 34);
            this.txt_Username.TabIndex = 0;
            this.txt_Username.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Username.Texts = "";
            this.txt_Username.TextValue = "";
            this.txt_Username.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Password.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txt_Password.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_Password.BorderRadius = 8;
            this.txt_Password.BorderSize = 2;
            this.txt_Password.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Password.Location = new System.Drawing.Point(16, 419);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.OnlyNumeric = false;
            this.txt_Password.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_Password.PasswordChar = true;
            this.txt_Password.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Password.PlaceholderText = "";
            this.txt_Password.Size = new System.Drawing.Size(371, 34);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.Texts = "";
            this.txt_Password.TextValue = "";
            this.txt_Password.UnderlinedStyle = false;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(31)))), ((int)(((byte)(76)))));
            this.btn_Login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Login.BorderRadius = 5;
            this.btn_Login.BorderSize = 0;
            this.btn_Login.ColorAngle = 45;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Login.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(16, 472);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 37);
            this.btn_Login.SurfaceColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(98)))));
            this.btn_Login.SurfaceColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(29)))), ((int)(((byte)(231)))));
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextColor = System.Drawing.Color.White;
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            this.btn_Login.MouseLeave += new System.EventHandler(this.btn_Login_MouseLeave);
            this.btn_Login.MouseHover += new System.EventHandler(this.btn_Login_MouseHover);
            // 
            // lb_ForgotPassword
            // 
            this.lb_ForgotPassword.AutoSize = true;
            this.lb_ForgotPassword.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ForgotPassword.ForeColor = System.Drawing.Color.White;
            this.lb_ForgotPassword.Location = new System.Drawing.Point(12, 535);
            this.lb_ForgotPassword.Name = "lb_ForgotPassword";
            this.lb_ForgotPassword.Size = new System.Drawing.Size(162, 23);
            this.lb_ForgotPassword.TabIndex = 4;
            this.lb_ForgotPassword.Text = "Forgot password?";
            this.lb_ForgotPassword.Click += new System.EventHandler(this.lb_ForgotPassword_Click);
            this.lb_ForgotPassword.MouseLeave += new System.EventHandler(this.lb_ForgotPassword_MouseLeave);
            this.lb_ForgotPassword.MouseHover += new System.EventHandler(this.lb_ForgotPassword_MouseHover);
            // 
            // lb_Register
            // 
            this.lb_Register.AutoSize = true;
            this.lb_Register.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Register.ForeColor = System.Drawing.Color.White;
            this.lb_Register.Location = new System.Drawing.Point(165, 479);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.Size = new System.Drawing.Size(80, 23);
            this.lb_Register.TabIndex = 3;
            this.lb_Register.Text = "Register";
            this.lb_Register.Click += new System.EventHandler(this.lb_Register_Click);
            this.lb_Register.MouseLeave += new System.EventHandler(this.lb_ForgotPassword_MouseLeave);
            this.lb_Register.MouseHover += new System.EventHandler(this.lb_ForgotPassword_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(398, 275);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ChangePassword
            // 
            this.lb_ChangePassword.AutoSize = true;
            this.lb_ChangePassword.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.lb_ChangePassword.Location = new System.Drawing.Point(226, 535);
            this.lb_ChangePassword.Name = "lb_ChangePassword";
            this.lb_ChangePassword.Size = new System.Drawing.Size(161, 23);
            this.lb_ChangePassword.TabIndex = 4;
            this.lb_ChangePassword.Text = "Change Password";
            this.lb_ChangePassword.Click += new System.EventHandler(this.lb_ForgotPassword_Click);
            this.lb_ChangePassword.MouseLeave += new System.EventHandler(this.lb_ForgotPassword_MouseLeave);
            this.lb_ChangePassword.MouseHover += new System.EventHandler(this.lb_ForgotPassword_MouseHover);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.btn_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(31)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(400, 638);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lb_Register);
            this.Controls.Add(this.lb_ChangePassword);
            this.Controls.Add(this.lb_ForgotPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Selling";
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.CustomPanel customPanel1;
        private RJControls.RJCircularPictureBox pic_Minimize;
        private RJControls.RJCircularPictureBox pic_Close;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.CustomButton btn_Login;
        private RJControls.RJTextBox txt_Password;
        private System.Windows.Forms.Label lb_ForgotPassword;
        private System.Windows.Forms.Label label3;
        private RJControls.RJTextBox txt_Username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_Register;
        private System.Windows.Forms.Label lb_ChangePassword;
    }
}