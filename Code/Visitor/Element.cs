using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    abstract class Element
    {
        // Methods
        abstract public void Accept(Visitor visitor);
    }
}
