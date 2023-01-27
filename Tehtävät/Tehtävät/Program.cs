using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int num1, num2, num3;
        int largest;

        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        num3 = int.Parse(Console.ReadLine());

        largest = num1;

        if (num2 > largest)
        {
            largest = num2;
        }
        if (num3 > largest)
        {
            largest = num3;
        }

        Console.WriteLine("The largest number is: " + largest);
    }
}