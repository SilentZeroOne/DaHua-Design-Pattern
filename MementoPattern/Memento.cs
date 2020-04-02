using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Memento
    {
        private int vit;
        private int atk;
        private int def;
        public Memento(int vit,int atk,int def)
        {
            this.vit = vit;
            this.atk = atk;
            this.def = def;
        }
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
    }
}
