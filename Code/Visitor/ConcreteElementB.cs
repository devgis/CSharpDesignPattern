using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class ConcreteElementB : Element
    {
        // Methods
        override public void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public void OperationB()
        {
        }
    }
}
