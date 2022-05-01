using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CarSellerShop.Custom
{
    public class ShadowRoundButton: Button
    {
        private Color btnColor = Color.Gray;
        private Color shadowColor = Color.LightGray;
        private Color textColor = Color.Black;
        private int shadowSize = 5;
        private int btnPosition = 0;
        private Form frm = null;
        
        public ShadowRoundButton()
        {

            MouseEnter += (e, sender) =>
            {
                btnPosition = shadowSize / 2;
                Invalidate();
            };
            MouseLeave += (e, sender) =>
            {
                btnPosition = 0;
                Invalidate();
            };

            MouseDown += (e, sender) =>
            {
                btnPosition = shadowSize - shadowSize/3;
                Invalidate();
            };
            MouseUp += (e, sender) =>
            {
                btnPosition = shadowSize/2;
                Invalidate();
            };

        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            // Background
            g.FillRectangle(new SolidBrush(frm != null ? frm.BackColor : Color.White), new Rectangle(-2, -2, Width+4, Height+4));
            
            // shadow
            g.FillEllipse(new SolidBrush(shadowColor), new Rectangle(shadowSize, shadowSize, Height - shadowSize, Height - shadowSize));
            g.FillEllipse(new SolidBrush(shadowColor), new Rectangle((Width - (Height - shadowSize)), shadowSize, Height - shadowSize, Height - shadowSize));
            g.FillRectangle(new SolidBrush(shadowColor), new Rectangle((Height/2) + shadowSize/2, shadowSize, Width - Height , Height - shadowSize));

            // button
            g.FillEllipse(new SolidBrush(btnColor), new Rectangle(btnPosition, btnPosition, Height- shadowSize, Height - shadowSize));
            g.FillEllipse(new SolidBrush(btnColor), new Rectangle((Width - (Height - btnPosition)), btnPosition, Height - shadowSize, Height - shadowSize));
            g.FillRectangle(new SolidBrush(btnColor), new Rectangle((Height / 2) - shadowSize/2+ btnPosition, btnPosition, Width - Height, Height- shadowSize));

            // String
            SizeF st = g.MeasureString(Text, Font);
            g.DrawString(Text, Font, new SolidBrush(textColor), new PointF((Width - shadowSize) / 2 - st.Width / 2 + btnPosition, (Height - shadowSize) / 2 - st.Height / 2 + btnPosition) );


            // line
            //g.DrawLine(new Pen(new SolidBrush(btnColor),1.5f), new Point((Height / 2) + btnPosition - shadowSize/2, Height - shadowSize + btnPosition), new Point((Height / 2) + shadowSize / 2, Height));
            //g.DrawLine(new Pen(new SolidBrush(btnColor), 1.5f), new Point(Width - Height/2 + shadowSize/2 - btnPosition, Height - shadowSize + btnPosition), new Point(Width - Height/2 + shadowSize, Height));

            // button not use
            //g.FillEllipse(new SolidBrush(btnColor), new Rectangle(btnPosition, btnPosition, Height - Height/3 - shadowSize, Height - Height/3 - shadowSize));
            //g.FillEllipse(new SolidBrush(btnColor), new Rectangle( (Width - (Height - shadowSize)) + btnPosition, btnPosition, Height - Height/3 - shadowSize, Height - Height/3 - shadowSize));
            //g.FillRectangle(new SolidBrush(btnColor), new Rectangle( (Height / 4) + btnPosition, btnPosition, Width - (Height - Height/6), Height - Height/3 - shadowSize));
        }



        [Category("LLS Code")]
        public Form _form
        {
            get { return frm; }
            set { frm = value;
                Invalidate();
            }
        }

        [Category("LLS Code")]
        public int _ShadowSize
        {
            get { return shadowSize; }
            set { shadowSize = value;
                Invalidate();
            }
        }

        [Category("LLS Code")]
        public Color _ShadowColor
        {
            get { return shadowColor; }
            set { shadowColor = value;
                Invalidate();
            }
        }

        [Category("LLS Code")]
        public Color _TextColor
        {
            get { return textColor; }
            set { textColor = value;
                Invalidate();
            }
        }

        [Category("LLS Code")]
        public Color _ButtonColor
        {
            get { return btnColor; }
            set
            {
                btnColor = value;
                Invalidate();
            }
        }

    }
}
