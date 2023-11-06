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

namespace Lottojatekok
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string oke = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyz ";

            if (!oke.Contains(e.KeyChar) && (!oke.ToUpper().Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
            /*
            if((e.KeyChar < 'A' || e.KeyChar > 'Z') && (e.KeyChar < 'a' || e.KeyChar > 'z') && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
            */
            Regex rx = new Regex("\\w{2,} \\w{3,}");




            if(rx.IsMatch(textBox1.Text + e.KeyChar))
            {
                button1.Enabled = true;
            }
        }
    }
}
