using System;
using System.ComponentModel.Design;

public class GoalManager
{
    private int _score;
    private int _level;
    private List<string> _menuOptions = ["Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"];
    private List<Goal> _goals;

    public GoalManager() {
        _score = 0;
        _level = 1;
        _goals = new List<Goal>();
    }

    public void Start()
    {
        int selectedOption = 0;
        //Keep running program till user quits
        do
        {
        //Display welcome message to the user
        Console.Clear();
        Console.WriteLine("Welcome to The Eternal Quest Program\n");

        ComputeLevel();
        Console.WriteLine($"Level: {_level}");
        Console.WriteLine($"Score: {_score}\n");

        selectedOption = DisplayMenu(); //Display all menu options
        
        if (selectedOption != _menuOptions.Count())
        {
            ExecuteMenuOpt(selectedOption);
        }

        } while(selectedOption != _menuOptions.Count());
    }

    private int DisplayMenu()
    {
         /*This function iterates through an array
        containing all the options in the menu and 
        displays it to the user. It requests the user
        to chose an option and validates it to get the 
        right response.
        Parameters: 
            string[] menuOptions: a list containing
            all the options in the menu
        Return: The option selected by the user*/        
        
        //access each item in the list but also its leading number
        for(int i = 1; i <= _menuOptions.Count(); i++)
        {
            Console.WriteLine($"{i}. {_menuOptions[i - 1]}");
        }
        
        return VerifySelectedOption(message:"Select an option:", menuOptions:_menuOptions);
    }

    private int VerifySelectedOption(string message, List<string> menuOptions, string emptyMsg = "")
    {
        bool isValid = true;
        int selectedOption = 0;
        do
        {
            try
            {
                isValid = true;
                //Request user to select an option
                Console.Write($"\n{message} ");
                selectedOption = int.Parse(Console.ReadLine());
                
                if(selectedOption < 1 || selectedOption > menuOptions.Count())
                {
                    throw new FormatException();
                }    
            
            } catch (FormatException)
            {
                
                if (menuOptions.Count() == 0)
                {
                    isValid = true;
                    Console.WriteLine(emptyMsg);

                } else
                {
                    isValid = false;
                    Console.WriteLine("Invalid option. Try Again!!");
                }
            }

        } while(isValid == false);

        return selectedOption;
    }

    private void ExecuteMenuOpt(int selectedOption)
    {
        if (selectedOption == 1)
        {
            CreateGoal();
        
        } else if (selectedOption == 2)
        {
            ListGoalDetails();

        } else if (selectedOption == 3)
        {
            SaveGoals();

        } else if (selectedOption == 4)
        {
            //Request filename from the user
            Console.Write("\nWhat is the filename for the goal file? ");
            string fileName = $"{Console.ReadLine()}.txt";

            LoadGoals(fileName:fileName);

        } else if (selectedOption == 5)
        {
            RecordEvent();

        }
    }

