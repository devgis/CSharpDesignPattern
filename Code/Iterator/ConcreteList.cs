using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 具体聚集
    /// </summary>
    public class ConcreteList : IList
    {
        int[] list;

        public ConcreteList()
        {
            list = new int[] { 1, 2, 3, 4, 5 };
        }

        public IIterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return list.Length; }
        }

        public int GetElement(int index)
        {
            return list[index];
        }
    }
}
