using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product tovar = new Product();
            //tovar.Print();
            Product A = new Product(55, "Энергетик Торнадо");

            Product B = new Product(190, "Энергетик REDBOOL");

            //int result = A.Price - B.Price;
            //Console.WriteLine($"Разница {result}");
            //Console.WriteLine("------------------------------------");
            Product.Sravnenie(B, A);

            Console.ReadKey();
        }
    }
}
