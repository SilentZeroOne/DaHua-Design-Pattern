using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy:IGiveGift
    {
        Pursuit gg;
        public Proxy(SchoolGril mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            ((IGiveGift)gg).GiveChocolate();
        }

        public void GiveDolls()
        {
            ((IGiveGift)gg).GiveDolls();
        }

        public void GiveFlowers()
        {
            ((IGiveGift)gg).GiveFlowers();
        }
    }
}
