using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        // 内部状态
        private string intrinsicstate;

        // 构造函数
        public ConcreteFlyweight(string innerState)
        {
            this.intrinsicstate = innerState;
        }

        /// <summary>
        /// 享元类的实例方法
        /// </summary>
        /// <param name="extrinsicstate">外部状态</param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体实现类: intrinsicstate {0}, extrinsicstate {1}", intrinsicstate, extrinsicstate);
        }
    }
}
