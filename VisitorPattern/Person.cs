using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    abstract class Person
    {
        public abstract void Accept(Action action);
    }

    class Man : Person
    {
        public override void Accept(Action action)
        {
            action.GetManConclusion(this);
        }
    }

    class Woman : Person
    {
        public override void Accept(Action action)
        {
            action.GetWomanConclusion(this);
        }
    }
}
