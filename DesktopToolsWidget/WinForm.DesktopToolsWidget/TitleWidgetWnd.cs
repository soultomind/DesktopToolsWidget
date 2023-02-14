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
    public partial class TitleWidgetWnd : Form
    {
        private Point _titlePoint = Point.Empty;
        public TitleWidgetWnd()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return _LabelTitle.Text; }
            set { _LabelTitle.Text = value; }
        }

        public TableLayoutPanel TableLayoutPanel
        {
            get { return _TableLayoutPanel; }
        }

        private void ToolStripMenuItemExitWnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titlePoint = new Point(e.X, e.Y);
            }
        }

        private void LabelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _titlePoint != Point.Empty)
            {
                this.Location = new Point(
                    this.Location.X - (_titlePoint.X - e.X),
                    this.Location.Y - (_titlePoint.Y - e.Y)
                );
            }
        }

        private void LabelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titlePoint = Point.Empty;
            }
        }
    }
}
