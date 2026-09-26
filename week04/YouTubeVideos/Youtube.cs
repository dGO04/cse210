using System.IO;
using System;

public class Youtube
{
    private List<Video> _videos = new List<Video>();

    
    private string[] ReadFile(string fileName)
    {
        
        string[] lines = System.IO.File.ReadAllLines(fileName);
        return lines;
    }

    public void AddVideos()
    {
        string[] lines = ReadFile("videos.csv");

        foreach (string line in lines)
        {
            string cleanLine = line.Trim();
            string[] parts = cleanLine.Split(" / ");
            
            if (parts.Count() > 1)
            {
                //Store all video details
                string title = parts[0].Trim('"');
                string author = parts[1].Trim('"');
                int lengthSeconds = int.Parse(parts[2]);

                string commentBLock = parts[3].Trim('"'); 
                string[] comments = commentBLock.Split(" | ");

                Video video = new Video(title:title, author:author, videoLength:lengthSeconds);
                video.AddComments(comments);
                _videos.Add(video);
            }
        }
    }
    
    public void DisplayAllVideos()
    {
        foreach (Video video in _videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}