using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Invoker
    {
        // Fields 
        private Command command;

        // Methods 
        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExecuteCommand()
        {
            command.Execute();
        }
    } 
}
