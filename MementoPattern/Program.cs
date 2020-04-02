using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Role xiaocai = new Role();
            xiaocai.StateInit();
            xiaocai.StateDisplay();

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = xiaocai.Save();

            xiaocai.Fight();
            xiaocai.StateDisplay();

            xiaocai.Recovery(caretaker.Memento);
            xiaocai.StateDisplay();

            Console.Read();
        }
    }
}
