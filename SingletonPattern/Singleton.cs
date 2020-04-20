using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance;
        private Singleton() { }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    class Singleton2//禁止多线程访问，加入锁,双层锁定需要在锁外层在加一个if(instance==null)
    {
        private static Singleton2 instance;
        private static readonly object syncRoot = new object();
        private Singleton2() { }
        public static Singleton2 GetSingleton()
        {
            lock (syncRoot)
            {
                if (instance == null)
                {
                    instance = new Singleton2();
                }
            }
            return instance;
        }
    }

    class Singleton3
    {
        private Singleton3(){}
        private static  Singleton3 instance = new Singleton3();
        public static Singleton3 Instance
        {
            get { return instance; }
        }
    }

    class Singleton4//按需创建实例
    {
        Singleton4() {}
        public static Singleton4 Instance
        {
            get { return Nested.instance; }
        }


        class Nested
        {
            static Nested() { }

            internal static readonly Singleton4 instance = new Singleton4();
        }
    }
}
