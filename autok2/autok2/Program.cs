using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autok2
{
    struct Car
    {

        int sebesseg;
        string rendszam;

        public int Sebesseg
        {
            get
            {
                return sebesseg;
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    sebesseg = value;
                }
            }

        }

        public string Rendszam
        {

            get { return rendszam; }

            set { rendszam = value; }

        }

    }

    class Auto
    {

        int sebesseg;
        string rendszam;
        public int Sebesseg
        {
            get 
            { 
                return sebesseg; 
            }

            set
            {
                if (value > 0 && value < 6)
                {
                    sebesseg = value;
                }
            }

        }

        public string Rendszam
        {

            get { return rendszam; }

            set { rendszam = value; }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            /*
            Car c = new Car();
            Auto a = new Auto();
            */

            Random veletlen = new Random();

            Car[] autok1 = new Car[5];
            Auto[] autok2 = new Auto[5];

            for (int i = 0; i < autok1.Length; i++)
            {
                char c = (char)(veletlen.Next(0, 26) + 65);
                autok1[i].Sebesseg = veletlen.Next(1, 6);
                
                autok1[i].Rendszam = "";
                autok1[i].Rendszam += c;
                autok1[i].Rendszam += "-";
                autok1[i].Rendszam += autok1[i].Sebesseg;

                autok2[i]= new Auto();
                autok2[i].Sebesseg = veletlen.Next(1, 6);

                

            }
            //foreach (Car a in autok1)
            //{
            //    Console.WriteLine(a.Rendszam);
            //}

            Console.SetCursorPosition(40, 7);
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.Write(autok1[3].Rendszam);
            Console.ReadKey(true);
            Console.Clear();

            Console.SetCursorPosition(40 - autok1[3].Sebesseg, 7);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.Write(autok1[3].Rendszam);
            Console.ReadKey();
        }
    }
}
