public class ReflectionActivity : Activity
{
    
    private List<string> _prompts = [
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."];

    private List<string> _questions = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"];

    private List<int> _selectedItems = new List<int>();
    
    public ReflectionActivity(string activityDescription, string activityName = "Reflection") : base(activityName:activityName, activityDescription:activityDescription)
    {
        
    }

    public void Reflection()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n --- {GetRandomItem(_prompts)} --- ");
        Console.Write("\nWhen you're ready, type any key and press enter to continue");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions as they're related to this experience");
        CountdownAnimation(prompt:"You may begin in", durationSeconds:5000);
        Console.Clear();
         _selectedItems = [];
        GetLoadingMessage(prompt:$"> {GetRandomItem(_questions)}", durationSeconds:(_activityDuration * 1000)/2);
        GetLoadingMessage(prompt:$"> {GetRandomItem(_questions)}", durationSeconds:(_activityDuration * 1000)/2);
    }

    private string GetRandomItem(List<string> items)
    {
        Random random = new Random();
        int randomNumber;
        
        do
        {
          randomNumber = random.Next(0, items.Count());

        } while(_selectedItems.Contains(randomNumber));
        
        
        _selectedItems.Add(randomNumber);

        return items[randomNumber];
    }
}