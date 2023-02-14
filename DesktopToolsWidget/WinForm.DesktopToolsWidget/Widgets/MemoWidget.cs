using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.DesktopToolsWidget.Widgets
{
    public partial class MemoWidget : BaseWidget
    {
        public const string PlaceHolder = "메모를 작성하세요...";

        private Point _titlePoint = Point.Empty;
        public MemoWidget()
        {
            InitializeComponent();

            _RichTextBox.Text = PlaceHolder;
            _RichTextBox.GotFocus += RichTextBox_GotFocus;
            _RichTextBox.LostFocus += RichTextBox_LostFocus;
        }

        private void RichTextBox_GotFocus(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox != null)
            {
                if (richTextBox.Text == PlaceHolder)
                {
                    richTextBox.Text = String.Empty;
                }
            }
        }


        private void RichTextBox_LostFocus(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox != null)
            {
                if (String.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    richTextBox.Text = PlaceHolder;
                }
            }
        }

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titlePoint = new Point(e.X, e.Y);
            }
        }

        private void PanelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _titlePoint != Point.Empty)
            {
                ParentForm.Location = new Point(
                    ParentForm.Location.X - (_titlePoint.X - e.X),
                    ParentForm.Location.Y - (_titlePoint.Y - e.Y)
                );
            }
        }

        private void PanelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titlePoint = Point.Empty;
            }
        }

        private void LabelNewMemo_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ControlDark;
            }
        }

        private void LabelNewMemo_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ControlDarkDark;
            }
        }

        private void LabelNewMemo_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ActiveBorder;
            }
        }


        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ControlDark;
            }
        }

        private void LabelClose_MouseDown(object sender, MouseEventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ControlDarkDark;
            }

            ParentForm.Close();
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                label.BackColor = SystemColors.ActiveBorder;
            }
        }
    }
}
