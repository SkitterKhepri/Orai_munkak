using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegalas
{
    internal class Program
    {
        delegate int Muvelet(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine(Szamolo.Szorzas(2, 3));

            Muvelet m1 = Szamolo.Szorzas;
            Console.WriteLine(m1(12, 12));

            Muvelet m2 = (new Szamolo()).Hatvanyozas;
            Console.WriteLine(m2(2, 12));

            Console.ReadKey();
        }



    }


    class Szamolo
    {
        public static int Szorzas(int szorzando, int szorzo)
        {
            int szorzat = szorzando;

            for (int db = 1; db < szorzo; db++)
            {
                szorzat += szorzando;
            }

            return szorzat;
        }

        public int Hatvanyozas(int alap, int kitevo)
        {
            int hatvany = 1;

            for (int db = 1; db <= kitevo; db++)
            {
                hatvany *= alap;
            }

            return hatvany;
        }

        public static void Hatvany(int alap, int kitevo)
        {

        }
    }
}
