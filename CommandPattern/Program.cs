using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer barbecuer = new Barbecuer();
            Command bakeMutton = new BakeMuttonCommand(barbecuer);
            Command bakeWings = new BakeWingsCommand(barbecuer);
            Waiter waiter = new Waiter();
            waiter.SetOrder(bakeMutton);
            waiter.SetOrder(bakeWings);
            waiter.SetOrder(bakeMutton);

            waiter.Notify();

            Console.Read();
        }
    }
}
