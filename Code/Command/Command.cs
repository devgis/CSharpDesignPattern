using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    abstract class Command
    {
        // Fields 
        protected Receiver receiver;

        // Constructors 
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        // Methods 
        abstract public void Execute();
    } 
}
