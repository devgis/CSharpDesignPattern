using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class ApplePhone : Phone
    {
        /// <summary>
        /// 重写基类方法
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("开始执行具体的对象——苹果手机");
        }
    }
}
