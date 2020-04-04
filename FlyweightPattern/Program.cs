using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WebsiteFactory f = new WebsiteFactory();

            Website fx = f.GetWebsiteCategory("产品展示");
            fx.Use(new User("娇娇"));

            Website fy = f.GetWebsiteCategory("产品展示");
            fy.Use(new User("小菜"));

            Website fz = f.GetWebsiteCategory("博客");
            fz.Use(new User("大鸟"));

            Website fl = f.GetWebsiteCategory("博客");
            fl.Use(new User("老头"));

            Console.WriteLine("总网站数：" + f.GetCount());

            Console.ReadLine();
        }
    }
}
