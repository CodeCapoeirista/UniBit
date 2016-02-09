using System;

    class Program
{
    static void Main()
    {
        char star = '*';
        byte height, i, j, k; //ползваме byte защото не очакваме потребителя да е грандоман
        Console.Write("Въведете височината на пирамидата: ");
        height = byte.Parse(Console.ReadLine());
        for (i = 1; i <= height; i++) //редовете
        {
            for (j = 1; j < height - i + 1; j++) // броя празни полета
            {
                Console.Write(" ");
            }
            for (k = 1; k <= i; k++) // броя * в ред
            {
                Console.Write(star);
                Console.Write(" ");
            }
            Console.WriteLine();

        }
    }
}