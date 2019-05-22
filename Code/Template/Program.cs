using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass a = new ContreteClass();
            a.TemplateMethod();
            Console.Read();
        }
    }
}
