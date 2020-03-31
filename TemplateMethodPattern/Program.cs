using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaper s1 = new TestPaperA();
            TestPaper s2 = new TestPaperB();

            s1.TestQuestion1();
            s1.TestQuestion2();
            s1.TestQuestion3();

            s2.TestQuestion1();
            s2.TestQuestion2();
            s2.TestQuestion3();

            Console.ReadKey();
        }
    }
}
