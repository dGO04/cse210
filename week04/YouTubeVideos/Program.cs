    using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Clear();
        Console.WriteLine("Videos: ");
        Console.WriteLine();
        Youtube youtube = new Youtube();
        youtube.AddVideos();
        youtube.DisplayAllVideos();
    }
}