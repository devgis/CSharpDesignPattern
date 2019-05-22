using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three contexts following different strategies
            Context c = new Context(new ConcreteStrategyA());
            c.ContextInterface();

            Context d = new Context(new ConcreteStrategyB());
            d.ContextInterface();

            Context e = new Context(new ConcreteStrategyC());
            e.ContextInterface();
            Console.Read();
        }
    }
}
