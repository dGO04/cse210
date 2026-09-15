public class Journal
{
    public List<string> _prompts = [];
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
         /*Function that reads the entries list
        and displays it to the user
        Parameters: none*/

        if (_entries.Count() == 0)
        {
            Console.WriteLine("No entries found.");
        } else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public string PromptGenerator()
    {
        /*Function that gets a list of prompts and 
        returns a random one from the list.
        Parameters: none
        Return: the random prompt generated*/

        int promptsLenght = _prompts.Count();
        
        int random = Random.Shared.Next(0, promptsLenght);
        string prompt = _prompts[random];

        _prompts.RemoveAt(random);

        return prompt;
    }

    public void AddEntry()
    {
        /*Function that saves a prompt
        entered by the user
        Parameters: none*/

        if (_prompts.Count() != 0)
        {
            Entry entry = new Entry();

            //Get systems date and convert it to string
            DateTime now = DateTime.Now;
            string date = now.ToString("d");

            string prompt = PromptGenerator();
            Console.WriteLine(prompt);

            //Get the users response to the prompt we showed
            string response = Console.ReadLine();

            //Add prompt info into the entry object we created
            entry._date = date;
            entry._entryText = response;
            entry._promptText = prompt;

            _entries.Add(entry);
        } else
        {
            Console.WriteLine("No more questions for today.");    
        }
    }

    public void LoadFromFile()
    {
        /*Function that reads a file through a filename
        and saves it into the entries lists.
        Parameters: none*/

        Console.Write("Enter filename using cammelcase to load entries:");
        //Combine user filename with .txt at the end
        string fileName = Console.ReadLine();

        try
        {
            string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");

            if (lines.Count() != 0)
            {
                foreach (string line in lines)
                {
                    string cleanLine = line.Trim();
                    string[] parts = cleanLine.Split("|");

                    Entry entry = new Entry();

                    //Add prompt info into the entry object we created
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];

                    _entries.Add(entry);

                }
            } else
            {
                Console.WriteLine("File is empty");
            }
        } 
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found!");
        }
    }

    public void SaveToFile()
    {
        /*Function that gets the entry list and
        saves it into a file
        Parameters: none*/

        if (_entries.Count() != 0) {

            //Get the filename from the user
            Console.Write("Enter filename using cammelcase to save entries. example(myFileName):");
            //Combine user filename with .txt at the end
            string filename = $"{Console.ReadLine()}.txt";
            using (StreamWriter outputFile = new StreamWriter(filename))
            {   

                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            } 
        } else
        {
            Console.WriteLine("There are no entries to save");
        }
    }
}