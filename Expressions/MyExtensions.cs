using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    public static class MyExtensions
    {
        public static int Times1000(this int number)
        {
            return number * 1000;
        }
    }
}
