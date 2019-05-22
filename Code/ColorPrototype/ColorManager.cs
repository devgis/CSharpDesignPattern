using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorPrototype
{
    public class ColorManager
    {
        RGBAColor rgbColor = new RGBAColor();

        public ColorBase ColorBase
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public ColorBase GetNewColor()
        {
            return rgbColor.Clone();
        }
    }
}
