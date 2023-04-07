using VGA;
using System;
using System.Linq.Expressions;

namespace VGA
{
    class Vga
    {
        public string merk;
    }
    class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    class AMD : Vga
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
}