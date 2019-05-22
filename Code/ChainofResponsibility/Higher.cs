using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility
{
    abstract class Higher
    {
        public string Name { get; set; }
        public Higher higher;
        public void SetHigher(Higher _Higher)
        {
            this.higher = _Higher;
        }
        public Higher(string name)
        {
            Name = name;
        }
        public abstract void ExeApply(Apply apply);
    }
}
