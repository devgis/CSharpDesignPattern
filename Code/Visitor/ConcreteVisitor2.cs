using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    class ConcreteVisitor2 : Visitor
    {
      // Methods
      override public void VisitConcreteElementA(
        ConcreteElementA concreteElementA )
      {
        Console.WriteLine( "{0} visited by {1}",
          concreteElementA, this );
      }
      override public void VisitConcreteElementB(
        ConcreteElementB concreteElementB )
      {
        Console.WriteLine( "{0} visited by {1}",
          concreteElementB, this );
      }
    }
}
