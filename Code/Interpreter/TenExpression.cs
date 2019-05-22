using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    /// <summary>
    /// A 'TerminalExpression' class
    /// <remarks>
    /// 用来核对罗马字附中的X, XL, L and XC
    /// </remarks>
    /// </summary>
    class TenExpression : Expression
    {
        public override string One() { return "X"; }
        public override string Four() { return "XL"; }
        public override string Five() { return "L"; }
        public override string Nine() { return "XC"; }
        public override int Multiplier() { return 10; }
    }
}
