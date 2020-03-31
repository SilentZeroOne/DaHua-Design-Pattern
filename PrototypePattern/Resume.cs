using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    class Resume:ICloneable
    {
        private string name;
        private string age;
        private string sex;
        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }
        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }
        public void SetWorkExperience(string workDate,string workPlace)
        {
            work.WorkDate = workDate;
            work.WorkPlace = workPlace;
        }
        public void Display()
        {
            Console.WriteLine("{0} 性别:{1} 年龄:{2}", name, sex, age);
            Console.WriteLine("工作时间: " + work.WorkDate + " 工作地点: " + work.WorkPlace);
        }
        public object Clone()
        {
            Resume obj = new Resume(work);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;

        }
    }
}
