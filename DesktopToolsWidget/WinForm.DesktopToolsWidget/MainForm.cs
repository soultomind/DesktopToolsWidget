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
        private WidgetWnd _WidgetWndFileSizeConverter;
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
            _ToolStripMenuItemFileSizeUnitConverter.Checked = false;
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
                _WidgetWndAsCodeConverter.Text = _ToolStripMenuItemAsCodeConverter.Text;
                _WidgetWndAsCodeConverter.Title = _ToolStripMenuItemAsCodeConverter.Text;
                _WidgetWndAsCodeConverter.TableLayoutPanel.Controls.Add(new AsCodeConverterWidget(), 0, 1);

                _WidgetWndAsCodeConverter.FormClosed += WidgetWndAsCodeConverter_FormClosed;
                _WidgetWndAsCodeConverter.Show();
            }
            else
            {
                _WidgetWndAsCodeConverter.Close();
            }            
        }

        private void WidgetWndAsCodeConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ToolStripMenuItemAsCodeConverter.Checked = false;
            _WidgetWndAsCodeConverter = null;
        }

        private void ToolStripMenuItemFileSizeUnitConverter_Click(object sender, EventArgs e)
        {
            _ToolStripMenuItemFileSizeUnitConverter.Checked = !_ToolStripMenuItemFileSizeUnitConverter.Checked;
            if (_ToolStripMenuItemFileSizeUnitConverter.Checked)
            {
                _WidgetWndFileSizeConverter = new WidgetWnd();
                _WidgetWndFileSizeConverter.Text = _ToolStripMenuItemFileSizeUnitConverter.Text;
                _WidgetWndFileSizeConverter.Title = _ToolStripMenuItemFileSizeUnitConverter.Text;
                _WidgetWndFileSizeConverter.TableLayoutPanel.Controls.Add(new FileSizeUnitConverterWidget(), 0, 1);

                _WidgetWndFileSizeConverter.FormClosed += WidgetWndFileSizeUnitConverter_FormClosed;
                _WidgetWndFileSizeConverter.Show();
            }
            else
            {
                _WidgetWndFileSizeConverter.Close();
            }
        }

        private void WidgetWndFileSizeUnitConverter_FormClosed(object sender, FormClosedEventArgs e)
        {
            _ToolStripMenuItemAsCodeConverter.Checked = false;
            _WidgetWndFileSizeConverter = null;
        }

        private void ToolStripMenuItemApplicationExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
