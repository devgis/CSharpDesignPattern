using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class ConcreteCommand : Command
    {
        // Constructors 
        public ConcreteCommand(Receiver receiver) :
            base(receiver) { }

        // Methods 
        public override void Execute()
        {
            receiver.Action();
        }
    } 
}
