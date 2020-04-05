using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
   abstract class Expression
    {
        public void Interpret(PlayContext context)
        {
            if (context.Text.Length == 0)
                return;
            else
            {
                string playKey = context.Text.Substring(0, 1);
                context.Text = context.Text.Substring(2);
                double playValue = Convert.ToDouble(context.Text.Substring(0, context.Text.IndexOf(" ")));
                context.Text = context.Text.Substring(context.Text.IndexOf(" ") + 1);

                Excute(playKey, playValue);
            }
        }
        public abstract void Excute(string key, double value);
    }

    class Note : Expression
    {
        public override void Excute(string key, double value)
        {
            string note = "";
            switch (key)
            {
                case "C":
                    note ="1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }
            Console.Write("{0} ", note);
        }
    }

    class Scale : Expression
    {
        public override void Excute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write("{0} ", scale);
        }
    }

    class Speed : Expression
    {
        public override void Excute(string key, double value)
        {
            string speed;
            if (value < 500)
                speed = "快速";
            else if (value >= 1000)
                speed = "慢速";
            else
                speed = "中速";

            Console.WriteLine("{0} ", speed);
        }
    }
}
