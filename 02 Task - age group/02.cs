using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете навършени години: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Вашият социален статус е: ");
        if (age < 1) Console.WriteLine("бебе");
        {
            if (age >= 1 && age <= 6) Console.WriteLine("дете");
            {
                if (age >= 7 && age <= 11) Console.WriteLine("ученик");
                {
                    if (age >= 12 && age <= 19) Console.WriteLine("тийнейджър");
                    {
                        if (age >= 20 && age <= 25) Console.WriteLine("студент");
                        {
                            if (age >= 26 && age <= 65) Console.WriteLine("работещ");
                            {
                                if (age > 65) Console.WriteLine("пенсионер");
                            }
                        }
                    }
                }
            }
        }


    }
}

