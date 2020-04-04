using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Council united = new Council();
            USA usa = new USA(united);
            Iraq iraq = new Iraq(united);

            united.Country1 = usa;
            united.Country2 = iraq;

            usa.Declare("不准研制核武器！");
            iraq.Declare("你打我呀！");

            Console.Read();
        }
    }
}
