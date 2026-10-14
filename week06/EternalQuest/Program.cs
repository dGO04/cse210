using System;

class Program
{

/*Additional Creativity: I added another thing 
to gamify the program, every time the user reaches 
another 100 points their level increases by 1
I also added a way to add the goals in the list to 
the file that saves them without overriding its 
content but adding it to the rest already saved.
I added a function to verify that the selected option
in many places in the program is the right one, 
displaying an error message it entered the wrong one.*/
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();

    }
}