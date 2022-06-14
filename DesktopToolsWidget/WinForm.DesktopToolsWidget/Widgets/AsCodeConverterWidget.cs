using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.DesktopToolsWidget.Widgets
{
    public partial class AsCodeConverterWidget : BaseWidgetControl
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
        public AsCodeConverterWidget()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                char[] asCodes = textBox.Text.ToCharArray();

                int asCodeDecimal = 0;

                string strHexdecimal = String.Empty,
                       strDecimal = String.Empty,
                       strOctal = String.Empty,
                       strBinary = String.Empty;

                foreach (var asCode in asCodes)
                {
                    asCodeDecimal = Convert.ToInt32(asCode);

                    strHexdecimal += "0x" + Convert.ToString(asCodeDecimal, 16) + Separator;
                    strDecimal += asCodeDecimal.ToString() + Separator;
                    strOctal += Convert.ToString(asCodeDecimal, 8) + Separator;
                    strBinary += Convert.ToString(asCodeDecimal, 2) + Separator;
                }

                // Hexa
                _TextBoxHexadecimal.Text = strHexdecimal;

                // Decimal
                _TextBoxDecimal.Text = strDecimal;

                // Octal
                _TextboxOctal.Text = strOctal;

                // Binary
                _TextBoxBinary.Text = strBinary;
            }
        }
    }
}
