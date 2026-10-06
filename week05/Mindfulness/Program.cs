using System;

class Program
{
    static void Main(string[] args)
    {
        string[] characters = ["/", "|", @"\", "—"];
        for(int i = 0; i < 7; i++)
        {
            foreach (string character in characters) 
            {
                Console.WriteLine($"Loading: {character}");
                Thread.Sleep(100);
                Console.Clear();
            }
            
        }
    }
}


