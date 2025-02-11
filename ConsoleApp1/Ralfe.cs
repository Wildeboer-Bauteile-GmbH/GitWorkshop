using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

internal class Ralfe
{
    public int Age { get; set; }

    public string Name { get; set; }

    public Ralfe(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}