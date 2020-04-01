using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 8;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();

            work.Hour = 14;
            work.WriteProgram();

            //work.WorkIsFinished =true;

            work.Hour = 18;
            work.WriteProgram();

            work.Hour = 22;
            work.WriteProgram();

            Console.Read();
        }
    }
}
