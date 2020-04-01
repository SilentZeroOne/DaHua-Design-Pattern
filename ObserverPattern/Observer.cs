using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    

    class StockObserver 
    {

        private string name;
        private Subject sub;
        public StockObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStock()
        {
            Console.WriteLine("{0} {1} 关闭股票市场，继续工作！", sub.SubjectState,name);
        }

    }
    class NbaObserver
    {

        private string name;
        private Subject sub;
        public NbaObserver(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNba()
        {
            Console.WriteLine("{0} {1} 关闭NBA，继续工作！",sub.SubjectState,name);
        }

    }
}
