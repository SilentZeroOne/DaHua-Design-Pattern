using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Waiter
    {
        private IList<Command> commands = new List<Command>();
        public void SetOrder(Command command)
        {
            if (command.ToString() == "CommandPattern.BakeWingsCommand")
            {
                Console.WriteLine("鸡翅没有了，请点别的");
            }
            else
            {
                commands.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + " 时间：" + DateTime.Now.ToString());
            }
        }
        public void Notify()
        {
            foreach(var item in commands)
            {
                item.ExcuteCommand();
            }
        }
    }
}
