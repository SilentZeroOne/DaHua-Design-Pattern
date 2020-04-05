using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStruct obj = new ObjectStruct();
            obj.Attach(new Man());
            obj.Attach(new Woman());

            Success success = new Success();

            obj.Display(success);

            Console.Read();
        }
    }
}
