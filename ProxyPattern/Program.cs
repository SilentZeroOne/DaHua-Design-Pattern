using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGril mm = new SchoolGril("李娇");
            Proxy daili = new Proxy(mm);

            daili.GiveChocolate();
            daili.GiveDolls();
            daili.GiveFlowers();

            Console.ReadKey();
        }
    }
}
