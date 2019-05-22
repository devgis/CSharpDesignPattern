using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Visitor
{
    class ObjectStructure
    {
        // Fields
        private ArrayList elements = new ArrayList();

        // Methods
        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Detach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in elements)
                e.Accept(visitor);
        }
    }
}
