using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottojatekok
{
    public partial class Form1 : Form
    {
        
        Szelveny szelveny;
        public Form1()
        {
            InitializeComponent();
        }

        private void ötösLottóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
            {
                //MessageBox.Show(f1.Text);
                //f1.Close();
                f1.Dispose();
            }

            Form2 f = new Form2();

            f.Text = "Ötös lottószelvény";
            f.Size = new Size((int)(this.Width*.8), (int)(this.Height*.85));
            f.MdiParent = this;

            if (szelveny != null) f.Controls.Remove(szelveny);
            szelveny = new Szelveny(9, 10, 5, f);

            f.Controls.Add(szelveny);
            f.Move += F_Move;
            f.Show();
            
        }
        private void F_Move(object o,EventArgs e)
        {
            ((Form)o).Location = new Point(0, 0);
        }


        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hatosLottóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
            {
                f1.Dispose();
            }
            Form2 f = new Form2();
            f.Text = "Hatos lottószelvény";
            f.Size = new Size((int)(this.Width * .75), (int)(this.Height * .60));
            f.MdiParent = this;

            if (szelveny != null) f.Controls.Remove(szelveny);
            szelveny = new Szelveny(5, 9, 6, f);

            f.Controls.Add(szelveny);
            f.Move += F_Move;
            f.Show();
        }

        private void skandinávLottóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f1 in this.MdiChildren)
            {
                f1.Dispose();
            }
            Form2 f = new Form2();
            f.Text = "Skandináv lottószelvény";
            f.Size = new Size((int)(this.Width * .7), (int)(this.Height * .60));
            f.MdiParent = this;

            if (szelveny != null) f.Controls.Remove(szelveny);
            szelveny = new Szelveny(5, 7, 7, f);

            f.Controls.Add(szelveny);
            f.Move += F_Move;
            f.Show();
        }
    }
}
