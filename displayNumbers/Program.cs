using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.Write("Enter The number - ");
        string input = Console.ReadLine();
        int number;

        Console.WriteLine("Displaying numbers from 1 to the number you entered:");

        if (int.TryParse(input, out number))
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else Console.WriteLine(i);

            }

        }
        else
        {
            Console.WriteLine("Enter the correct number");
        }
    }
}