using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class ConcreteBuilder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuildPartCPU()
        {
            computer.Add("CPU2");
        }

        public override void BuildPartMainBoard()
        {
            computer.Add("Main board2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
