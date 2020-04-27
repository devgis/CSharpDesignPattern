using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }
}
