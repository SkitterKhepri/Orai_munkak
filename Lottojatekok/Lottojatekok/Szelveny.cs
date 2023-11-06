using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottojatekok
{
    internal class Szelveny:TableLayoutPanel
    {
        int tippekszama;
        int db = 0;
        Form2 f;
        public Szelveny(int MaxSor, int MaxOszlop, int tippekszama, Form2 f)
        {
            this.f = f;
            this.tippekszama = tippekszama;
            Width = 800;
            Height = 600;
            Location = new Point(50, 100);
            ColumnCount = MaxOszlop;
            RowCount = MaxSor;
            for (int i = 1; i <= ColumnCount; i++)
            {
                ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            }
            for (int i = 1; i <= RowCount; i++)
            {
                RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            }
            for (int sor = 1; sor <= MaxSor; sor++)
            {
                for (int osz = 1; osz <= MaxOszlop; osz++)
                {
                    CheckBox cb = new CheckBox();
                    cb.Text = "" + ((sor - 1) * MaxOszlop + osz);
                    cb.Width = 80;
                    cb.Height = 17;
                    cb.CheckedChanged += Kattintas;
                    Controls.Add(cb);
                }
            }
        }
        private void Kattintas(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                db++;
            }
            else
            {
                db--;
            }
            if (db == tippekszama)
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb1 = (CheckBox)c;
                        if (!cb1.Checked)
                        {
                            cb1.Enabled = false;
                            
                        }
                    }
                }
                foreach (Control c in f.Controls)
                {
                    if (c is Label) { c.Enabled = true; }
                    if (c is TextBox) { c.Enabled = true; c.Text = ""; }
                }
            }
            else
            {
                foreach (Control c in Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox cb1 = (CheckBox)c;
                        cb1.Enabled = true;
                    }
                }
                foreach (Control c in f.Controls)
                {
                    if (c is Label) {c.Enabled = false;}
                    if (c is TextBox){c.Enabled = false; c.Text = ""; }
                }
            }
        }
    }
}
