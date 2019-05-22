using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            IIterator iterator;

            IList list = new ConcreteList();

            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.CurrentItem();
                Console.WriteLine(i.ToString());

                iterator.Next();
            }

            Console.Read();
        }
    }
}
