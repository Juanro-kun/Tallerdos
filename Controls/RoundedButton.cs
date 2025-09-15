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

namespace Taller_2_Gestor.Controls
{
    partial class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 12;
        public float BorderSize { get; set; } = 1f;
        public Color BorderColor { get; set; } = Color.DimGray;
        public Color BackNormal { get; set; } = Color.FromArgb(40, 40, 40);
        public Color BackHover { get; set; } = Color.FromArgb(55, 55, 55);
        public Color BackPressed { get; set; } = Color.FromArgb(25, 25, 25);

        bool _hover, _pressed;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            ForeColor = Color.Gainsboro;
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics; g.SmoothingMode = SmoothingMode.AntiAlias;
            var rect = ClientRectangle; rect.Inflate(-1, -1);

            using var path = Rounded(rect, CornerRadius);
            var fill = _pressed ? BackPressed : _hover ? BackHover : BackNormal;

            using (var br = new SolidBrush(fill)) g.FillPath(br, path);
            if (BorderSize > 0) using (var pen = new Pen(BorderColor, BorderSize)) g.DrawPath(pen, path);

            TextRenderer.DrawText(g, Text, Font, rect,
                ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }

        protected override void OnSizeChanged(EventArgs e) { base.OnSizeChanged(e); using var p = Rounded(ClientRectangle, CornerRadius); Region = new Region(p); }

        static GraphicsPath Rounded(Rectangle r, int rad)
        {
            if (rad <= 0) { var p = new GraphicsPath(); p.AddRectangle(r); return p; }
            int d = rad * 2; var pth = new GraphicsPath();
            pth.AddArc(r.X, r.Y, d, d, 180, 90);
            pth.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            pth.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            pth.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            pth.CloseFigure(); return pth;
        }
    }
}
