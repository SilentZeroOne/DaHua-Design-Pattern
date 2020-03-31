using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Pursuit: IGiveGift
    {
        SchoolGril mm;
        public Pursuit(SchoolGril mm)
        {
            this.mm = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + " 送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + " 送你玩偶");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + " 送你鲜花");
        }
    }
}
