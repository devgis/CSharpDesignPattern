﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.ShowMessage();
            Console.Read();
        }
    }
}
