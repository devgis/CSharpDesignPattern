using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public abstract class Subject
    {
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer">观察者</param>
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer">观察者</param>
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// 通知观察者
        /// </summary>
        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }
}
