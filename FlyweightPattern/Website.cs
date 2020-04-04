using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    abstract class Website
    {
        public abstract void Use(User user);
    }
    class ConcreteWebSite : Website
    {
        private string name="";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }
        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + " 用户：" + user.Name);
        }
    }
}
