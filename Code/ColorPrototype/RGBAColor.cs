using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ColorPrototype
{
    [Serializable]
    public class RGBAColor : ColorBase
    {
        public override ColorBase Clone()
        {
            ColorBase color;
            MemoryStream memoryStream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(memoryStream, this);
            memoryStream.Position = 0;
            color = (RGBAColor)formatter.Deserialize(memoryStream);
            return color;
        }
    }
}
