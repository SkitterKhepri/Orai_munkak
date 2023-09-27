using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sikidomok2
{
    public partial class Form1 : Form
    {

        private int kattintas = 0;
        private String csucsok = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics rajzlap = ((Panel)sender).CreateGraphics();
            rajzlap.FillRectangle(new SolidBrush(Color.Yellow), e.X, e.Y, 7, 7);
            kattintas++;
            csucsok += "(" + e.X + "," + e.Y + ")";

            if (kattintas >= 3) 
            {
                this.textBox1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text.Length > 0)
            {
                this.button1.Enabled = true;
            }
            else 
            { 
                this.button1.Enabled = false; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn1 = null;
            SQLiteConnection conn2 = null;

            try
            {
                conn1 = new MySqlConnection("SERVER=127.0.0.1;USERNAME=root;password=;DATABASE=sikidomok;");

                bool kell = false;
                if (File.Exists("sikidomok.db"))
                {
                    kell = false;
                }
                else
                {
                    kell = true;
                }

                conn2 = new SQLiteConnection("Data Source=sikidomok.db;");

                conn2.Open();
                if (kell)
                {
                    SQLiteCommand p = new SQLiteCommand("CREATE TABLE sikidomok(nev VARCHAR(20), koordinatak VARCHAR(20));");
                    p.ExecuteNonQuery();
                }

                SQLiteCommand u = new SQLiteCommand("INSERT INTO sikidomok VALUES(@nev, @koordinatak);");
                u.Parameters.AddWithValue("@nev", this.textBox1.Text);
                u.Parameters.AddWithValue("@koordinatak", csucsok);
                u.ExecuteNonQuery();


            }
            catch(Exception ex)
            {

            }

            conn1.Close();
            conn2.Close();

            (this.panel1.CreateGraphics()).Clear(Color.DeepPink);
            this.textBox1.Text = "";
            this.textBox1.Enabled = false;


        }
    }
}
