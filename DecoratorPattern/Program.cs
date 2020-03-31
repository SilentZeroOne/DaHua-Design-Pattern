using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");
            Finery tShirt = new Tshirts();
            Finery bigT = new BigTrouser();
            Finery shoe = new Shoes();
            Finery panties = new Panties();

            tShirt.Decorate(xc);
            bigT.Decorate(tShirt);
            shoe.Decorate(bigT);
            panties.Decorate(shoe);

            panties.Show();

            Console.ReadKey();
        }
    }
}
