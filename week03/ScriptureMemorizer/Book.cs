using System;
using System.IO;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
public class Book
{
    private List<Scripture> _scriptures = new List<Scripture>();

    private string[] ReadFile()
    {
        
        string fileName = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);

        return lines;
    }

    public void AddScriptures()
    {
        string[] lines = ReadFile();

        foreach (string line in lines)
        {
            string[] scriptureDetails = line.Trim().Split("|");
            string reff = scriptureDetails[0];
            string scriptureText = scriptureDetails[1];

            //Separete the reference details
            string[] reffDetails = reff.Split(" ");
            string book = "";
            string chapterAndVerses = "";

            if (reffDetails.Count() == 3)
            {
                book = $"{reffDetails[0]} {reffDetails[1]}";
                chapterAndVerses = reffDetails[2];
            } else
            {
                book = reffDetails[0];
                chapterAndVerses = reffDetails[1];
            }

            string[] chAndVerDetails = chapterAndVerses.Split(":");
            int chapter = int.Parse(chAndVerDetails[0]);

            //Store verses details
            string verses = chAndVerDetails[1];
            string[] versesDetails = verses.Split("-");
            int verse = 0;
            int endVerse = 0;

            if (versesDetails.Count() > 1)
            {
                verse = int.Parse(versesDetails[0]);
                endVerse = int.Parse(versesDetails[1]);
            } else
            {
                verse = int.Parse(versesDetails[0]);
            }

            Reference reference = new Reference(book:book, chapter:chapter, verse:verse, endVerse:endVerse);
            Scripture newScripture = new Scripture(reference:reference, text:scriptureText);

            _scriptures.Add(newScripture);
        }
    }

    public Scripture GenerateRandomScripture()
    {   
         
        Random rndm = new Random();
        int randomNumber = rndm.Next(0, _scriptures.Count());

        return _scriptures[randomNumber];
    }

}