using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng leiFeng = factory.CreateLeiFeng();

            leiFeng.SaoDi();
            leiFeng.ShaoShui();
            leiFeng.XiYi();
            leiFeng.ZuoFan();

            Console.ReadKey();
        }
    }
}
