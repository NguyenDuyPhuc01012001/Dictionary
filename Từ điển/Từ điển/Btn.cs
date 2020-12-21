using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Từ_điển
{
    public partial class Btn : Button
    {
        public Btn()
        {
            InitializeComponent();
        }
        
        private GraphicsPath Create(float x, float y, float width, float height, float radius)
        {
            float xw = (x + width);
            float yh = (y + height);
            float xwr = (xw - radius);
            float yhr = (yh - radius);
            float xr = (x + radius);
            float yr = (y + radius);
            float r2 = (radius * 2);
            float xwr2 = xw - r2;
            float yhr2 = yh - r2;

            GraphicsPath p = new GraphicsPath();
            p.StartFigure();

            //Top Left Corner
            p.AddArc(x, y, r2, r2, 180, 90);

            //Top Edge
            p.AddLine(xr, y, xwr, y);

            //Top Right Corner
            p.AddArc(xwr2, y, r2, r2, 270, 90);

            //Right Edge
            p.AddLine(xw, yr, xw, yhr);

            //Bottom Right Corner
            p.AddArc(xwr2, yhr2, r2, r2, 0, 90);

            //Bottom Edge
            p.AddLine(xwr, yh, xr, yh);

            //Bottom Left Corner
            p.AddArc(x, yhr2, r2, r2, 90, 90);

            //Left Edge
            p.AddLine(x, yhr, x, yr);

            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Call the OnPaint method of the base class. 
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            GraphicsPath path = Create(0, 0, Bounds.Width, Bounds.Height, 30);
            SizeF size = graphics.MeasureString(this.Text, this.Font); 

            graphics.FillPath(new LinearGradientBrush(this.ClientRectangle, Color.White, Color.Orange, 90F), path);
            graphics.DrawString(this.Text, this.Font, Brushes.Black, (this.Width - size.Width) / 2, (this.Height - size.Height) / 2);
        }
    }
}