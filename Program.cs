using LAPTOP;
using PROCESSOR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VGA;

namespace Tugas_Praktikum_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();
            Console.WriteLine(laptop1);
            Console.WriteLine(laptop1.vga);
            Console.WriteLine(laptop1.processor+"\n\r");
   
 

            Laptop laptop2 = new Ideapad();
            laptop2.vga = new AMD();
            laptop2.processor = new Ryzen();
            Console.WriteLine(laptop2);
            Console.WriteLine(laptop2.vga);
            Console.WriteLine(laptop2.processor);
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("\n\r");

            Predator predator1 = new Predator();
            predator1.vga = new AMD();
            predator1.processor = new Corei7();
            Console.WriteLine(predator1);
            Console.WriteLine(predator1.vga);
            Console.WriteLine(predator1.processor);
            predator1.BermainGame();

            ACER acer = new Predator();
 
            


        }
    }
}
