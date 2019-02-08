﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace League_All_in_One
{
    public class FlatStatusBar : Control
    {
        private int W;
        private int H;
        private bool _ShowTimeDate = false;

        protected override void CreateHandle()
        {
            base.CreateHandle();
            Dock = DockStyle.Bottom;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        [Category("Colors")]
        public Color BaseColor
        {
            get { return _BaseColor; }
            set { _BaseColor = value; }
        }

        [Category("Colors")]
        public Color TextColor
        {
            get { return _TextColor; }
            set { _TextColor = value; }
        }

        [Category("Colors")]
        public Color RectColor
        {
            get { return _RectColor; }
            set { _RectColor = value; }
        }

        public bool ShowTimeDate
        {
            get { return _ShowTimeDate; }
            set { _ShowTimeDate = value; }
        }

        public string GetTimeDate()
        {
            return DateTime.Now.Date + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute;
        }

        private Color _BaseColor = Color.FromArgb(51, 51, 51);
        private Color _TextColor = Color.White;
        private Color _RectColor = Color.FromArgb(45, 47, 49);

        public FlatStatusBar()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 8);
            ForeColor = Color.White;
            Size = new Size(Width, 20);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);
            W = Width;
            H = Height;

            Rectangle Base = new Rectangle(0, 0, W, H);

            var _with21 = G;
            _with21.SmoothingMode = SmoothingMode.HighQuality;
            _with21.PixelOffsetMode = PixelOffsetMode.HighQuality;
            _with21.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            _with21.Clear(BaseColor);

            //-- Base
            _with21.FillRectangle(new SolidBrush(BaseColor), Base);

            //-- Text
            _with21.DrawString(Text, Font, Brushes.White, new Rectangle(10, 4, W, H), Helpers.NearSF);

            //-- Rectangle
            _with21.FillRectangle(new SolidBrush(RectColor), new Rectangle(4, 4, 4, 14));

            //-- TimeDate
            if (ShowTimeDate)
            {
                _with21.DrawString(GetTimeDate(), Font, new SolidBrush(TextColor), new Rectangle(-4, 2, W, H), new StringFormat
                {
                    Alignment = StringAlignment.Far,
                    LineAlignment = StringAlignment.Center
                });
            }

            base.OnPaint(e);
            G.Dispose();
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImageUnscaled(B, 0, 0);
            B.Dispose();
        }
    }
}