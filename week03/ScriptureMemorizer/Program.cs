using System;
using System.IO;


/*Additional Creativity: I created a book class
that keeps track of multiple scriptures and every 
time the program starts, a random one is selected 
and displayed. I created a generatedNumber list in
the Scripture class, to keep track of the words 
already hidden, so we pick a random word to hide 
from those that werent hidden yet.*/ 

class Program
{
    static void Main(string[] args)
    {

        Book book = new Book();
        book.AddScriptures();
        Scripture scripture = book.GenerateRandomScripture();

        string userInput = "";
        do
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());    

            Console.Write("\nPress enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            if (userInput.ToLower() != "quit")
            {
                if (userInput.Trim() == "")
                {  
                    scripture.HideRandomWords(numberToHide:3);
                }
            }

        } while (userInput.ToLower() != "quit");
    }
}