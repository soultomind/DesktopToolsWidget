using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesktopToolsWidget.Common
{
    public class AsCode
    {
        public char[] Codes
        {
            get
            {
                char[] dest = new char[_codes.Length];
                System.Array.Copy(_codes, 0, dest, 0, dest.Length);
                return dest;
            }
            set
            {
                _codes = value;
            }
        }
        private char[] _codes;

        public string Hexadecimal
        {
            get { return _hexadecimal; }
            internal set { _hexadecimal = value; }
        }
        private string _hexadecimal;

        public string Decimal
        {
            get { return _decimal; }
            internal set { _decimal = value; }
        }
        private string _decimal;

        public string Octal
        {
            get { return _octal; }
            internal set { _octal = value; }
        }
        private string _octal;

        public string Binary
        {
            get { return _binary; }
            internal set { _binary = value; }
        }
        private string _binary;

        private AsCode(char[] codes)
        {
            _codes = codes;
        }

        public static AsCode ConvetCode(char[] codes, string separator)
        {
            int asCodeDecimal = 0;

            string asHexadecimal = String.Empty, asDecimal = String.Empty, asOctal = String.Empty, asBinary = String.Empty;
            foreach (char code in codes)
            {
                asCodeDecimal = Convert.ToInt32(code);

                asHexadecimal += "0x" + Convert.ToString(asCodeDecimal, 16) + separator;
                asDecimal += asCodeDecimal.ToString() + separator;
                asOctal += Convert.ToString(asCodeDecimal, 8) + separator;
                asBinary += Convert.ToString(asCodeDecimal, 2) + separator;
            }

            return new AsCode(codes) { Hexadecimal = asHexadecimal, Decimal = asDecimal, Octal = asOctal, Binary = asBinary };
        }
    }
}
