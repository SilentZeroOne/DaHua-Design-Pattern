using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone A = new PhoneA();
            A.SetSoftware(new Game());
            A.Run();
            A.SetSoftware(new AddressList());
            A.Run();

            Phone B = new PhoneB();
            B.SetSoftware(new Game());
            B.Run();
            B.SetSoftware(new AddressList());
            B.Run();

            Console.Read();
        }
    }
}
