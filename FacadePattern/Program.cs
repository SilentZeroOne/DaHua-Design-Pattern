using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade f1 = new Facade();

            f1.BuyMethod();
            Console.WriteLine("");
            f1.SellMethod();

            Console.Read();
        }
    }
}
