using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Taller_2_Gestor.Features.Shared.Controls
{
    [DesignerCategory("Code")]
    public class RoundedButton : Button
    {
        // --------- Estado visual ----------
        private bool _hover, _pressed;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            ForeColor = Color.Gainsboro;
            BackColor = Color.FromArgb(40, 40, 40);
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        // --------- PROPIEDADES SERIALIZABLES ----------

        private int _cornerRadius = 12;
        [Category("Apariencia"), Description("Radio de las esquinas."),
         DefaultValue(12),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = Math.Max(0, value); Invalidate(); UpdateRegion(); }
        }
        public bool ShouldSerializeCornerRadius() => _cornerRadius != 12;
        public void ResetCornerRadius() => CornerRadius = 12;

        private float _borderSize = 1f;
        [Category("Apariencia"), Description("Grosor del borde."),
         DefaultValue(1f),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public float BorderSize
        {
            get => _borderSize;
            set { _borderSize = Math.Max(0f, value); Invalidate(); }
        }
        public bool ShouldSerializeBorderSize() => Math.Abs(_borderSize - 1f) > 0.0001f;
        public void ResetBorderSize() => BorderSize = 1f;

        private Color _borderColor = Color.DimGray;
        [Category("Apariencia"), Description("Color del borde."),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }
        public bool ShouldSerializeBorderColor() => _borderColor != Color.DimGray;
        public void ResetBorderColor() => BorderColor = Color.DimGray;

        private Color _backNormal = Color.FromArgb(40, 40, 40);
        [Category("Apariencia"), Description("Fondo normal."),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackNormal
        {
            get => _backNormal;
            set { _backNormal = value; Invalidate(); }
        }
        public bool ShouldSerializeBackNormal() => _backNormal != Color.FromArgb(40, 40, 40);
        public void ResetBackNormal() => BackNormal = Color.FromArgb(40, 40, 40);

        private Color _backHover = Color.FromArgb(55, 55, 55);
        [Category("Apariencia"), Description("Fondo al pasar el mouse."),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackHover
        {
            get => _backHover;
            set { _backHover = value; Invalidate(); }
        }
        public bool ShouldSerializeBackHover() => _backHover != Color.FromArgb(55, 55, 55);
        public void ResetBackHover() => BackHover = Color.FromArgb(55, 55, 55);

        private Color _backPressed = Color.FromArgb(25, 25, 25);
        [Category("Apariencia"), Description("Fondo al presionar."),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackPressed
        {
            get => _backPressed;
            set { _backPressed = value; Invalidate(); }
        }
        public bool ShouldSerializeBackPressed() => _backPressed != Color.FromArgb(25, 25, 25);
        public void ResetBackPressed() => BackPressed = Color.FromArgb(25, 25, 25);

        // --------- Comportamiento ----------
        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _pressed = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { if (e.Button == MouseButtons.Left) { _pressed = true; Invalidate(); } base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _pressed = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnSizeChanged(EventArgs e) { base.OnSizeChanged(e); UpdateRegion(); }

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

        private void UpdateRegion()
        {
            using var p = Rounded(ClientRectangle, CornerRadius);
            Region = new Region(p);
        }

        private static GraphicsPath Rounded(Rectangle r, int rad)
        {
            if (rad <= 0) { var p0 = new GraphicsPath(); p0.AddRectangle(r); return p0; }
            int d = rad * 2; var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure(); return p;
        }
    }
}
