using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    abstract class Manager
    {
        protected string name;
        protected Manager superior;
        public Manager(string name)
        {
            this.name = name;
        }

        public void SetSuperior(Manager superior)
        {
            this.superior = superior;
        }
        abstract public void RequestApplications(Request request);

        protected void Admit(Request request)
        {
            Console.WriteLine("{0}：{1} 数量{2} 被批准。", name, request.RequestContent, request.Number);
        }
    }
    class CommonManager : Manager
    {
        public CommonManager(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 2)
            {
                Admit(request);
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
        }
    }
    class Majordomo : Manager
    {
        public Majordomo(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假" && request.Number <= 5)
            {
                Admit(request);
            }
            else
            {
                if (superior != null)
                {
                    superior.RequestApplications(request);
                }
            }
            
        }
    }
    class GeneralManager : Manager
    {
        public GeneralManager(string name) : base(name) { }
        public override void RequestApplications(Request request)
        {
            if (request.RequestType == "请假")
            {
                Admit(request);
            }
            else if (request.RequestType == "加薪" && request.Number <= 500)
            {
                Admit(request);
            }
            else if (request.RequestType == "加薪" && request.Number > 500)
            {
                Console.WriteLine("{0}：{1} 数量{2} 再说吧。", name, request.RequestContent, request.Number);
            }
        }
    }
}
