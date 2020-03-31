using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class SchoolGril
    {
        private string name;

        public SchoolGril(string name)
        {
            Name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
