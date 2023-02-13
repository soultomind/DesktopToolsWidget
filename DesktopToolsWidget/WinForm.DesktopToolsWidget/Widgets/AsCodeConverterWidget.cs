using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DesktopToolsWidget.Common;

namespace WinForm.DesktopToolsWidget.Widgets
{
    public partial class AsCodeConverterWidget : BaseWidget
    {
        public string Separator
        {
            get { return _separator; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (value.Length == 0)
                {
                    throw new ArgumentException();
                }

                _separator = value;
            }
        }
        private string _separator = " ";
        private Point _titleMousePoint = Point.Empty;
        public AsCodeConverterWidget()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void AsCodeConverterWidget_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                char[] codes = textBox.Text.ToCharArray();
                AsCode asCode = AsCode.ConvetCode(codes, _separator);

                // Hexa
                _TextBoxHexadecimal.Text = asCode.Hexadecimal;

                // Decimal
                _TextBoxDecimal.Text = asCode.Decimal;

                // Octal
                _TextboxOctal.Text = asCode.Octal;

                // Binary
                _TextBoxBinary.Text = asCode.Binary;
            }
        }
    }
}
