using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        /// <summary>
        /// 简单工厂模式实现计算机运算
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Operation oper ;
                    Console.WriteLine("请输入运算符:");
                    oper = OperationFactory.createOperate(Console.ReadLine());
                    Console.WriteLine("请输入第一个数字:");
                    oper.NumA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("请输入第二个数字:");
                    oper.NumB = Convert.ToDouble(Console.ReadLine());
                    double result = oper.GetResult();
                    Console.WriteLine("结果为:" + result);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("您输入有误！请重新输入！" + ex.Message);
                }
            }
        }
       
    }
    public class Operation
    {
        private double numA = 0;
        private double numB = 0;
        public double NumA
        {
            get { return numA; }
            set { numA = value; }
        }
        public double NumB
        {
            get { return numB; }
            set { numB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }
    public class OperateAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA + NumB;
            return result;
        }
    }
    public class OperateSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA - NumB;
            return result;
        }
    }
    public class OperateMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumA * NumB;
            return result;
        }
    }
    public class OperateDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumB == 0) throw new Exception("除数不能为0");
            else result = NumA / NumB;
            return result;
        }
    }
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperateAdd();
                    break;
                case "-":
                    oper = new OperateSub();
                    break;
                case "*":
                    oper = new OperateMul();
                    break;
                case "/":
                    oper = new OperateDiv();
                    break;
            }
            return oper;
        }
    }
}
