using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.DesktopToolsWidget
{
    public partial class WidgetWnd : Form
    {
        public WidgetWnd()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemExitWnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WidgetWnd_Activated(object sender, EventArgs e)
        {
            
        }

        private void WidgetWnd_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void WidgetWnd_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Trace.WriteLine("Point=" + e.Location);
                _ContextMenuStrip.SetBounds(
                    //e.X, e.Y,
                    Location.X, Location.Y,
                    _ContextMenuStrip.Width, _ContextMenuStrip.Height,
                    BoundsSpecified.Location);

                // TODO: 간혈적으로 왼쪽 상단에 뜨는현상 개선 필요
                _ContextMenuStrip.Show();
            }
        }
    }
}
