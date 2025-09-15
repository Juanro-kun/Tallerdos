using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller_2_Gestor.Controls
{
    public class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White; // color de relleno por defecto
        }

        private int _cornerRadius = 12;
        [Category("Apariencia")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); UpdateRegion(); }
        }

        private Color _borderColor = Color.Black;
        [Category("Apariencia")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private float _borderSize = 1f;
        [Category("Apariencia")]
        public float BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(0f, value); Invalidate(); UpdateRegion(); }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Rect trabajo (deja 1px para que no recorte el borde)
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);

            using var path = GetRoundedPath(rect, CornerRadius);
            using var fill = new SolidBrush(BackColor);
            g.FillPath(fill, path);

            if (BorderSize > 0f)
            {
                using var pen = new Pen(BorderColor, BorderSize);
                g.DrawPath(pen, path);
            }
        }

        private void UpdateRegion()
        {
            // recorta el área clickeable con el mismo radio
            if (CornerRadius <= 0)
            {
                Region = null;
                return;
            }
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);
            using var path = GetRoundedPath(rect, CornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            if (radius <= 0) { path.AddRectangle(rect); return path; }

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
