using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility
{
    //具体传递者(ConcreteHandler)
    class DirectorHigher : Higher
    {
        public DirectorHigher(string name) : base(name) { }
        public override void ExeApply(Apply apply)
        {
            if (apply.ApplyDay <= 5)
                Console.WriteLine(Name + " 批准 " + apply.ApplyName + " 申请了 " + apply.ApplyDay + "天假期");
            else
                higher.ExeApply(apply);
        }
    }
}
