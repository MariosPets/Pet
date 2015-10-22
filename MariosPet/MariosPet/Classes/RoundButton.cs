using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MariosPet.Classes
{
    class RoundButton : Button
    {
        protected override void OnResize(EventArgs e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(2, 2, this.Width - 4, this.Height - 4));
                this.Region = new Region(path);
            }
            base.OnResize(e);
        }
    }
}
