﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("啊啊啊啊啊啊啊额");
            Console.WriteLine("A.1 B.2 C.3 D.4");
            Console.WriteLine("答案：" +Answer1());
        }
        protected virtual string Answer1()
        {
            return "";
        }
        public  void TestQuestion2()
        {
            Console.WriteLine("啊eeeee");
            Console.WriteLine("A.1 B.2 C.3 D.4");
            Console.WriteLine("答案：" + Answer2());
        }
        protected virtual string Answer2()
        {
            return "";
        }
        public void TestQuestion3()
        {
            Console.WriteLine("啊啊啊bbbbb额");
            Console.WriteLine("A.1 B.2 C.3 D.4");
            Console.WriteLine("答案：" + Answer3());
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }
}
