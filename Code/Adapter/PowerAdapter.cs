using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PowerAdapter : TwoHole, IThreeHole
    {
        /// <summary>
        /// 实现三个孔插头接口方法
        /// </summary>
        public void Request()
        {
            // 调用两个孔插头方法
            this.SpecificRequest();
        }
    }
}
