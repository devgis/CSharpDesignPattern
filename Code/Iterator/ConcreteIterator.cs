using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 具体迭代器
    /// </summary>
    public class ConcreteIterator : IIterator
    {
        private ConcreteList list;

        private int index;

        public ConcreteIterator(ConcreteList list)
        {
            this.list = list;

            index = 0;
        }

        public bool MoveNext()
        {
            if (index < list.Length)

                return true;

            else

                return false;
        }

        public Object CurrentItem()
        {
            return list.GetElement(index);
        }

        public void First()
        {
            index = 0;
        }

        public void Next()
        {
            if (index < list.Length)
            {
                index++;
            }
        }
    }
}
