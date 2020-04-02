using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player a = new Forwards("巴蒂尔");
            a.Attack();
            Player b = new Center("麦克雷");
            b.Defense();
            Player ym = new Translator("姚明");
            ym.Attack();

            Console.Read();
        }
    }
}
