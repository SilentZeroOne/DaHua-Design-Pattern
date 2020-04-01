using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class PersonBulider
    {
        protected Graphics g;
        protected Pen p;
        public PersonBulider(Graphics g, Pen p)
        {
            this.g = g;
            this.p = p;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArms();
        public abstract void BuildLegs();

    }

    class PersonThinBuilder : PersonBulider
    {
        public PersonThinBuilder(Graphics g,Pen p) : base(g,p) { }

        public override void BuildArms()
        {
            g.DrawLine(p, 60, 50, 40, 100);
            g.DrawLine(p, 70, 50, 90, 100);
        }

        public override void BuildBody()
        {
            g.DrawRectangle(p, 60, 50, 10, 50);
        }

        public override void BuildHead()
        {
            g.DrawEllipse(p, 50, 20, 30, 30);
        }

        public override void BuildLegs()
        {
            g.DrawLine(p, 60, 100, 45, 150);
            g.DrawLine(p, 70, 100, 85, 150);
        }
    }
}
