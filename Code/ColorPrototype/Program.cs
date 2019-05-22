using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colorManager = new ColorManager();
            ColorBase red = colorManager.GetNewColor();
            red.R = 255;

            ColorBase green = colorManager.GetNewColor();
            green.G = 255;

            ColorBase blue = colorManager.GetNewColor();
            blue.B = 255;

            red.ShowMe();
            green.ShowMe();
            blue.ShowMe();

            Console.Read();
        }
    }
}
