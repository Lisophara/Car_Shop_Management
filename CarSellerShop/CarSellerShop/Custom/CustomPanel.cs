using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CarSellerShop.Custom
{
    public partial class CustomPanel : Panel
    {
        #region -> Variable

        private int borderSize = 0;
        private int angle = 45;
        private int radius = 0;

        private int coord_X = 0;
        private int coord_Y = 0;
        private Form frm_Move = null;

        Color color = Color.FromArgb(255, 206, 243);
        Color color1 = Color.FromArgb(255, 244, 227);
        Color borderColor = Color.Black;


        #endregion

        #region -> Properties

        [Category("Custom Code")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        [Category("Custom Code")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Category("Custom Code")]
        public int ColorAngle
        {
            get { return angle; }
            set
            {
                angle = value;
                Invalidate();
            }
        }

        [Category("Custom Code")]
        public int BorderRadius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }
           
        [Category("Custom Code")]
        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
                Invalidate();
            }
        }

        [Category("Custom Code")]
        public Color Color1
        {
            get { return color1; }
            set
            {
                color1 = value;
                Invalidate();
            }
        }

        [Category("Custom Code")]
        public Form MoveForm
        {
            get { return frm_Move; }
            set
            {
                frm_Move = value;
                if (frm_Move != null)
                {
                    this.MouseDown += CustomPanel_MouseDown; ;
                    this.MouseMove += CustomPanel_MouseMove;
                }
                Invalidate();
            }
        }

        #endregion

        #region -> Event to Move Form

        private void CustomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            coord_X = e.Location.X;
            coord_Y = e.Location.Y;
        }
        private void CustomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            int tempX = frm_Move.Location.X - (coord_X - e.Location.X);
            int tempY = frm_Move.Location.Y - (coord_Y - e.Location.Y);

            frm_Move.Location = new Point(tempX, tempY);
                
        }

        #endregion

        #region -> Constuctor

        public CustomPanel()
        {
            InitializeComponent();
            this.Width = 100;
            this.Height = 100;
        }



        #endregion

        #region -> Draw & Fill Graphic

        private GraphicsPath path(Rectangle rect, int radius)
        {
            float rad = radius * 2F;
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            g.AddArc(rect.X, rect.Y, rad, rad, 180, 90);
            g.AddArc(rect.Width - rad, rect.Y, rad, rad, 270, 90);
            g.AddArc(rect.Width - rad, rect.Height - rad, rad, rad, 0, 90);
            g.AddArc(rect.X, rect.Height - rad, rad, rad, 90, 90);
            g.CloseFigure();

            return g;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            Rectangle rectBorder = Rectangle.Inflate(rect, -borderSize, -borderSize);

            if (!this.AutoScroll)
            {
                if (radius > 1)
                {
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    using (GraphicsPath p = path(rect, radius))
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, color, color1, angle))
                    using (Pen border =  new Pen(new SolidBrush(borderColor),borderSize))
                    {
                        this.Region = new Region(p);
                        e.Graphics.FillPath(brush, p);
                        e.Graphics.DrawPath(border, p);
                    }
                }
                else
                {
                    e.Graphics.SmoothingMode = SmoothingMode.None;
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect, color, color1, angle))
                    using (Pen border = new Pen(new SolidBrush(borderColor), borderSize))
                    {
                        this.Region = new Region(rect);
                        e.Graphics.FillRectangle(brush, rect);
                        e.Graphics.DrawRectangle(border, rect);
                    }
                }
            }
        }

        #endregion'
    }
}
