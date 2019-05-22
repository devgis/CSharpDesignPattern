using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility
{
    //具体传递者(ConcreteHandler)
    class ManagerHigher : Higher
    {
        public ManagerHigher(string name) : base(name) { }
        public override void ExeApply(Apply apply)
        {
            if (apply.ApplyDay <= 1)
                Console.WriteLine(Name + " 批准 " + apply.ApplyName + " 申请了 " + apply.ApplyDay + "天假期");
            else
                higher.ExeApply(apply);
        }
    }
}
