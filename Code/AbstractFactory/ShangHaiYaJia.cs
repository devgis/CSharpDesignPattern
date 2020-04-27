using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class ShangHaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("上海的鸭架子");
        }
    }
}
