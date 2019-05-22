using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    abstract class Visitor
    {
        // Methods
        abstract public void VisitConcreteElementA(
          ConcreteElementA concreteElementA);
        abstract public void VisitConcreteElementB(
          ConcreteElementB concreteElementB);
    }
}
