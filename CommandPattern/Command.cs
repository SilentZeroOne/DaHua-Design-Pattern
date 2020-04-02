using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    abstract class Command
    {
        protected Barbecuer barbecuer;
        public Command(Barbecuer barbecuer)
        {
            this.barbecuer = barbecuer;
        }

        abstract public void ExcuteCommand();
    }

    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer barbecuer) : base(barbecuer) { }
        public override void ExcuteCommand()
        {
            barbecuer.BakeMutton();
        }
    }

    class BakeWingsCommand : Command
    {
        public BakeWingsCommand(Barbecuer barbecuer) : base(barbecuer) { }
        public override void ExcuteCommand()
        {
            barbecuer.BakeWings();
        }
    }
}
