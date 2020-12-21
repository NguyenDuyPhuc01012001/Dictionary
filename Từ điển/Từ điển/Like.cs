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
    public partial class Like : Control
    {
        #region Private Member
        private SolidBrush brush=new SolidBrush(Color.Gold);

        private bool IsClicked = false;
        #endregion              

        #region Constructor
        public Like()
        {
            Size = new Size(1000, 1800);

        }
        #endregion

        #region Paint
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            PainHeart(pe);
        }

        private GraphicsPath Create()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            float percent = 0.09f;
            path.AddArc((Width / 2) * percent, (this.Height / 2 + 1) * percent, 150 * percent, 150 * percent, 135, 200);
            path.AddArc((this.Width / 2 + 130) * percent, (this.Height / 2 + 1) * percent, 150 * percent, 150 * percent, 210, 195);
            path.AddLine((this.Width / 2 + 260 - 2) * percent, (this.Height / 2 + 130) * percent, (this.Width / 2 + 140) * percent, (this.Height / 2 + 270) * percent);
            path.CloseFigure();
            return path;
        }

        private void PainHeart(PaintEventArgs e)
        {
            GraphicsPath path1 = Create();
            e.Graphics.FillPath(brush, path1);
            e.Graphics.SetClip(path1);
        }
        #endregion

        #region Refresh Label
        public void Refresh()
        {
            //LikeLabel.Text = CheckBoxText;
            brush.Color = Color.Gold;
            IsClicked = false;
            Invalidate();
        }
        #endregion

        #region Click
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            IsClicked = !IsClicked;
            if (IsClicked)
            {
                brush.Color = Color.Red;
            }
            else
            {
                brush.Color = Color.Gold;
            }
            Invalidate();
        }
        #endregion
    }
}