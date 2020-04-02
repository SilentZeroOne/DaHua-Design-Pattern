using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name) { }
        public override void Add(Company c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }

        public override void Remove(Company c)
        {
            throw new NotImplementedException();
        }
    }
}
