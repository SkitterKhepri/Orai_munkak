using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Robotos2
{
    public partial class Form1 : Form
    {
        bool beszeles = false;
        bool cikazas = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Beszel(string szoveg)
        {
            char[] betuk = szoveg.ToCharArray();
            textBox1.Text = "";

            foreach (char c in betuk) 
            {
                textBox1.Text += c;
                Thread.Sleep(1000);
                Application.DoEvents();
            }
        }

        private void Mozog(string utvonal)
        {
            char[] iranyok = utvonal.ToCharArray();
            foreach(char c in iranyok)
            {
                switch (c)
                {
                    case 'n':
                    case 'N':
                        robot.Top -= 10;
                        break;

                    case 's':
                    case 'S':
                        robot.Top += 10;
                        break;

                    case 'e':
                    case 'E':
                        robot.Left += 10;
                        break;

                    case 'w':
                    case 'W':
                        robot.Left -= 10;
                        break;
                }

                Thread.Sleep(2000);
                Application.DoEvents();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!beszeles)
                {
                    robot.aztCsinal += new MitTud(Beszel);
                    beszeles = true;
                }

            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (!cikazas)
                {
                    robot.aztCsinal += new MitTud(Mozog);
                    cikazas = true;
                }

            }
            this.robot.Mutat();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!beszeles)
                {
                    robot.aztCsinal += new MitTud(Beszel);
                    beszeles = true;
                }

            }
            else if (e.KeyCode == Keys.Tab)
            {
                if (!cikazas)
                {
                    robot.aztCsinal += new MitTud(Mozog);
                    cikazas = true;
                }

            }
            this.robot.Mutat();
        }
    }
}
