using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JuergenT
    {
        /// <summary>
        /// Calculate the Fibonacci number for a given n.
        /// </summary>
        /// <param name="n">the given numbe</param>
        /// <returns>the result</returns>
        /// <exception cref="ArgumentException">if n is less than 0</exception>
        internal static int Fibonacci(int n)
        {
            if(n< 0) throw new ArgumentException("n must be greater than or equal to 0");
            if (n == 0) return 0;
            int a = 0;
            int b = 1;
            while (n-- > 0)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        /// <summary>
        /// Least common multiple of two numbers.
        /// </summary>
        /// <param name="a">the first number</param>
        /// <param name="b">the second number</param>
        /// <returns>the result</returns>
        internal static int gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
