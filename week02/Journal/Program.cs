using System;
using System.IO;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Display Welcome message to the user
        Console.WriteLine("Welcome to The Journal Program");

        int option = 0;
        //Store all Menu options. If you add more menu options, quit should always be last
        List<string> options = ["Write", "Display", "Load", "Save", "Quit"];

        Journal journal = new Journal();

        journal._prompts = ["What are 3 things im gratefull for?",
                            "How did I see the hand of the Lord today?",
                            "What is 1 thing I can do better tomorrow?",
                            "What would I have done today if I was 10 times more confident?",
                            "How did I advance my personal goals today?",
                            "What is 1 thing thats taking my happiness and peace away?" 
                            ];

        //Keep asking the user to select a menu option
        //until user wants to exit the program
        do
        {
            
            DisplayMenu(options:options);
            option = int.Parse(Console.ReadLine());

            //check if user option is within the range 
            //of the available menu options
            if (option >= 1 && option <= options.Count() - 1)
            {
                ExecuteOptions(option:option, journal:journal);

            } else if (option < 1 || option > options.Count()) 
            {
                Console.WriteLine("Select a valid option");
            }

        }while(option != options.Count());
    }

    static void DisplayMenu(List<string> options)
    {
        /*Function to display all the menu options
            Parameters: 
                List<string> options: it contains a list
                of all the options in the menu
            Return: nothing*/

        Console.WriteLine();//Empty line for good formatting

        int index = 1;

        //Display all menu options found in options list
        foreach (string option in options)
        {
            Console.WriteLine($"{index}. {option}");

            index += 1;
        }

         Console.Write("Select an option:");

    }

    static void ExecuteOptions(int option, Journal journal)
    {
        /*Function to execute the selected menu option
            Parameters: 
                int option: the menu option that the
                user selected
                Journal journal: a new instance of the
                Journal object.
            Return: nothing*/

        if (option == 1)
        {
    
            journal.AddEntry();
        } else if (option == 2)
        {
            
            journal.DisplayAll();
        } else if (option == 3)
        {
        
            journal.LoadFromFile();
        } else if (option == 4)
        {

            journal.SaveToFile();
        } 


    }

}