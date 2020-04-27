using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿炒蛋好了！");
        }
    }
}
