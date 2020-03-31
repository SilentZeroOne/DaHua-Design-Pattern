using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class Person
    {
        private string name;
        public Person() { }
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("打扮好的{0}", name);
        }
    }
}
