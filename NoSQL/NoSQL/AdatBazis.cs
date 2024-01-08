using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoSQL
{
    public class AdatBazis
    {

        public List<Jarmu> Jarmuvek;
        public Parkolas[] Parkolasok;

    }
    public class Jarmu
    {
        public string Rendszam;
    }
    public class Parkolas
    {
        public int sorszam;
        public string Rendszam;
        public DateTime kezdet;
        public DateTime? veg;
    }
}
