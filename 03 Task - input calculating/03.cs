using System;

class Program
{
    static void Main()
    {
        double a, b, c, d;
        Console.Write("Въведете а = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Въведете b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Въведете c = ");
        c = double.Parse(Console.ReadLine());
        d = (a / b + b / a * 2.5);
        if (d > c) Console.WriteLine("d > c");
        {
            if (d < c) Console.WriteLine("d < c");
            {
                if (d == c) Console.WriteLine("d = c");
            }
        }
    }
}

