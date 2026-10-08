public class ListingActivity : Activity
{
    private List<string> _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    public ListingActivity(string activityDescription, string activityName = "Listing") : base(activityName:activityName, activityDescription:activityDescription)
    {
        
    }

    public void Listing()
    {
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt(_prompts)} --- ");
        CountdownAnimation(prompt:"You may begin in", durationSeconds:5000);
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_activityDuration);
        bool timeFinished = false;
        int itemsListed = 0;

        while (timeFinished == false)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemsListed += 1;

            DateTime currentTime = DateTime.Now;

            if (currentTime >= futureTime)
            {
                timeFinished = true;
            }
        }
        Console.WriteLine($"\nYou listed {itemsListed} items");
    }

    private string GetRandomPrompt(List<string> items)
    {
        Random random = new Random();
        int randomNumber = random.Next(0, items.Count());

        return items[randomNumber];
    } 
}