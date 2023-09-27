using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.IO;

namespace adatbazis1
{
    internal class Program
    {

        static SqlConnection conn;

        static void Main(string[] args)
        {

            /*SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Diak\Desktop\idegen\Orai_munkak\adatbazis1\adatbazis1\Database1.mdf;Integrated Security=True");


            try
            {
                conn.Open();
            }
            catch (Exception e)
            {

                throw;
            }

            int vsz = (new Random().Next(100, 1000));

            string nev = "Gipsz Jakab";

            DateTime datum = DateTime.Today;
            string d = "";
            d += datum.Year;
            d += "-";
            d += datum.Month;
            d += "-";
            d += datum.Day;

            //SqlCommand parancs = new SqlCommand($"INSERT INTO Alapadatok VALUES({vsz},'{nev}','{d}');", conn);

            SqlCommand parancs = new SqlCommand("INSERT INTO Alapadatok VALUES(@vsz, @nev, @datum);", conn);

            parancs.Parameters.AddWithValue("@vsz", vsz);
            parancs.Parameters.AddWithValue("@nev", nev);
            parancs.Parameters.AddWithValue("@datum", datum);

            parancs.ExecuteNonQuery();

            conn.Close();*/

            //(new Program()).FileFeldolgozas("zenek.txt");                 <-----jó cucc

            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Diak\Desktop\idegen\Orai_munkak\adatbazis1\adatbazis1\Database1.mdf;Integrated Security=True");

            conn.Open();

            RadioAdok();

            Tablak();

            FileFeldolgozas("zenek.txt");




            conn.Close();

        }

        static void FileFeldolgozas(string filename)
        {

            StreamReader reader = new StreamReader(filename);

        }


        static void RadioAdok()
        {

            string utasitas = "CREATE TABLE radiok (kod INT PRIMARY KEY, nev NVARCHAR(20));";

            SqlCommand p = new SqlCommand(utasitas, conn);

            try
            {
                p.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex);
            }

            utasitas = "INSERT INTO radiok VALUES(1, 'Retro Rádió');";
            p = new SqlCommand(utasitas, conn);
            try
            {
                p.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            utasitas = "INSERT INTO radiok VALUES(2, 'RÁDIÓ 1');";
            p = new SqlCommand(utasitas, conn);
            try
            {
                p.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            utasitas = "INSERT INTO radiok VALUES(3, 'Glow Worm Rádió');";
            p = new SqlCommand(utasitas, conn);
            try
            {
                p.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

        }

        static void Tablak()
        {

            //string utasitas = "SHOW TABLES;";

            string u = "SELECT * FROM SYSOBJECTS WHERE xtype = 'u';";

            SqlCommand p = new SqlCommand(u, conn);
            SqlDataReader r = p.ExecuteReader();

            while (r.Read())
            {
                //Console.WriteLine(r[0].ToString());

                foreach (var a in r)
                {

                    Console.WriteLine(a.ToString());

                }
            }

        }


        // milyen táblák, hogy ledkevéssbéé redundáns legyen? hogy néznek ki, sql-je
    }
}
