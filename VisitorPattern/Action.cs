using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    abstract class Action
    {
        public abstract void GetManConclusion(Man man);
        public abstract void GetWomanConclusion(Woman woman);
    }

    class Success : Action
    {
        public override void GetManConclusion(Man man)
        {
            Console.WriteLine("{0} {1}", man.GetType().Name,GetType().Name);
        }
        public override void GetWomanConclusion(Woman woman)
        {
            Console.WriteLine("{0} {1}", woman.GetType().Name, GetType().Name);
        }
    }
    class Failing : Action
    {
        public override void GetManConclusion(Man man)
        {
            throw new NotImplementedException();
        }

        public override void GetWomanConclusion(Woman woman)
        {
            throw new NotImplementedException();
        }
    }
}
