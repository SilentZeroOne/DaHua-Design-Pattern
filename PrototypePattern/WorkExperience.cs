using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class WorkExperience:ICloneable
    {
        private string workDate;
        private string workPlace;

        public string WorkDate { get; set; }
        public string WorkPlace { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
