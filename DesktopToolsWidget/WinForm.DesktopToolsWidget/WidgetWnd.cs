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
        private MouseHook _mouseHook = new MouseHook();
        public WidgetWnd()
        {
            InitializeComponent();

            _mouseHook = new MouseHook();
            _mouseHook.MouseMoveEvent += MouseHook_MouseMoveEvent;
            _mouseHook.MouseClickEvent += MouseHook_MouseClickEvent;
            _mouseHook.MouseDownEvent += MouseHook_MouseDownEvent;
            _mouseHook.MouseUpEvent += MouseHook_MouseUpEvent;
        }

        private void MouseHook_MouseMoveEvent(object sender, MouseEventArgs e)
        {
            
        }

        private void MouseHook_MouseClickEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Trace.WriteLine("Point=" + e.Location);
                _ContextMenuStrip.SetBounds(
                    e.X, e.Y,
                    _ContextMenuStrip.Width, _ContextMenuStrip.Height,
                    BoundsSpecified.Location);

                // TODO: 간혈적으로 온쪽 상단에 뜨는현상 개선 필요
                _ContextMenuStrip.Show();
            }
        }

        private void MouseHook_MouseDownEvent(object sender, MouseEventArgs e)
        {
            
        }

        private void MouseHook_MouseUpEvent(object sender, MouseEventArgs e)
        {
            
        }
        

        private void ToolStripMenuItemExitWnd_Click(object sender, EventArgs e)
        {
            _mouseHook.UnHook();
            Close();
        }

        private void WidgetWnd_Activated(object sender, EventArgs e)
        {
            _mouseHook.SetHook();
        }

        private void WidgetWnd_Deactivate(object sender, EventArgs e)
        {
            _mouseHook.UnHook();
        }
    }
}
