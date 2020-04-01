using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Department
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private int _name;
        public int Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
   

    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }

    class SqlSeverDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL SEVER中根据ID获得Department表中一个记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在SQL SEVER中给Department表插入一条记录");
        }
    }

    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根据ID获得Department表中一个记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给Department表插入一条记录");
        }
    }
}
