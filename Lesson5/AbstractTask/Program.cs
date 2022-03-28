using System;

namespace AbstractTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vesovoy_Tovar vesovoy_ = new Vesovoy_Tovar(33, "Яйца");
            vesovoy_.Print();
            Console.WriteLine("---------------------------------------------");
            Tsufrovoi_Tovar tsufrovoi = new Tsufrovoi_Tovar(1, "Подписка на кинопоиск");
            tsufrovoi.Print();
            Console.WriteLine("---------------------------------------------");
            Fizicheskiy_Tovar fizicheskiy = new Fizicheskiy_Tovar(4, "Рюмки");
            fizicheskiy.Print();

        }
    }
}
