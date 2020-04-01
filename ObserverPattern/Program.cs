using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();
            Secretary xiaomi = new Secretary();

            StockObserver tongshi1 = new StockObserver("必胜客", huhansan);
            NbaObserver tongshi2 = new NbaObserver("臭弟弟", xiaomi);

            huhansan.Update += new EventHandler(tongshi1.CloseStock);
            xiaomi.Update += new EventHandler(tongshi2.CloseNba);

            huhansan.SubjectState = "我胡汉三有回来了！";
            xiaomi.SubjectState = "老板回来了！";


            huhansan.Notify();
            xiaomi.Notify();

            Console.Read();
        }
    }
}
