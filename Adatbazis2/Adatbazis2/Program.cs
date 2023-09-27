using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Adatbazis2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*SqlConnection k1 = new SqlConnection("Data Source = LocalDB\\MssqlLocalDB;AttachDbFilename=C:\\Users\Tanar\source\repos\\Adatbazis2\Adatbazis2\MSSQldatabase.mdf;Interated Security=true");
            k1.Open();*/
            /*MySqlconnection k2 = new MySqlConnection("SERVER = 127.0.0.1;usernam = root; password=");
            k2.open();*/
            /*SQLiteConnection k3 = new SQLiteConnection("Data Source = adatbazis.db");
            k3.Open();
            try
            {
                p = new SQLiteCommand("CREATE TABLE tabla(id INT PRIMARY KEY, szoveg VARCHAR(20));", k3);
                p.ExecuteNonQuery();
            } catch{ }
            p = new SQLiteCommand("insert into table values (123, 'Valami');", k3);
            p.ExecuteNonQuery();*/

            if (!File.Exists("primszamok.db"))
            {
                SQLiteConnection k1 = new SQLiteConnection("primszamok.db");
                k1.Open();
                SQLiteCommand p = new SQLiteCommand("CREATE TABLE primek(szam INT);", k1);
                p.ExecuteNonQuery();
                k1.Close();
            }
            SQLiteConnection k = new SQLiteConnection("primszamok.db");
            k.Open();
            int db = 1;
            while (db <= 2)
            {
                int vsz = (new Random()).Next(1000, 9999);
                bool van = false;
                for (int oszto = 2; oszto * oszto <= vsz; oszto++)
                {
                    if (vsz % oszto == 0)
                    {
                        van = true;
                        break;
                    }
                }
                if (!van)
                {
                    SQLiteCommand p = new SQLiteCommand("SELECT szam FROM primek WHERE szam=@vsz;", k);
                    p.Parameters.AddWithValue("@vsz", vsz);
                    SQLiteDataReader r = p.ExecuteReader();

                    if (!r.Read())
                    {
                        p = new SQLiteCommand("INSERT INTO primek VALUES (@vsz);", k);
                        p.Parameters.AddWithValue("@vsz", vsz);
                        p.ExecuteNonQuery();
                        db++;
                    }

                }
            }
        }
    }
 }


