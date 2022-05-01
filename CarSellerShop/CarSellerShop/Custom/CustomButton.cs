using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
namespace CustomControls.RJControls
{
    public class CustomButton : Button
    {
        #region -> Variable

        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private int angle = 45;
        private Color borderColor = Color.FromArgb(166, 193, 238);
        private Color surfaceColor = Color.FromArgb(243, 85, 142);
        private Color surfaceColor1 = Color.FromArgb(156, 29, 231);

        #endregion

        #region -> Properties

        //Properties
        [Category("Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
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
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Code Advance")]
        public Color SurfaceColor
        {
            get { return surfaceColor; }
            set { surfaceColor = value; Invalidate(); }
        }
        [Category("Code Advance")]
        public Color SurfaceColor1
        {
            get { return surfaceColor1; }
            set { surfaceColor1 = value; Invalidate(); }
        }

        [Category("Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        #endregion

        #region -> Constructor

        //Constructor
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(188, 37);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);
        }

        #endregion

        #region -> Draw & Fill Graphics

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Rectangle rectSurface = this.ClientRectangle;
            //Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectSurface, borderRadius))
                using (LinearGradientBrush penSurface = new LinearGradientBrush(rectSurface,surfaceColor,surfaceColor1, angle))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.FillPath(penSurface,pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
                
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                LinearGradientBrush penSurface = new LinearGradientBrush(rectSurface, surfaceColor, surfaceColor1, angle);
                pevent.Graphics.FillRectangle(penSurface, rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor,smoothSize))
                    {
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            SizeF stSize = pevent.Graphics.MeasureString(this.Text, this.Font);
            pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.Width / 2 - (stSize.Width / 2), this.Height / 2 - (stSize.Height / 2));

        }

        #endregion

        #region -> Event

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
                
        }

        #endregion
    }
}