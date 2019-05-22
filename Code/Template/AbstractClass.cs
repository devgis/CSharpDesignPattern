using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }

        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
    }
}
