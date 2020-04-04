using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    abstract  class Country
    {
        protected UnitedNations mediator;
        public Country(UnitedNations mediator)
        {
            this.mediator = mediator;
        }
    }
    class USA : Country
    {
        public USA(UnitedNations mediator) : base(mediator) { }
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }
        public void GetMessage(string message)
        {
            Console.WriteLine("美国获得对方信息：" + message);
        }
    }
    class Iraq : Country
    {
        public Iraq(UnitedNations mediator) : base(mediator) { }
        public void Declare(string message)
        {
            mediator.Declare(message, this);
        }
        public void GetMessage(string message)
        {
            Console.WriteLine("伊拉克获得对方信息：" + message);
        }
    }
}
