using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqNumber = SquareNumber(userNumber);

        DisplayResult(sqNumber:sqNumber, name:name);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(int sqNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is: {sqNumber}");
    }
}