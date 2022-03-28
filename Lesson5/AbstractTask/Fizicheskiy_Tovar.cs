using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTask
{
    internal class Fizicheskiy_Tovar : AbTovar
    {
        public Fizicheskiy_Tovar(int x, string y) : base(x, y)
        {

        }

        public override int Price { get; set; } = 30;
        public override string Name { get; set; }
        public override double Count { get; set; }

        public override void Print()
        {
            Console.WriteLine($"{Count}{Name} цена={Price*Count}");
        }
    }
}
