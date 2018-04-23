using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CustomDraw {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void customBarAndDockingController1_CustomDraw(object sender, CustomDrawLinkArgs e) {
            e.DefaultDraw();
            string itemCaption = e.Info.LinkInfo.Link.Item.Caption;
            if (itemCaption == "Green item")
                using (Pen p = new Pen(Color.ForestGreen) { Width = 3 })
                    e.Graphics.DrawRectangle(p, e.Info.LinkInfo.CaptionRect);
            if (itemCaption == "See Messages   ") {
                int side = 15;
                Rectangle iconRect = new Rectangle(e.Bounds.Right - side, e.Bounds.Y,side, side);
                e.Graphics.FillEllipse(Brushes.IndianRed, iconRect);
                Point p = new Point(iconRect.Location.X + 2, iconRect.Location.Y);
                e.Graphics.DrawString(spinEdit1.Value.ToString(), e.Info.LinkInfo.AppearanceMenuItemCaption.Normal.Font, Brushes.White, p);
            }
            if (itemCaption == "Static text") {
                using (SolidBrush br = new SolidBrush(Color.FromArgb(100, 50, 200, 50)))
                    e.Graphics.FillRectangle(br, e.Info.LinkInfo.Bounds);
            }
            e.Handled = true;
        }

        private void spinEdit1_EditValueChanged(object sender, EventArgs e) {
            barButtonItem2.Refresh();
        }
    }
}
