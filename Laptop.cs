using LAPTOP;
using VGA;
using PROCESSOR;
using System.Linq.Expressions;
using System;

namespace LAPTOP
{
    class Laptop
    {
        public string merk, tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + merk + tipe + " Menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + merk + tipe + " Mati");
        }
    }
    class Asus : Laptop
    {
        public Asus()
        {
            base.merk = "ASUS";
        }
    }
    class ROG : Asus
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }
    class Vivobook : Asus
    {
        public Vivobook()
        {
            base.tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.merk = "ACER";
        }
    }
    class Swift : ACER
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }
    class Predator : ACER
    {
        public Predator()
        {
            base.tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop " + merk + tipe + " sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }
    class Ideapad : Lenovo
    {
        public Ideapad()
        {
            base.tipe = "Ideapad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

}
