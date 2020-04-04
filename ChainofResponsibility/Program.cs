using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new CommonManager("经理");
            Manager manager1 = new Majordomo("总监");
            Manager manager2 = new GeneralManager("总经理");

            manager.SetSuperior(manager1);
            manager1.SetSuperior(manager2);

            Request request = new Request();
            request.RequestType = "请假";
            request.RequestContent = "小菜请假";
            request.Number = 5;

            manager.RequestApplications(request);

            Request request1 = new Request();
            request1.RequestType = "加薪";
            request1.RequestContent = "小菜加薪";
            request1.Number = 1000;

            manager.RequestApplications(request1);

            Request request2 = new Request();
            request2.RequestType = "加薪";
            request2.RequestContent = "小菜加薪";
            request2.Number = 500;

            manager.RequestApplications(request2);

            Console.Read();
        }
    }
}
