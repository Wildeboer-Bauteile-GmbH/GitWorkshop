﻿using System;
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
            if (n <= 1)
            {
                return n;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
