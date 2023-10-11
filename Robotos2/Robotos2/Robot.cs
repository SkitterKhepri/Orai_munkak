using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robotos2
{
    public delegate void MitTud(object sender, EventArgs e);
    internal class Robot : Button
    {
        char[] tudas = {'N', 'E', 'W', 'S' };
        public MitTud aztCsinal;
        public Robot() 
        {
            this.Text = "R. Daneel";
        }
        public void Mutat()
        {
            Visible = false;
            Visible = true;

            if (aztCsinal != null)
            {
                string atadando = "";
                foreach (char c in tudas)
                {
                    atadando += c;
                }
                aztCsinal(atadando);
            }
        }
    }
}
