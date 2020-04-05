using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class ObjectStruct
    {
        private IList<Person> people = new List<Person>();

        public void Attach(Person person)
        {
            people.Add(person);
        }

        public void Detach(Person person)
        {
            people.Remove(person);
        }

        public void Display(Action action)
        {
            foreach(var person in people)
            {
                person.Accept(action);
            }
        }
    }
}
