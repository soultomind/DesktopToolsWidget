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
    }
}
