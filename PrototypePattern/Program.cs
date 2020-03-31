using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume r1 = new Resume("大鸟");
            r1.SetWorkExperience("2008-2010", "上海");
            r1.SetPersonalInfo("男", "29");
            r1.Display();
            Resume r2 = (Resume)r1.Clone();
            r2.SetWorkExperience("2011-2015", "北京");
            r2.Display();
            
            Console.ReadKey();
        }
    }
}
