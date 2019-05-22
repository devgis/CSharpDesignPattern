using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 抽象迭代器
    /// </summary>
    public interface IIterator
    {
        bool MoveNext();

        Object CurrentItem();

        void First();

        void Next();
    }
}
