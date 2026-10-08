using System;
using System.Diagnostics.CodeAnalysis;

/*Additional Creativity: I added infor verification
so that program displays message when they enter an 
incorrect menu option. I made sure that in the
reflection activity, the same question isnt generated
twice in a reflection session.*/

class Program
{
    static void Main(string[] args)
    {
        //Quit always has to be the last option in the array
        string[] menuOptions = ["Breathing activity", "Reflecting activity", "Listing activity", "Quit"];

        int selectedOption = 0;
        while (selectedOption != 4)
        {
            bool validResponse = false;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to The Mindfullness Program\n");

                    //Display all menu options in the array of options
                    for(int i = 1; i <= menuOptions.Length; i++)
                    {
                        Console.WriteLine($"{i}. {menuOptions[i - 1]}");
                    }

                    Console.Write("\nSelect an option: ");
                    selectedOption = int.Parse(Console.ReadLine());
                    validResponse = true;

                    if (selectedOption < 1 || selectedOption > menuOptions.Length)
                    {
                        validResponse = false;

                    }

                } catch(FormatException)
                {
                    validResponse = false;
                }

                if (validResponse == false)
                {
                    Console.WriteLine("Invalid option. Try Again!!");
                }
            }while(validResponse == false);

            ExecuteMenuOption(option:selectedOption, menuOptions:menuOptions.Length);
        }
    }

    static void ExecuteMenuOption(int option, int menuOptions)
    {
        if (option < menuOptions)
        {
            if (option == 1)
            {
                string bDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
                BreathingActivity breathAct = new BreathingActivity(activityDescription:bDescription);
                breathAct.DisplayStartingMessage();
                breathAct.Breathing();
                breathAct.DisplayGoodbyeMessage();
            } else if (option == 2)
            {
                string rDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                ReflectionActivity reflectAct = new ReflectionActivity(activityDescription:rDescription);
                reflectAct.DisplayStartingMessage();
                reflectAct.Reflection();
                reflectAct.DisplayGoodbyeMessage();
            } else if (option == 3)
            {
                string lDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                ListingActivity listAct = new ListingActivity(activityDescription:lDescription);
                listAct.DisplayStartingMessage();
                listAct.Listing();
                listAct.DisplayGoodbyeMessage();
            }
        }
    }

}