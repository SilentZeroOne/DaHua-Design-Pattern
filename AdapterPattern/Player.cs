using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }

    class Forwards : Player
    {
        public Forwards(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("前锋{0} 进攻！", name);
        }
        public override void Defense()
        {
            Console.WriteLine("前锋{0} 回防！", name);
        }
    }
    class Center : Player
    {
        public Center(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("中锋{0} 进攻！", name);
        }
        public override void Defense()
        {
            Console.WriteLine("中锋{0} 回防！", name);
        }
    }
    class Translator : Player
    {
        ForeignCenter wjzf = new ForeignCenter();
        public Translator(string name):base(name)
        {
            wjzf.Name = name;
        }
        public override void Attack()
        {
            wjzf.JingGong();
        }
        public override void Defense()
        {
            wjzf.FangShou();
        }
    }
}
