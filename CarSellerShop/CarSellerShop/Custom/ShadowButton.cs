using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;

namespace CarSellerShop.Custom
{
    class ShadowButton:Button
    {
        int shadowSize = 5;
        int btnPosition = 0;
        public static Color shadowColor = Color.LightGray;
        Color btnColor = Color.Gray;
        Color textColor = Color.Black;
        private Form frm = Form.ActiveForm;

        public ShadowButton()
        {
            
            Thread thread = new Thread(delegate () {

                MouseDown += (e, sender) =>
                {
                    
                    btnPosition = shadowSize - shadowSize / 4;
                    Invalidate();
                };
                MouseUp += (e, sender) =>
                {
                    btnPosition = shadowSize - shadowSize / 2;
                    Invalidate();
                };
                MouseEnter += (e, sender) =>
                {
                    btnPosition = shadowSize - shadowSize / 2;
                    Invalidate();
                };
                MouseLeave += (e, sender) =>
                {
                    btnPosition = 0;
                    Invalidate();
                };

            });
            thread.Start();
            
            
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Rectangle rec;
            Graphics g = pevent.Graphics;
            rec = new Rectangle(0, 0, Width, Height);
            g.FillRectangle(new SolidBrush( frm != null ? frm.BackColor : Color.White), rec);
            
            Point[] p = {new Point(Width - shadowSize + btnPosition, btnPosition), new Point(Width - shadowSize, shadowSize), new Point(Width, shadowSize)};
            g.FillPolygon(new SolidBrush(shadowColor), p);

            Point[] p1 = { new Point(btnPosition, (Height - shadowSize) + btnPosition ), new Point(shadowSize, Height - shadowSize), new Point(shadowSize, Height)};
            g.FillPolygon(new SolidBrush(shadowColor), p1);

            // Shadow
            rec = new Rectangle(shadowSize, shadowSize, Width, Height);
            g.FillRectangle(new SolidBrush(shadowColor), rec);
            
            // line button to shadow
            Point[] line = { new Point(Width - shadowSize + btnPosition, Height - shadowSize + btnPosition), new Point(Width, Height) };
            g.DrawLine(new Pen(new SolidBrush(btnColor)), new Point(Width - shadowSize + btnPosition, Height - shadowSize + btnPosition), new Point(Width, Height));
            // Button
            rec = new Rectangle(btnPosition, btnPosition, Width - shadowSize, Height - shadowSize);
            g.FillRectangle(new SolidBrush(btnColor), rec);

            // String
            SizeF st = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, new SolidBrush(textColor), new PointF( ((Width - shadowSize) - st.Width) / 2 + btnPosition, ((Height - shadowSize) - st.Height) / 2 + btnPosition) );
        }

        public int _ShadowSize
        {
            get { return shadowSize; }
            set {
                shadowSize = value;
                Invalidate();
            }
        }
        public Color _ButtonColor
        {
            get { return btnColor; }
            set { btnColor = value;
                Invalidate();
            }
        }
        public Color _ShadowColor
        {
            get { return shadowColor; }
            set { shadowColor = value;
                Invalidate();
            }
        }

        public Color _TextColor
        {
            get { return textColor; }
            set { textColor = value;
                Invalidate();
            }
        }
        public Form _form
        {
            get { return frm; }
            set { frm = value; Invalidate(); }
        }
    }

}
