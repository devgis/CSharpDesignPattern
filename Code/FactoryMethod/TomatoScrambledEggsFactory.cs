using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class TomatoScrambledEggsFactory : Creator
    {
        /// <summary>
        /// 负责创建西红柿炒蛋这道菜
        /// </summary>
        /// <returns></returns>
        public override Food CreateFoddFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}
