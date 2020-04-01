using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Facade
    {
        Stock s1;
        Stock s2;
        Stock s3;

        public Facade()
        {
            s1 = new Stock1();
            s2 = new Stock2();
            s3 = new Stock3();
        }

        public void BuyMethod()
        {
            s1.Buy();
            s2.Buy();
            s3.Buy();
        }
        public void SellMethod()
        {
            s1.Sell();
            s2.Sell();
            s3.Sell();
        }
    }
}
