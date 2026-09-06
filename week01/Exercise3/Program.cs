using System;

class Program
{
    static void Main(string[] args)
    {
        //Generate a random number as the magic number
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);
    
        int guessNumber = 0;
        //Keep asking the user for a guess until its right
        do
        {
            Console.Write("\nWhat is your guess? ");
            string guessStr = Console.ReadLine();
            guessNumber = int.Parse(guessStr);

            //Evaluate users response and prompt to go Higher or Lower on the guess
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!");
            }


        } while (magicNumber != guessNumber);

    }
}