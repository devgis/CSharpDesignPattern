using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    class Context
    {
        // Fields
        Strategy strategy;

        // Constructors
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        // Methods
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
