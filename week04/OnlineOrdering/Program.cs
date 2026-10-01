using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Amazon amazon = new Amazon();
        
        amazon.AddOrders();
        amazon.DisplayAllOrders();
    }
}