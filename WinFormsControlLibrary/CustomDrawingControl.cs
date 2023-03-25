using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsControlLibrary
{
    public partial class CustomDrawingControl : Control
    {
        public CustomDrawingControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            var pen = new Pen(ForeColor);
            var p1 = new Point(Width / 2, Top);
            var p2 = new Point(Width / 2, Bottom);
            pe.Graphics.DrawLine(pen, p1, p2);
            base.OnPaint(pe);
        }
    }
}
