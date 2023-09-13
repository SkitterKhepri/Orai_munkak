using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMozgatasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"({Console.BufferWidth}X{Console.BufferHeight})");
            /*Console.WindowLeft = 50;
            Console.WindowTop = 20;
            Console.SetWindowSize(70,40);
            Console.BufferWidth = 70;
            Console.BufferHeight = 40;
            //for (int sor = 1; sor <= 40; sor++)    
            {
                for (int oszlop = 1; oszlop <= 70; oszlop++)
                {
                    Console.Write("+");
                }
            }
            Console.WriteLine("Bálint Dezső (c) 2023");
            Console.Write("Nyomj egy billentyűt a törléshez...");
            Console.ReadKey(true);
            Console.Clear();
            //Console.ReadKey();
            System.Threading.Thread.Sleep(3000);*/
            String auto = "A-1";
            /*Console.SetCursorPosition(Console.WindowWidth - 3, 31);
            Console.Write(auto);
            System.Threading.Thread.Sleep(10000);*/
            int poz = Console.WindowWidth - 3;
            while (true)
            {
                Console.Clear();
                /*try
                {
                    Console.SetCursorPosition(poz, 10);
                }catch(Exception e)
                {
                    break;
                }*/
                Console.SetCursorPosition(poz, 10);
                Console.Write(auto);
                if (poz > 3)
                {
                    poz -= 3;
                }
                else
                {
                    break;
                }
                System.Threading.Thread.Sleep(1000/16);
            }
            System.Threading.Thread.Sleep(3000);
        }
    }
}
