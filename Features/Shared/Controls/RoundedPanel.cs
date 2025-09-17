using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Taller_2_Gestor.Features.Shared.Controls
{
    [DesignerCategory("Code")]
    public class RoundedPanel : Panel
    {
        public RoundedPanel()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White; // relleno por defecto
        }

        // ---- Propiedades serializables ----
        private int _cornerRadius = 12;
        [Category("Apariencia"), Description("Radio de las esquinas"),
         DefaultValue(12),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); UpdateRegion(); }
        }
        public bool ShouldSerializeCornerRadius() => _cornerRadius != 12;
        public void ResetCornerRadius() => CornerRadius = 12;

        private Color _borderColor = Color.Black;
        [Category("Apariencia"), Description("Color del borde"),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }
        public bool ShouldSerializeBorderColor() => _borderColor != Color.Black;
        public void ResetBorderColor() => BorderColor = Color.Black;

        private float _borderSize = 1f;
        [Category("Apariencia"), Description("Grosor del borde"),
         DefaultValue(1f),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(0f, value); Invalidate(); UpdateRegion(); }
        }
        public bool ShouldSerializeBorderSize() => Math.Abs(_borderSize - 1f) > 0.0001f;
        public void ResetBorderSize() => BorderSize = 1f;

        // ---- Pintado ----
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
            if (CornerRadius <= 0) { Region = null; return; }
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);
            using var path = GetRoundedPath(rect, CornerRadius);
            Region = new Region(path);
        }

        private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            if (radius <= 0) { var p0 = new GraphicsPath(); p0.AddRectangle(rect); return p0; }
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
