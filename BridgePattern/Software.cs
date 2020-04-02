using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class Software
    {
        public abstract void Run();
    }
    class Game : Software
    {
        public override void Run()
        {
            Console.WriteLine("运行游戏");
        }
    }
    class AddressList : Software
    {
        public override void Run()
        {
            Console.WriteLine("运行通讯录");
        }
    }
}
