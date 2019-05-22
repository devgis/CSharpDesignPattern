using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator { State = "State A" };
            Console.WriteLine(originator.State);

            var memento = originator.CreateMemento();
            var caretaker = new Caretaker { Memento = memento };

            originator.State = "State B";
            Console.WriteLine(originator.State);

            originator.SetMemento(caretaker.Memento);
            Console.WriteLine(originator.State);
            Console.Read();
        }
    }
}
