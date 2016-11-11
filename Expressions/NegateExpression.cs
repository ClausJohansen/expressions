using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public class NegateExpression : UnaryExpression
    {
        public override double Evaluate()
        {
            return expr.Evaluate() * -1;
        }

        public override string ToString()
        {
            return String.Format("-{0}", expr.ToString());
        }
    }
}
