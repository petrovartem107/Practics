using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_delegate
{
    delegate void ArtemDelegate();
    delegate void ArtemDelegateOne(string x);
    delegate void ArtemPlus(int aa, int bb);
    delegate void ArtemMinus(int cc, int dd);
    delegate int TovarPrice(int q, int w);
    

    public class Arbaiten
    {
        public static void Hi()
        {
            Console.WriteLine("Hi world !");
        }
        public static void Hello()
        {
            Console.WriteLine("Hello world !!");
        }
        public static void Hey()
        {
            Console.WriteLine("Hey world !!!");
        }

        public static void HiName(string name)
        {
            Console.WriteLine($"Hey {name}!!!");
        }

        public static void Plus (int a, int b)
        {
            Console.WriteLine($"Сумма чисел: {a+b}");
        }

        public static void Minus (int c, int d)
        {
            Console.WriteLine($"Разница чисел: {c - d}");
        }

        public static int Price(int ves, int cze)
        {
            int result = 0;
            result = ves * cze;
            return result;
        }
    }
}
