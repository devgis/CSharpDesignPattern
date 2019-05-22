using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return (new Memento(State));
        }

        public void SetMemento(Memento memento)
        {
            State = memento.GetState();
        }
    }
}
