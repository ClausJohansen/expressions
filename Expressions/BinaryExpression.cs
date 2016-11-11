using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public abstract class BinaryExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        protected abstract string OperatorSymbol { get; }

        public BinaryExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public sealed override string ToString()
        {
            return String.Format("{0} {1} {2}", left, OperatorSymbol, right);
        }
    }
}
