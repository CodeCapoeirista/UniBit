using System;

class Program
{
    static void Main()
    {
        Console.Write("Въведете брой елементи в масива: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] randomArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
            
        {
            Random random = new Random();
            randomArray[i] = random.Next(int.MinValue, int.MaxValue);
        }
        Console.WriteLine(randomArray[arrayLength]);
    }
}