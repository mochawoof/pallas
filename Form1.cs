using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
namespace pallas
{
    public partial class Form1 : Form
    {
        public Form1(string[] args)
        {
            InitializeComponent();
            if (args != null && args.Length > 0 && args[0].Equals("f"))
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject("i" + new Random().Next(1, Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true).Cast<object>().Count()));

            Bitmap ico = new Bitmap(48, 48);
            using (Graphics g = Graphics.FromImage(ico))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;
                g.DrawImage(BackgroundImage, 0, 0, ico.Width, ico.Height);
            }
                Icon = Icon.FromHandle(ico.GetHicon());
        }
    }
}