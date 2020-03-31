using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    class LeiFeng
    {
        public void SaoDi()
        {
            Console.WriteLine("扫地");
        }
        public void ZuoFan()
        {
            Console.WriteLine("做饭");
        }
        public void ShaoShui()
        {
            Console.WriteLine("烧水");
        }
        public void XiYi()
        {
            Console.WriteLine("洗衣");
        }
    }
    class Undergraduate : LeiFeng { }
    class Volunteer : LeiFeng { }
}
