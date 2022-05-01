using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using CarSellerShop.Data;

namespace CustomControls
{
    public class IconButton : Button
    {
        #region -> Variable

        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private int imageSize = 0;
        private Color borderColor = Color.FromArgb(166, 193, 238);
        private Color hoverColor = Color.BlueViolet;
        private Color clickColor = Color.DeepPink;
        private TextAlignment align = TextAlignment.CENTER;
        private int margin = 0;

        private bool isHover = false;
        private bool isClick = false;
        private bool hover = false;
        private bool click = false;

        private PictureBox pic_Box = new PictureBox() { Width = 0, Height = 0};
        private Image btn_Image;
        private int imageX = 0;
        private bool isImage = false;


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
        public int SizeOfImage
        {
            get { return imageSize; }
            set
            {
                imageSize = value;
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
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("Code Advance")]
        public Image ButtonImage
        {
            get { return btn_Image; }
            set
            {
                btn_Image = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public int ImageX
        {
            get { return imageX; }
            set
            {
                imageX = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public bool EnableImage
        {
            get { return isImage; }
            set
            {
                isImage = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public bool OnHoverEvent
        {
            get { return hover; }
            set
            {
                hover = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public bool OnClickEvent
        {
            get { return click; }
            set
            {
                click = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public Color ClickColor
        {
            get { return clickColor; }
            set
            {
                clickColor = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public int MarginFromImage
        {
            get { return margin; }
            set
            {
                margin = value;
                Invalidate();
            }
        }

        [Category("Code Advance")]
        public TextAlignment TextValueAlign
        {
            get { return align; }
            set
            {
                align = value;
                Invalidate();
            }
        }


        #endregion

        #region -> Constructor

        //Constructor
        public IconButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(180, 30);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Resize += new EventHandler(Button_Resize);

            MouseHover += (sender, e) =>
            {
                if (hover)
                {
                    isHover = true;
                }
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                if (hover)
                {
                    isHover = false;
                }
                Invalidate();
            };

            MouseDown += (sender, e) =>
            {
                if (click)
                {
                    isClick = true;
                }
                Invalidate();
            };
            MouseUp += (sender, e) =>
            {
                if (click)
                {
                    isClick = false;
                }
                Invalidate();
            };
            imageSize = this.Height;

            pic_Box.MouseDown += Pic_Box_MouseDown;
            pic_Box.MouseUp += Pic_Box_MouseUp;
            pic_Box.MouseHover += Pic_Box_MouseHover;
            pic_Box.MouseLeave += Pic_Box_MouseLeave;
            pic_Box.Click += Pic_Box_Click;
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
                //using (Brush penSurface = new SolidBrush((isClick ? clickColor : (isHover ? hoverColor : this.BackColor))))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.FillPath(new SolidBrush((isClick ? clickColor : isHover ? hoverColor : this.BackColor)), pathSurface);

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
                pevent.Graphics.FillRectangle(new SolidBrush((isClick ? clickColor : isHover ? hoverColor : this.BackColor)), rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, smoothSize))
                    {
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }

            if (isImage)
            {
                pic_Box.Image = btn_Image;
                pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_Box.BackColor = (isClick ? clickColor : isHover ? hoverColor : this.BackColor);
                pic_Box.Height = imageSize;
                pic_Box.Width = imageSize;
                pic_Box.Location = new Point(imageX, (this.Height - imageSize) / 2);
                this.Controls.Add(pic_Box);
            }
            SizeF stSize = pevent.Graphics.MeasureString(this.Text, this.Font);
            float x = 0;
            if(align == TextAlignment.LEFT)
            {
                if(isImage)
                {
                    x = imageX + imageSize + margin;
                }
                else
                {
                    x = 0;
                }
            }
            else if(align == TextAlignment.CENTER)
            {
                if (isImage)
                {
                    x = (this.Width - stSize.Width + imageSize + imageX) / 2;
                }
                else
                {
                    x = (this.Width - stSize.Width) / 2;
                }
            }
            else
            {
                x = this.Width - stSize.Width;
            }

            pevent.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), x, this.Height / 2 - (stSize.Height / 2));

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


        private void Pic_Box_MouseHover(object sender, EventArgs e)
        {
            this.OnMouseHover(e);
        }

        private void Pic_Box_MouseUp(object sender, MouseEventArgs e)
        {
            this.OnMouseUp(e);
        }

        private void Pic_Box_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void Pic_Box_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Pic_Box_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        #endregion
    }
}