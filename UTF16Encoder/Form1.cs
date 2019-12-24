using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTF16Encoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputString = txtPlain.Text;
            byte[] stringBytes = Encoding.Unicode.GetBytes(inputString);
            char[] stringChars = Encoding.Unicode.GetChars(stringBytes);
            StringBuilder builder = new StringBuilder();
            Array.ForEach<char>(stringChars, c => builder.AppendFormat("\\u{0:X4}", (int)c));
            txtEncoded.Text = builder.ToString();
            Clipboard.SetText(txtEncoded.Text);

        }

        private void btnConvertToPlain_Click(object sender, EventArgs e)
        {
            string result = "";
            string[] chars = txtEncoded.Text.Trim().Split(new string[] { "\\u" }, StringSplitOptions.None);
            string conc = "";
            foreach (string str in chars)
            {
                if (!string.IsNullOrEmpty(str))
                {
                    string p1 = str.Substring(0, 2);
                    string p2 = str.Substring(2, 2);
                    conc += p2 + p1;
                }
            }
            byte[] res = ConvertHexStringToByteArray(conc);
            string resultg = System.Text.Encoding.UTF8.GetString(res);
            UnicodeEncoding unicode = new UnicodeEncoding();
            String decodedString = unicode.GetString(res);
            txtPlain.Text = decodedString;
            Clipboard.SetText(decodedString);
        }

        public static byte[] ConvertHexStringToByteArray(string hexString)
        {
            if (hexString.Length % 2 != 0)
            {
                throw new ArgumentException("");
            }

            byte[] data = new byte[hexString.Length / 2];
            for (int index = 0; index < data.Length; index++)
            {
                string byteValue = hexString.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
        }

        private void btnPasteClipboardPlainText_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                txtPlain.Text = Clipboard.GetText(TextDataFormat.Text);
                // Do whatever you need to do with clipboardText
            }
        }

        private void btnPasteClipboardEncoded_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                txtEncoded.Text = Clipboard.GetText(TextDataFormat.Text);
                // Do whatever you need to do with clipboardText
            }
        }

        private void btnClearPlain_Click(object sender, EventArgs e)
        {
            txtPlain.Text = "";
        }

        private void btnClearEncoded_Click(object sender, EventArgs e)
        {
            txtEncoded.Text = "";
        }
    }
}
