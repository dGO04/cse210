using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for name
        Console.Write("What is your Name? ");
        string name = Console.ReadLine(); //Store name

        //Ask the user for lastName
        Console.Write("What is your Last Name? ");
        string lastName = Console.ReadLine();

        //Display name and lastName to user
        Console.WriteLine($"\nYour name is {lastName}, {name} {lastName}");

    }
}