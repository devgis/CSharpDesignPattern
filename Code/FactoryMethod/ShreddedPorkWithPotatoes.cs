using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝好了");
        }
    }
}
