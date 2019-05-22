using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker();

            // Set and execute command 
            i.SetCommand(c);
            i.ExecuteCommand();
            Console.Read();
        }
    }
}
