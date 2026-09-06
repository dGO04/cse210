using System;

class Program
{
    static void Main(string[] args)
    {
        
        //Request and store a grade to the user
        Console.Write("What is your grade? ");
        string gradeStr = Console.ReadLine();
        int grade = int.Parse(gradeStr); //Convert the string grade into an integer
        string gradeLetter = ""; //Store the letter equivalent to your grade

        //Compare grade to assign it the right letter
        if (grade >= 90)
        {
            gradeLetter = "A";
        }

        else if (grade >= 80)
        {
            gradeLetter = "B";
        }

        else if (grade >= 70)
        {
            gradeLetter = "C";
        }

        else if (grade >= 60)
        {
            gradeLetter = "D";
        }

        else if (grade < 60)
        {
            gradeLetter = "F";
        }

        //Display the grade to the user
        Console.WriteLine($"\nYour grade is: {gradeLetter}");

        //Evaluate the grade and display message if the passed or not
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!!");
        } 
        else
        {
            Console.WriteLine("You didn't pass the class. Try Again next semester!!");
        }
    }
}