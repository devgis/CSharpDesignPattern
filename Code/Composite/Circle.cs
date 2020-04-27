using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Circle : Graphics
    {
        public Circle(string name)
            : base(name)
        { }

        // 重写父类抽象方法
        public override void Draw()
        {
            Console.WriteLine("画  " + Name);
        }
    }
}
