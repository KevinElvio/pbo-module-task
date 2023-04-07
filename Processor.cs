using PROCESSOR;
using System;
using System.Linq.Expressions;

namespace PROCESSOR
{
    class Processor
    {
        public string merk, tipe;
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }

    }
    class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Core I3";
        }
    }
    class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Core I5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Core I7";
        }
    }
    class Amd : Processor
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }
    class Ryzen : Amd
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }
    class Athalon : Amd
    {
        public Athalon()
        {
            base.tipe = "Athalon";
        }
    }
}

