using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class ConcreteElementA : Element
    {
        // Methods
        override public void Accept(Visitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public void OperationA()
        {
        }
    }
}
