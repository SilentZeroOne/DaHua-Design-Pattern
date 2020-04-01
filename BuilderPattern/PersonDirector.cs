using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class PersonDirector
    {
        private PersonBulider pb;
        public PersonDirector(PersonBulider pb)
        {
            this.pb = pb;
        }

        public void BuildPerson()
        {
            pb.BuildHead();
            pb.BuildBody();
            pb.BuildArms();
            pb.BuildLegs();
        }
    }
}
