using System;

class Program
{
    static void Main(string[] args)
    {
        for(int i = 0; i < 7; i++)
        {
            Console.WriteLine("Loading: /");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("Loading: |");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine(@"Loading: \");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("Loading: —");
            Thread.Sleep(100);
            Console.Clear();
        }
    }
}