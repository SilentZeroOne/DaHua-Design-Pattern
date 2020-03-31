using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TestPaperA:TestPaper
    {
        protected override string Answer1()
        {
            return "C";
        }
        protected override string Answer2()
        {
            return "B";
        }
        protected override string Answer3()
        {
            return "A";
        }
    }
    class TestPaperB : TestPaper
    {
        protected override string Answer1()
        {
            return "A";
        }
        protected override string Answer2()
        {
            return "B";
        }
        protected override string Answer3()
        {
            return "C";
        }
    }
}
