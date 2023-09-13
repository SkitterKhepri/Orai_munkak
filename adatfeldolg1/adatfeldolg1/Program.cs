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

            List<Zene> zenek = new List<Zene>();

            StreamReader reader = new StreamReader("zenek.txt");

            while (!reader.EndOfStream)
            {

                Zene z = new Zene(reader.ReadLine());
                zenek.Add(z);

            }

            
            reader.Close();

            /*
            foreach (Zene korte in z)
            {
                //Console.WriteLine(korte.ado);
            }
            */

            var linq1 = from zene in zenek
                        select new
                        {
                            Ado = zene.Ado,
                            Perc = zene.Perc,
                            Masodperc = zene.Masodperc
                        };



            foreach (var z in linq1)
            {
                Console.WriteLine($"{z.Ado}. rádióadó: {z.Perc, 2:00}.{z.Masodperc, -2:00}");
            }

            int[] a = { 1, 2, 4, 7 };
            int[] b = { 1, 3, 5, 6, 7 };

            //Console.WriteLine(a.Union(b));

            Console.Write("{");

            foreach (var elem in a.Union(b).OrderBy(x => x*-1))
            {
                Console.Write(elem + " ");

            }

            Console.WriteLine("}");

            var linq2 = from adat in linq1
                        group adat by adat.Ado
                        into csoport
                        select new
                        {
                            Ado = csoport.Key,
                            Ora = csoport.Sum(sor => sor.Perc) / 60,
                            Perc = (csoport.Sum(sor => sor.Masodperc) / 60 + csoport.Sum(sor => sor.Perc)) % 60,
                            Masodperc = (csoport.Sum(sor => sor.Masodperc) + csoport.Sum(sor => sor.Masodperc)) % 60
                        };



            foreach (var adat in linq2.OrderByDescending(w => DateTime.Parse(w.Ora + ":" + w.Perc + ":" + w.Masodperc)))
            {
                Console.WriteLine($"{adat.Ado}. rádióadó: {adat.Ora, 2:00}:{adat.Perc, 2:00}:{adat.Masodperc, 2:00}");
            }

        }
    }
}
