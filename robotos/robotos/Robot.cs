using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robotos
{
    delegate void MitTud(string tudas);
    internal class Robot
    {
        char[] tudas;
        public MitTud aztCsinal;
        Button fizimiska;

        public Robot() 
        {
            fizimiska = new Button();
            fizimiska.Text = "Robika";
            fizimiska.Left = (new Random().Next(10, 100));
            fizimiska.Top = (new Random().Next(10, 100));
        }
    }
}
