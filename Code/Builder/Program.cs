using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 客户找到电脑城老板说要买电脑，这里要装两台电脑
            // 创建指挥者和构造者
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            // 老板叫员工去组装第一台电脑
            director.Construct(b1);

            // 组装完，组装人员搬来组装好的电脑
            Computer computer1 = b1.GetComputer();
            computer1.Show();

            // 老板叫员工去组装第二台电脑
            director.Construct(b2);
            Computer computer2 = b2.GetComputer();
            computer2.Show();

            Console.Read();
        }
    }
}
