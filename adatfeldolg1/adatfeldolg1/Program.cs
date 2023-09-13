using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adatfeldolg1
{

    struct Zene
    {

        int ado;
        int perc;
        int masodperc;
        string eloado;
        string cim;


        public int Ado {
            get
            {
                return ado;
            }
        }

        public int Perc
        {
            get
            {
                return perc;
            }
        }
        public int Masodperc
        {
            get
            {
                return masodperc;
            }
        }
        public string Eloado
        {
            get
            {
                return eloado;
            }
        }
        public string Cim
        {
            get
            {
                return cim;
            }
        }

        public Zene(string sor)
        {

            string[] splitSor = sor.Split(':');

            cim = splitSor[1];
            string[] split2Sor = splitSor[0].Split(' ');

            ado = int.Parse(split2Sor[0]);
            perc = int.Parse(split2Sor[1]);
            masodperc = int.Parse(split2Sor[2]);
            //eloado = split2Sor[3];
            eloado = "";
            for (int i = 3; i < split2Sor.Length; i++)
            {

                eloado += split2Sor[i] + " ";
                
            }
            eloado = eloado.Trim();
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {

            List<Zene> z = new List<Zene> ();

            StreamReader reader = new StreamReader("zenek.txt");

            while (!reader.EndOfStream)
            {

                Zene zenecske = new Zene (reader.ReadLine());
                z.Add(zenecske);

            }

            Console.ReadKey();
            reader.Close();


        }
    }
}
