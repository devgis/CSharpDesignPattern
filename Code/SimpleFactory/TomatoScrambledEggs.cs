using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋！");
        }
    }
}
