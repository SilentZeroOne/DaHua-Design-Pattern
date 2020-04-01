using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class User
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

    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }

    class SqlSeverUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在SQL SEVER中根据ID获得User表中一个记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在SQL SEVER中给User表插入一条记录");
        }
    }

    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID获得User表中一个记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表插入一条记录");
        }
    }
}
