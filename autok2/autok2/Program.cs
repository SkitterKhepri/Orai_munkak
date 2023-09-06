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

    }

    class Program
    {
        static void Main(string[] args)
        {

            Car c = new Car();

            Auto a = new Auto();

        }
    }
}
