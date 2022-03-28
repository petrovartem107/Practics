using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    abstract class AbTovar
    {
        public abstract int Price { get; set; }
        public abstract string Name { get; set; }
        public abstract double Count { get; set; }

        public AbTovar (int x, string y)
        {
            Count = x;
            Name = y;
        }
        public abstract void Print();

    }
}
