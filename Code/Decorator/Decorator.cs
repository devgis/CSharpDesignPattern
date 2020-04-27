﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class Decorator : Phone
    {
        private Phone phone;

        public Decorator(Phone p)
        {
            this.phone = p;
        }

        public override void Print()
        {
            if (phone != null)
            {
                phone.Print();
            }
        }
    }

}
