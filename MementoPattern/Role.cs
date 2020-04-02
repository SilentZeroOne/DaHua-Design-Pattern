using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Role
    {
        private int vit;
        private int atk;
        private int def;
        public int Vit
        {
            get { return vit; }
            set { vit = value; }
        }
        public int Atk
        {
            get { return atk; }
            set { atk = value; }
        }
        public int Def
        {
            get { return def; }
            set { def = value; }
        }

        public void StateDisplay()
        {
            Console.WriteLine("当前角色状态：");
            Console.WriteLine("生命值：" + vit);
            Console.WriteLine("攻击力：" + atk);
            Console.WriteLine("防御力：" + def);
            Console.WriteLine("");
        }
        public void StateInit()
        {
            vit = 100;
            atk = 100;
            def = 100;
        }
        public void Fight()
        {
            vit = 0;
            atk = 100;
            def = 80;
        }
        public Memento Save()
        {
            return new Memento(vit, atk, def);
        }
        public void Recovery(Memento memento)
        {
            vit = memento.Vit;
            atk = memento.Atk;
            def = memento.Def;
        }
    }
}
