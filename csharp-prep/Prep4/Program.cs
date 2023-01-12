using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int inputNumber = 0;
        while (inputNumber != 0)
        {
            Console.Write("Enter a number: ");
            string addnumber = Console.ReadLine();
            inputNumber = int.Parse(addnumber);

            if (inputNumber != 0)
            {
                numbers.Add(inputNumber);
            }

        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int min = 999999;
        foreach (int number in numbers)
        {
            if (number > 0 && number < min)
            {
                min = number;
            }
        }

        Console.WriteLine($"The max is: {min}");
        
    }
}