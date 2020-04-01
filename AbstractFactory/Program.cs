using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AbstractFactory
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user = new User();
            Department department = new Department();

            IUser result = Database.CreateUser();

            IDepartment result2 = Database.CreateDepartment();

            result.Insert(user);
            result.GetUser(1);

            result2.Insert(department);
            result2.GetDepartment(1);

            Console.Read();
        }
    }
}
