using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Finery:Person
    {
        protected Person component;
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }

    class Tshirts : Finery
    {
        public override void Show()
        {
            Console.Write("T恤衫 ");
            base.Show();
        }
    }
    class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("大跨裤 ");
            base.Show();
        }
    }
    class Panties : Finery
    {
        public override void Show()
        {
            Console.Write("内裤 ");
            base.Show();
        }
    }
    class Shoes : Finery
    {
        public override void Show()
        {
            Console.Write("鞋子 ");
            base.Show();
        }
    }
}
