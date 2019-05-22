using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer
{
    public class ConcreteSubject : Subject
    {
        private string _subjectState;

        /// <summary>
        /// 具体被观察者状态
        /// </summary>
        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
