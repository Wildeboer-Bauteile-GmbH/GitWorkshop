using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JuergenT
    {
        internal static int Fibonacci(int n)
        {
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
    }
}
