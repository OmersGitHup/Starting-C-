using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorwithClassMethod
{
    internal class calculator
    {
        public int Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public int time(int x, int y)
        {
            int result = x * y;
            Console.WriteLine   (result);
            return result;
        }
        public int sub(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
            return (result);
        }
        public int div(int x, int y)
        {
            int result = x / y;
            Console.WriteLine(result);
            return (result);
        }

    }
}
