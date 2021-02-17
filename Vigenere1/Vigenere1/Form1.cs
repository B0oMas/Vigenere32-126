using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text;
            string key = richTextBox3.Text;
            string encyption = "";
            int j = 0;
            for (int i = 0; i < text.Length; i++)
            {

                // Sifravimas

                if ((((text[i] + key[j]) % 126) + 95) > 127)
                    encyption += (char)((((text[i] + key[j]) % 127) + 96) - 96);

                else encyption += (char)(((text[i] + key[j]) % 127) + 95);

                // rakto ilgis

                j = j + 1 == key.Length ? 0 : j + 1;

                // Isvestis

                richTextBox2.Text = encyption;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Cipher = richTextBox2.Text;
            string key = richTextBox3.Text;
            string decryption = "";
            int j = 0;
            for (int i = 0; i < Cipher.Length; i++)
            {

                // Issifravimas
                if (((32 + (Cipher[i] - key[j])) % 126) <= 31)
                    decryption += (char)(((32 + (Cipher[i] - key[j])) % 126) + 95);

                else if (((32 + (Cipher[i] - key[j])) % 126) >= 127)

                    decryption += (char)(((32 + (Cipher[i] - key[j])) % 126) - 95);

                else decryption += (char)((32 + (Cipher[i] - key[j])) % 126);

                // rakto ilgis

                j = j + 1 == key.Length ? 0 : j + 1;

                // Isvestis    

                richTextBox1.Text = decryption;
            }
        }
    }
}
