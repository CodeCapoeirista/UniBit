using System;
class Program
{
    static void Main()
    {
        int distance, step, maxStep = 0, i = 0;
        Console.Write("Въведете разстоянието между А и В: ");
        distance = int.Parse(Console.ReadLine());
        Console.Write("Въведете стъпка: ");
        step = int.Parse(Console.ReadLine());

        while (distance >= maxStep)     //цикъл с условие на изпълнение
        {
           maxStep += step;             //увеличаване на maxStep със step на всеки цикъл
           i++;                         //променлива за брой на циклите
        }
        Console.WriteLine("Обект А задмина обект В след {0} стъпки", i);
    }
}

