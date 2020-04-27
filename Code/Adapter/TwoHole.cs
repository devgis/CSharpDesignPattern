using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public abstract class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("我是两个孔的插头");
        }
    }
}
