using System;

class Program
{
    static void Main()
    {
        //В условието не беше казано от къде взимаме стойностите, за това използвах потребителско въвеждане за всички променливи
        Console.Write("Моля въведете квадратура на апартамент 1: ");
        int areaA = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете квадратура на апартамент 2: ");
        int areaB = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете квадратура на апартамент 3: ");
        int areaC = int.Parse(Console.ReadLine());
        Console.Write("Моля въведете продажната цена на сградата: ");
        int buildingPrice = int.Parse(Console.ReadLine());
        int totalArea = areaA + areaB + areaC;      //Обща площ на сградата

        double percentA = (double)(areaA * 100) / totalArea; //Проценти от територията на сградата, която заема всеки апартамент
        double percentB = (double)(areaB * 100) / totalArea;
        double percentC = (double)(areaC * 100) / totalArea;

        double appA = (percentA / 100) * buildingPrice; //Стойност на апартамента на база процент от общата цена на сградата
        double appB = (percentB / 100) * buildingPrice;
        double appC = (percentC / 100) * buildingPrice;

        Console.WriteLine();
        Console.WriteLine("Собствениците Собствениците на апартаментите трябва да платят  \n{0} лева за апартамент 1, \n{1} лева за апартамент 2 \nи \n{2} лева за апартамент 3, \nтоест общо {3} лева.", Math.Round(appA, 2), Math.Round(appB, 2), Math.Round(appC, 2), buildingPrice);
    }
}

