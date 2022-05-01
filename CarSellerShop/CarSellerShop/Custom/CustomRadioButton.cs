using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CarSellerShop.RJControls
{
    class CustomRadioButton : RadioButton
    {
        #region -> Variable
        //Fields
        private Color checkedColor = Color.FromArgb(244, 105, 169);
        private Color checkedColor1 = Color.FromArgb(67, 221, 230);
        private Color unCheckedColor = Color.Gray;

        private int angle = 45;

        #endregion

        #region -> Properties
        //Properties

        [Category("Code Advance")]
        public Color CheckedColor
        {
            get
            {
                return checkedColor;
            }

            set
            {
                checkedColor = value;
                this.Invalidate();
            }
        }

        [Category("Code Advance")]
        public Color CheckedColor1
        {
            get
            {
                return checkedColor1;
            }

            set
            {
                checkedColor1 = value;
                this.Invalidate();
            }
        }

        [Category("Code Advance")]
        public int ColorAngle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public Color UnCheckedColor
        {
            get
            {
                return unCheckedColor;
            }

            set
            {
                unCheckedColor = value;
                this.Invalidate();
            }
        }

#endregion

        #region -> Constructor

        //Constructor
        public CustomRadioButton()
        {
            this.MinimumSize = new Size(0, 21);
            //Add a padding of 10 to the left to have a considerable distance between the text and the RadioButton.
            this.Padding = new Padding(10, 0, 0, 0);
        }

        #endregion

        #region -> Draw & Fill Graphics
        private GraphicsPath GetFigurePath(RectangleF rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        //Overridden methods
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //Fields
            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            float rbBorderSize = 18F;
            float rbCheckSize = 12F;
            RectangleF rectRbBorder = new RectangleF()
            {
                X = 0.5F,
                Y = (this.Height - rbBorderSize) / 2, //Center
                Width = rbBorderSize,
                Height = rbBorderSize
            };
            RectangleF rectRbCheck = new RectangleF()
            {
                X = rectRbBorder.X + ((rectRbBorder.Width - rbCheckSize) / 2), //Center
                Y = (this.Height - rbCheckSize) / 2, //Center
                Width = rbCheckSize,
                Height = rbCheckSize
            };

            //Drawing
            using (Pen penBorder = new Pen(checkedColor, 1.6F))
            using (SolidBrush brushRbCheck = new SolidBrush(checkedColor))
            using (SolidBrush brushText = new SolidBrush(this.ForeColor))
            using (GraphicsPath path = GetFigurePath(rectRbCheck, (int)(rectRbCheck.Height / 2)))
            using (LinearGradientBrush brush = new LinearGradientBrush(rectRbCheck, checkedColor, checkedColor1, angle))
            {
                //Draw surface
                graphics.Clear(this.BackColor);
                //Draw Radio Button
                if (this.Checked)
                {
                    graphics.DrawEllipse(penBorder, rectRbBorder);//Circle border
                    graphics.FillPath(brush, path); //Circle Radio Check
                    
                }
                else
                {
                    penBorder.Color = unCheckedColor;
                    graphics.DrawEllipse(penBorder, rectRbBorder); //Circle border
                }
                //Draw text
                graphics.DrawString(this.Text, this.Font, brushText,
                    rbBorderSize + 8, (this.Height - TextRenderer.MeasureText(this.Text, this.Font).Height) / 2);//Y=Center
            }
        }

        #endregion
    }
}