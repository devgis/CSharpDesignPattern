using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Flyweight
{
    public class FlyweightFactory
    {
        // 最好使用泛型Dictionary<string,Flyweighy>
        //public Dictionary<string, Flyweight> flyweights = new Dictionary<string, Flyweight>();
        public Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            // 更好的实现如下
            //Flyweight flyweight = flyweights[key] as Flyweight;
            //if (flyweight == null)
            //{
            // Console.WriteLine("驻留池中不存在字符串" + key);
            // flyweight = new ConcreteFlyweight(key);
            //}
            //return flyweight;

            return flyweights[key] as Flyweight;
        }
    }

}
