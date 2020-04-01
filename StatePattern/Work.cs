using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Work
    {
        private State curent;
        public Work()
        {
            curent = new MorningState();
        }

        private double hour;
        public double Hour
        {
            get
            {
                return hour; 
            }
            set
            {
                hour = value;
            }
        }
        private bool workIsFinished = false;
        public bool WorkIsFinished
        {
            get
            {
                return workIsFinished;
            }
            set
            {
                workIsFinished = value;
            }
        }
        public void WriteProgram()
        {
            curent.WriteProgram(this);
        }
        public void SetState(State s)
        {
            curent = s;
        }
    }
}
