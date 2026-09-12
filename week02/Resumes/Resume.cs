//This contains the class for the Resume data type
public class Resume
{
    public string _name;
    public List<string> _jobs = [];

    //Create constructor for this class
    public Resume()
    {
        
    }

    public void Display()
    {
        //Get persons name and display it
        Console.WriteLine($"Name: {_name}");

        //Display a lists of the jobs
        Console.WriteLine("Jobs:");

        foreach (string job in _jobs) {
            
            Console.WriteLine(job);

        }
    }

}