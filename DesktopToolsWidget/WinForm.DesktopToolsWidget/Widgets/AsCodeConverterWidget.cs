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
            ContextMenu contextMenu = new ContextMenu();
            MenuItem menuItemExit = new MenuItem();
            menuItemExit.Text = "Exit";
            menuItemExit.Click += MenuItemExit_Click;
            contextMenu.MenuItems.Add(menuItemExit);
            _LabelTitleAsCodeConverter.ContextMenu = contextMenu;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                char[] codes = textBox.Text.ToCharArray();
                AsCode asCode = AsCode.ConvetCode(codes, " ");

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

        private void _LabelTitleAsCodeConverter_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titleMousePoint = new Point(e.X, e.Y);
            }
        }

        private void _LabelTitleAsCodeConverter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && _titleMousePoint != Point.Empty)
            {
                Form form = ParentForm;
                form.Location = new Point(
                    form.Location.X - (_titleMousePoint.X - e.X),
                    form.Location.Y - (_titleMousePoint.Y - e.Y)
                );
            }
        }

        private void _LabelTitleAsCodeConverter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _titleMousePoint = Point.Empty;
            }
        }
    }
}
