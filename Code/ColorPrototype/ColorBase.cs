using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorPrototype
{
    [Serializable]
    public abstract class ColorBase
    {
        public int R = 0;
        public int G = 0;
        public int B = 0;
        public virtual ColorBase Clone()
        {
            return this;
        }

        public virtual void ShowMe()
        {
            Console.WriteLine(string.Format(" r={0} g={1} b={2}", R, G, B));
        }
    }
}
