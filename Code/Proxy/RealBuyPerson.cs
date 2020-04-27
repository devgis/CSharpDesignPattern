using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买一个IPhone和一台苹果电脑");
        }
    }

}
