
namespace CarSellerShop.SubItem
{
    partial class order_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order_Info));
            this.line = new System.Windows.Forms.Label();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_Model = new System.Windows.Forms.Label();
            this.btn_Delete = new CustomControls.IconButton();
            this.SuspendLayout();
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.line.Location = new System.Drawing.Point(0, 47);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(275, 3);
            this.line.TabIndex = 0;
            // 
            // lb_ID
            // 
            this.lb_ID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.lb_ID.Location = new System.Drawing.Point(3, 9);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(40, 30);
            this.lb_ID.TabIndex = 1;
            this.lb_ID.Text = "123";
            this.lb_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Model
            // 
            this.lb_Model.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F);
            this.lb_Model.Location = new System.Drawing.Point(68, 9);
            this.lb_Model.Name = "lb_Model";
            this.lb_Model.Size = new System.Drawing.Size(168, 30);
            this.lb_Model.TabIndex = 1;
            this.lb_Model.Text = "HighLander";
            this.lb_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(238)))));
            this.btn_Delete.BorderRadius = 0;
            this.btn_Delete.BorderSize = 0;
            this.btn_Delete.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.ButtonImage")));
            this.btn_Delete.ClickColor = System.Drawing.Color.LightGray;
            this.btn_Delete.EnableImage = true;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.HoverColor = System.Drawing.Color.Gainsboro;
            this.btn_Delete.ImageX = 0;
            this.btn_Delete.Location = new System.Drawing.Point(242, 9);
            this.btn_Delete.MarginFromImage = 0;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.OnClickEvent = true;
            this.btn_Delete.OnHoverEvent = true;
            this.btn_Delete.Size = new System.Drawing.Size(30, 30);
            this.btn_Delete.SizeOfImage = 30;
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.TextColor = System.Drawing.Color.White;
            this.btn_Delete.TextValueAlign = CarSellerShop.Data.TextAlignment.CENTER;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // order_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lb_Model);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.line);
            this.Name = "order_Info";
            this.Size = new System.Drawing.Size(275, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label line;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_Model;
        public CustomControls.IconButton btn_Delete;
    }
}
