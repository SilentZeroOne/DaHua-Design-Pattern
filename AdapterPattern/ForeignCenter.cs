using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class ForeignCenter
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void JingGong()
        {
            Console.WriteLine("外籍中锋{0} 进攻！", name);
        }
        public void FangShou()
        {
            Console.WriteLine("外籍中锋{0} 防守！", name);
        }
    }
}
