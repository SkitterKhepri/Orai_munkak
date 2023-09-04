using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szar2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("So many stars. The unverse, so vast.");
            Console.WriteLine("We're s-so very small, in the end.");
            Console.ReadKey();*/


            Console.Write("Születési dátum(éééé-hh-nn)");

            string szuldat = "";
            int poz = 0;
            

            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);

                switch (poz)
                {
                    case 0:
                        if (cki.KeyChar == '1' || cki.KeyChar == '2')
                        {

                            Console.Write(cki.KeyChar);
                            szuldat += cki.KeyChar;
                            poz++;
                        }
                        break;

                    case 1:

                        if (poz == 1 && szuldat[0] == '1' && cki.KeyChar == '9')
                        {

                            Console.Write(cki.KeyChar);
                            szuldat += cki.KeyChar;
                            poz++;

                        }

                        else if(poz == 1 && szuldat[0] == '2' && cki.KeyChar == '0')
                            {

                            Console.Write(cki.KeyChar);
                            szuldat += cki.KeyChar;
                            poz++;

                        }

                        break;

                    case 2:

                        if (poz == 2 && szuldat[0] == '1')
                        {

                            Console.Write(cki.KeyChar);
                            szuldat += cki.KeyChar;
                            poz++;

                        }

                        else if (poz == 2 && szuldat[0] == '2' && Convert.ToInt32(cki.KeyChar) <= 2)
                        {

                            Console.Write(cki.KeyChar);
                            szuldat += cki.KeyChar;
                            poz++;

                        }

                        break;

                     /*case 3:

                        try
                        {
                            Convert.ToInt32(cki.KeyChar);
                        }
                        catch (Exception)
                        {

                            throw;
                        }*/
                }

                if (poz == 9)
                {
                    break;
                }

            }


            string ketto = "";
            ketto += szuldat[0];
            ketto += szuldat[1];
            int kettoInt = int.Parse(ketto);

            //Console.WriteLine();
            //Console.WriteLine(szuldat);
            //Console.ReadKey();
        }
    }
}


//A JVABAN egy console alkalmazásban tulajdoképpen egy publikus statikus osztály, aminek mindenképp kell legyen egy main nevű metódusa, ami String[args] paraméterezésű.
//Ugyanez a c#-ban a következőképpennéz ki: bla bla blab bla lsd. above. vegyük figyelembe a következő feltételeket: ezek között azt mondhatjuk hogy csak számjegy lehet. Tehát ilyemikre kell gondolnunk, annak érdekében hogy korrekt dátumok kerülhessenek csak beírásra.
//Hogy tuti biztos olyan legyen aminek segítségével csak valós dátumot kapunk eredményképpen. Am,it itt most bátorkodnék némiképp leegyszerűsíteni. A beírt karakterek 5. tétele, csak "-"
// lehet. Gonosz természetem következtében meghagynám ezt a programot otthonra befejezni.Persze lehetne "." és perjel is, lányeg a következetesség. Nyilván mikor idáig eljutottunk a leírásunk, menjünk úgy szünetre, hpgy egy-két kísérletet tetünk.
//A tiszta kód alapelvet például 