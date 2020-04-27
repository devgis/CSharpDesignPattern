using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class ComplexGraphics : Graphics
    {
        private List<Graphics> complexGraphicsList = new List<Graphics>();
        public ComplexGraphics(string name)
            : base(name)
        { }

        /// <summary>
        /// 复杂图形的画法
        /// </summary>
        public override void Draw()
        {
            foreach (Graphics g in complexGraphicsList)
            {
                g.Draw();
            }
        }

        public void Add(Graphics g)
        {
            complexGraphicsList.Add(g);
        }
        public void Remove(Graphics g)
        {
            complexGraphicsList.Remove(g);
        }
    }
}
