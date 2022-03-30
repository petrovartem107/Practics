using System;

namespace study_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Arbaiten.Hello();
            //Arbaiten.Hi();
            //Arbaiten.Hey();
            ArtemDelegate artem;
            ArtemDelegateOne artemOne;
            ArtemPlus plus;
            ArtemMinus minus;
            TovarPrice price;

            artem = Arbaiten.Hello;
            artem += Arbaiten.Hi;
            artem += Arbaiten.Hello;
            artem += Arbaiten.Hi;

            artemOne = Arbaiten.HiName;

            artem();
            Console.WriteLine("/////////////////");
            artemOne("Artem");
            Console.WriteLine("+++++++++++++++++++++++++++++++");

            plus = Arbaiten.Plus;
            plus(2, 2);
            Console.WriteLine("------------------------------");

            minus = Arbaiten.Minus;
            minus(5, 3);
            Console.WriteLine("******************");

            int asd = Arbaiten.Price(3,72);
            price = Arbaiten.Price;
            int result = price(13,72);
            Console.WriteLine($"Ваша цена:{result}");
            
           
            
        }
    }
}
