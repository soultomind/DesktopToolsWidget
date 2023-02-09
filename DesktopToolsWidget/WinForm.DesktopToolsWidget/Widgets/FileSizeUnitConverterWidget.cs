using DesktopToolsWidget.Common;
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

namespace WinForm.DesktopToolsWidget.Widgets
{
    public partial class FileSizeUnitConverterWidget : BaseWidget
    {
        public FileSizeUnitConverterWidget()
        {
            InitializeComponent();
        }

        private void TextBoxSize_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                if (textBox.TextLength > 0)
                {
                    double size = double.Parse(textBox.Text);
                    string convertSize = String.Empty;
                    if (FileSizeUnit.TryConvertSize(size, out convertSize))
                    {
                        _TextBoxConvertSize.Text = convertSize;
                    }
                }
                else
                {
                    _TextBoxConvertSize.Text = String.Empty;
                }

                _LabelFileSizeUnitLength.Text = String.Format("TextLength : {0}", textBox.TextLength);
            }
        }

        private void TextBoxSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || 
                  (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back) || 
                  (e.KeyCode == Keys.Home || e.KeyCode == Keys.End))
            )

            {
                e.SuppressKeyPress = true;
                return;
            }
        }
    }
}
