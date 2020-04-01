using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }

    public class MorningState:State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
            {
                Console.WriteLine("当前时间： {0}点 上午工作，精神饱满",w.Hour);
            }
            else
            {
                w.SetState(new NoonState());w.WriteProgram();
            }
        }
    }
    public class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点 饿了，吃饭；困了，睡觉", w.Hour);
            }
            else
            {
                w.SetState(new AfternoonState());w.WriteProgram();
            }
        }
    }
    public class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", w.Hour);
            }
            else
            {
                w.SetState(new EveningState());w.WriteProgram();
            }
        }
    }
    public class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.WorkIsFinished)
            {
                w.SetState(new RestState());w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间：{0}点 加班好累哦", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());w.WriteProgram();
                }
            }
        }
    }
    public class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 困死了 睡了", w.Hour);
        }
    }
    public class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间：{0}点 下班咯", w.Hour);
        }
    }
}
