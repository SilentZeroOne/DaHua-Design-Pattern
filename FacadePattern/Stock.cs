using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Stock
    {
        public  void Buy()
        {
            Console.WriteLine("买入股票："+Number());
        }
        public  void Sell()
        {
            Console.WriteLine("卖出股票：" + Number());
        }
        public virtual string Number()
        {
            return "";
        }
    }
    class Stock1 : Stock
    {
        public override string Number()
        {
            return "一号股";
        }
    }
    class Stock2 : Stock
    {
        public override string Number()
        {
            return "二号股";
        }
    }
    class Stock3 : Stock
    {
        public override string Number()
        {
            return "三号股";
        }
    }
}
