using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.DesktopToolsWidget.Widgets;

namespace WinForm.DesktopToolsWidget
{
    public partial class MainForm : Form
    {
        private WidgetWnd _WidgetWndAsCodeConverter;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;

            _ToolStripMenuItemAsCodeConverter.Checked = false;
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void ToolStripMenuItemAsCodeConverter_Click(object sender, EventArgs e)
        {
            _ToolStripMenuItemAsCodeConverter.Checked = !_ToolStripMenuItemAsCodeConverter.Checked;
            if (_ToolStripMenuItemAsCodeConverter.Checked)
            {
                _WidgetWndAsCodeConverter = new WidgetWnd();
                _WidgetWndAsCodeConverter.Controls.Add(new AsCodeConverterWidget());
                _WidgetWndAsCodeConverter.Show();
            }
            else
            {
                _WidgetWndAsCodeConverter.Close();
                _WidgetWndAsCodeConverter = null;
            }            
        }

        private void ToolStripMenuItemApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
