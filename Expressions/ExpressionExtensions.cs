using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public static class ExpressionExtensions
    {
        public static Expression ToExpression(this double number)
        {
            return new ConstantExpression(number);
        }
    }
}
