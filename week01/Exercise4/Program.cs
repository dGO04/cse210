using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Initialize a new List to store numbers given by the user
        List<int> numbers = new List<int>();

        //Display instructions to the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number;
        //Request the user for numbers until they stop
        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                //add a number into the numbers list
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;
        //sum all items in the list and display total
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        Console.WriteLine($"The sum is: {sum}");

        //calculate average and display it 
        int numbersAmount = numbers.Count;
        float average = ((float)sum) / numbersAmount;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;
        //calculate the largest number and display it
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}