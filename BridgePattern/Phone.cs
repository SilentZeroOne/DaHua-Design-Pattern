using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class Phone
    {
        protected Software soft;
        public void SetSoftware(Software s)
        {
            soft = s;
        }
        public abstract void Run();
    }

    class PhoneA : Phone
    {
        public override void Run()
        {
            soft.Run();
        }
    }
    class PhoneB : Phone
    {
        public override void Run()
        {
            soft.Run();
        }
    }
}
