using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject cs = new ConcreteSubject();
            cs.Attach(new ConcreteObserver(cs, "James"));
            cs.Attach(new ConcreteObserver(cs, "Jane"));

            cs.SubjectState = "OK";
            cs.Notify();
            Console.Read();
        }
    }
}
