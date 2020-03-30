using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPattern
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    /// <summary>
    /// 通过使用简单工厂和策略模式实现超市收款打折等情况
    /// </summary>
    abstract class CashSuper//现金收取超类的抽象方法
    {
        public abstract double acceptCash(double money);
    }

    class CashNormal:CashSuper//正常收款
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
    class CashRebate : CashSuper//打折收款
    {
        private double moneyRebate = 1d;
        public CashRebate(string rebate)
        {
            moneyRebate = double.Parse(rebate);
        }
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
    class CashReturn : CashSuper//返现收款
    {
        private double moneyCondition = 0.0d;
        private double moneyReturn = 0.0d;
        public CashReturn(string moneyCondition,string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyCondition);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
    class CashContext//维护对CashSuper的引用
    {
        CashSuper cs=null;
        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300减100":
                    cs = new CashReturn("300", "100");
                    break;
                case "8折":
                    cs = new CashRebate("0.8");
                    break;
            }
        }
        public double GetResult(double money)//根据具体的策略对象，调用其算法
        {
            return cs.acceptCash(money);
        }
    }
}
