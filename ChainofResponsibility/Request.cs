using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainofResponsibility
{
    class Request
    {
        private string requestType;
        private string requestContent;
        private int number;
        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }
        public string RequestContent
        {
            get { return requestContent; }
            set { requestContent = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
