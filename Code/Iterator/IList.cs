using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// 抽象聚集
    /// </summary>
    public interface IList
    {
        IIterator GetIterator();
    }
}
