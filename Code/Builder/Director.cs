using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class Director
    {
        // 组装电脑
        public void Construct(Builder builder)
        {
            builder.BuildPartCPU();
            builder.BuildPartMainBoard();
        }
    }
}