    private void CreateGoal()
    {
        List<string> goalTypes = ["Simple Goal", "Eternal Goal", "Checklist Goal"];

        Console.WriteLine("\nTypes of Goals:");
        
        //Display all types of goals found in the list
        for(int i = 1; i <= goalTypes.Count(); i++)
        {
            Console.WriteLine($"{i}. {goalTypes[i - 1]}");
        }

        int selectedGoalType = VerifySelectedOption(message:"Which type of goal would you like to create?", menuOptions:goalTypes);

        try
        {
            if (selectedGoalType == 1)
            {
                Console.Write("\nWhat is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = int.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(shortName:goalName, description:goalDescription, points:goalPoints);
                _goals.Add(simpleGoal);

            } else if (selectedGoalType == 2)
            {
                Console.Write("\nWhat is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = int.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(shortName:goalName, description:goalDescription, points:goalPoints);
                _goals.Add(eternalGoal);

            } else if (selectedGoalType == 3)
            {
                Console.Write("\nWhat is the name of your goal? ");
                string goalName = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = int.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int goalTarget = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int goalBonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(shortName:goalName, description:goalDescription, points:goalPoints, target:goalTarget, bonus:goalBonus);
                _goals.Add(checklistGoal);

            }
            Console.WriteLine("\nSaving goal...");
            Thread.Sleep(2000);
            Console.WriteLine("Goal saved succesfully!!");
            Thread.Sleep(1500);

        } catch (FormatException)
        {
            Console.WriteLine("\nSaving goal...");
            Thread.Sleep(2000);
            Console.WriteLine("Invalid response. Goal not saved!!");
            Thread.Sleep(1500);
        }
    }

    private void ListGoalDetails()
    {
        if (_goals.Count() != 0)
        {
            Console.WriteLine("\nGoals:");
            for(int i = 1; i<=_goals.Count(); i++)
            {
                Console.WriteLine($"{i}. {_goals[i - 1].GetDetailsString()}");
            }

            Console.Write("\nPress enter to go back to the menu: ");
            Console.ReadLine();

        } else
        {
            Console.WriteLine("No goals added. Add a goal first!!");
            Thread.Sleep(1500);
        }
    }

    private void SaveGoals()
    {
        if(_goals.Count() != 0)
        {
            //Request filename from the user
            Console.Write("What is the filename for the goal file? ");
            string fileName = $"{Console.ReadLine()}.txt";

            string[] file = System.IO.File.ReadAllLines(fileName);

            if (file.Count() != 0)
            {
                LoadGoals(fileName:fileName);
                File.WriteAllText(fileName, string.Empty);
            }

            using(StreamWriter goalFile = new StreamWriter(fileName))
            {
                goalFile.WriteLine(_score);
                foreach(Goal goal in _goals)
                {
                    goalFile.WriteLine(goal.GetStringRepresentation());
                }
            }

            Console.WriteLine("\nSaving goals...");
            Thread.Sleep(2000);
            Console.WriteLine("Goals saved succesfully!!");
            Thread.Sleep(1500);

            _goals = [];
            
        } else
        {
            Console.WriteLine("No goals added. Add a goal first!!");
            Thread.Sleep(1500);

        }
    }

    private void LoadGoals(string fileName)
    {
        try
        {
            string[] file = System.IO.File.ReadAllLines(fileName);

            if (file.Count() != 0)
            {
                for(int i = 0; i <= file.Count() - 1; i++)
                {
                    if (i == 0)
                    {
                        string score = file[i].Trim();
                        _score += int.Parse(score);

                    } else
                    {
                        string[] parts = file[i].Split("|");
                        string[] nameParts = parts[0].Split(": ");
                        string goalName = nameParts[1];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);

                        if (parts.Count() == 3)
                        {
                            EternalGoal eternalGoal = new EternalGoal(shortName:goalName, description:description, points:points);
                            _goals.Add(eternalGoal);

                        } else if (parts.Count() == 4)
                        {
                            bool isComplete = bool.Parse(parts[3]);
                            SimpleGoal simpleGoal = new SimpleGoal(shortName:goalName, description:description, points:points, isComplete:isComplete);
                            _goals.Add(simpleGoal);
                            
                        } else if (parts.Count() == 6)
                        {
                            int bonus = int.Parse(parts[3]);
                            int target = int.Parse(parts[4]);
                            int amountCompleted = int.Parse(parts[5]);

                            ChecklistGoal checklistGoal = new ChecklistGoal(shortName:goalName, description:description, points:points, bonus:bonus, target:target, amountCompleted:amountCompleted);
                            _goals.Add(checklistGoal);

                        }
                    }
                }
                Console.WriteLine("\nLoading file...");
                Thread.Sleep(2000);
                Console.WriteLine("File loaded succesfully!!");
                Thread.Sleep(1500);

            } else
            {
                Console.WriteLine("File is empty. Save goals first!!");
                Thread.Sleep(1500);
            }

        } catch (FileNotFoundException)
        {
            Console.WriteLine("\nLoading file...");
            Thread.Sleep(2000);
            Console.WriteLine("File not found. File wasnt loaded!!");
            Thread.Sleep(1500);

        }
    }

    private void RecordEvent()
    {
        /*Function that gets a 
        goal to record by the user
        and calls the RecordEvent
        on that goal.*/

        if (_goals.Count() != 0)
        {
            ListGoalNames();

            List<string> options = [];
            foreach (Goal goal in _goals)
            {
                options.Add(goal.GetGoalName());
            }

            int pickedGoal = VerifySelectedOption(message: "Which goal did you accomplish?", menuOptions:options);
            Goal goalToRecord = _goals[pickedGoal - 1];
            
            if (goalToRecord.IsComplete())
            {
                Console.WriteLine("Goal is complete!! Cant record event.");
                Thread.Sleep(1500);

            } else
            {
                int points = goalToRecord.RecordEvent();
                _score += points;

                Console.WriteLine("\nRecording event...");
                Thread.Sleep(2000);
                Console.WriteLine("Event recorded succesfully!!");
                Thread.Sleep(1500);

            }
        } else
        {
            Console.WriteLine("No goals added. Add a goal first!!");
            Thread.Sleep(1500);
                
        }
    }

    private void ListGoalNames()
    {
        /*Function that goes through each
        goal in the list and displays its name*/

        Console.WriteLine("Goals:");
        //Display all goals in the list
        for(int i = 1; i <= _goals.Count(); i++)
        {
            Console.WriteLine($"{i}. {_goals[i - 1].GetGoalName()}");
        }
    }

    public void ComputeLevel()
    {
        int upgradePoints = 100;
        double rawLevel = (double)_score / upgradePoints; 
    
        string[] parts = rawLevel.ToString().Split(".");
        
        if(int.Parse(parts[0]) == 0)
        {
            _level = 1;
        } else
        {
            _level = int.Parse(parts[0]);
        }
    }
}