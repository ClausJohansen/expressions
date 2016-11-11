using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create your expression here
            List<Expression> expressions = new List<Expression>()
            {
                    new PlusExpression(new ConstantExpression(4), new ConstantExpression(6)),
                    new MinusExpression(new ConstantExpression(4), new ConstantExpression(6)),
                    new MultiplyExpression(new ConstantExpression(4), new ConstantExpression(6))
            };

            foreach(Expression expr in expressions)
            {
                // We print the textual representation
                Console.Write(expr.ToString());

                Console.Write(" = ");

                // ... and then the result of the evaluating
                Console.WriteLine(expr.Evaluate());
            }

            Console.ReadKey();
        }
    }
}
