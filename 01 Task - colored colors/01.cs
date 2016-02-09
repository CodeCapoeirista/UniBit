using System;


class Program
{
    static void Main()
    {
        string red = "червен";
        string yellow = "жълт";
        string blue = "син";
        string white = "бял";
        string green = "зелено";
        Console.WriteLine("Списък с цветовете преди добавянето: \n{0}, {1}, {2}, {3}", red, yellow, blue, white);
        Console.WriteLine("Списък с цветовете след добавянето: \n{0}, {1}, {2}, {3}, {4}", red, yellow, blue, white, green);
        Console.WriteLine("Списък с цветовете след сортирането: \n{0}, {1}, {2}, {3}, {4}", white, yellow, green, red, blue);
    }
}

