using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    internal class Product
    {
        #region OldArtem
        //public int tovar1 = 55;
        //public int tovar2 = 23;
        //public int Tovar1
        //{
        //    get
        //    {
        //        return tovar1;
        //    }
        //    set
        //    {
        //        tovar1 = value;
        //    }
        //}
        //public int Tovar2
        //{
        //    get
        //    {
        //        return tovar2;
        //    }
        //    set
        //    {
        //        tovar2 = value;
        //    }
        //}
        //public void Print()
        //{
        //    int doroze = tovar1 - tovar2;
        //    Console.WriteLine($"Товар дороже на:{doroze}");
        //} 
        #endregion
        public int Price { get; set; }
        public string Name { get; set; }
        public Product(int x, string name)
        {
            Price = x;
            Name = name;
        }


        public static void Sravnenie(Product product1, Product product2)
        {
            if (product1.Price > product2.Price)
            {
                int raznica = product1.Price - product2.Price;
                Console.WriteLine($"{product2.Name} дешевле REDBOOL на: {raznica} рублей");
            }
            else
            {
                int raznica2 = product2.Price - product1.Price;
                Console.WriteLine($"{product2.Name} Дороже Торнадо на: {raznica2} рублей");
            }
        }
    }
}
