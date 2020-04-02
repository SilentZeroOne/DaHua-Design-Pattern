using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class Company
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Company(string name)
        {
            Name = name;
        }
        public abstract void Add(Company c);
        public abstract void Remove(Company c);
        public abstract void Display(int depth);
        public abstract void LineOfDuty();
    }
}
