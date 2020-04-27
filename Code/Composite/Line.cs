using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 简单图形类——线
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name)
            : base(name)
        { }

        // 重写父类抽象方法
        public override void Draw()
        {
            Console.WriteLine("画  " + Name);
        }
    }
}
