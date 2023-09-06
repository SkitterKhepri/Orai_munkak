using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace autok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"({Console.BufferWidth}x{Console.BufferHeight})");

            
            //Console.SetWindowSize(70, 40);
            //Console.BufferWidth = 70;
            //Console.BufferHeight = 40;

            //for (int i = 1; i < 40; i++)
            //{
            //    for (int j = 1; j < 70; j++)
            //    {
            //        Console.Write(".");
                    
            //    }
            //    //Console.WriteLine();
            //}

            //Console.WriteLine("Bercsek András, ma");
            //Console.Write("Nyomj egy billentyüt a töléshez...");
            //Console.ReadKey(true);
            //Console.Clear();

            
            //Thread.Sleep(3000);
            string auto1 = "A-1";


            //Console.SetCursorPosition(Console.WindowWidth - 3, 15);
            //Console.Write(auto1);

            //Thread.Sleep(3000);

            int poz = Console.WindowWidth - 3;

            while (true)
            {

                Console.Clear();

                /*try
                {
                    Console.SetCursorPosition(poz, 10);
                }
                catch (Exception)
                {
                    break;
                }
                */

                Console.SetCursorPosition(poz, 10);
                Console.Write(auto1);


                if (poz > 3)
                {
                    poz -= 3;
                }
                else
                {
                    break;
                }

                
                

                Thread.Sleep(1000/16);

            }

        }
    }
}
