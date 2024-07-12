using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.IO;

namespace Develop05;
// Initializes and empty list of goals and sets the player's score to be 0.
public class GoalManager
{

    // Keep track of the list of goals as well as the players score.
    protected List<Goal> _goals = new List<Goal>();
    private int _score;

    private int _ctr = 0;

    private string _chosenGoal;

    private string _goalNames;


    public GoalManager()
    {

    }
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
        string userInput = "";

        do
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine().Trim();

            switch (userInput)
            {
                case "1":
                    // 1. Create New Goal
                    CreateGoal();
                    break;
                case "2":
                    // List Goals (print to the console)
                    Console.WriteLine(_chosenGoal);
                    break;
                case "3":
                    // 3. Save Goals
                    _ctr = 0;
                    SaveGoals();
                    break;
                case "4":
                    // 4. Load Goals
                    LoadGoals();
                    break;
                case "5":
                    // 5. Record Event
                    RecordEvent();
                    break;
                case "6":
                    // Quit the program
                    Console.WriteLine("Bye!\n");
                    break;
                default:
                    // Catch invalid inputs
                    Console.WriteLine("Invalid Input!\n");
                    break;

            }
        } while (userInput != "6");

    }

    // Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    // Lists the names of each of the goals.
    public void ListGoalNames()
    {
        // string allGoalNames = "";
        // _ctr += 1;
        // string[] goalName = _chosenGoal.Split(" | ");
        // string theGoalName = $"{_ctr}. [ ] {goalName[0]} ({goalName[1]})";

        // List<string> _goalNames = new List<string>();
        // _goalNames.Add(theGoalName);
        // foreach (string _goalName in _goalNames)
        // {
        //     allGoalNames += _goalName                                                    ;
        //     Console.WriteLine(allGoalNames);
        // }

        foreach (Goal goal in _goals)
        {
            _ctr += 1;
            _chosenGoal += _ctr + ". " + goal.GetDetailString() + "\n";

            ListGoalDetails(goal);

            // Console.WriteLine(_chosenGoal);
        }

    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails(Goal goal)
    {
        string _goalNames = goal.GetDetailString();
        // Console.WriteLine($"{myGoal}");

    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        // Intialize variables here
        _chosenGoal = "";
        _ctr = 0;
        string myGoal = "";
        // List<Goal> _goals = new List<Goal>();
        // Ask user which goal type they want to add to the list
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        // Pick up their chosen goal
        string userChoice = Console.ReadLine();

        // Choice# 1: Add Simple Goal
        if (userChoice.Trim().ToLower() == "1")
        {
            // Ask the same set of questions each time for Simple Goal and Eternal Goal
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string shortDesc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointAmount = int.Parse(Console.ReadLine());

            myGoal = "Simple Goal";
            SimpleGoal simpleGoal = new SimpleGoal(myGoal, goalName, shortDesc, pointAmount);
            _goals.Add(simpleGoal);
        }
        // Choice# 2: Add Eternal Goal
        else if (userChoice.Trim().ToLower() == "2")
        {
            // Ask the same set of questions each time for Simple Goal and Eternal Goal
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string shortDesc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointAmount = int.Parse(Console.ReadLine());

            myGoal = "Eternal Goal";
            EternalGoal eternalGoal = new EternalGoal(myGoal, goalName, shortDesc, pointAmount);
            _goals.Add(eternalGoal);
        }
        // Choice# 3: Add Checklist Goal
        else if (userChoice.Trim().ToLower() == "3")
        {
            // Ask the same set of questions each time for Simple Goal and Eternal Goal
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string shortDesc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int pointAmount = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalFrequency = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplish it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());
            int amountCompleted = 0;
            myGoal = "Checklist Goal";
            ChecklistGoal checklistGoal = new ChecklistGoal(myGoal, goalName, shortDesc, amountCompleted, pointAmount, goalFrequency, bonusPoints);
            _goals.Add(checklistGoal);


        }
        else
        {
            myGoal = "";
        }

        ListGoalNames();

    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {

    }

    //Saves the list of goals to a file.
    public void SaveGoals()
    {
        string myGoals = "";
        foreach (Goal goal in _goals)
        {
            _ctr += 1;
            myGoals += goal.GetStringRepresentation() + "\n";
        }

        // Ask for the filename to save the goals
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine().Trim().ToLower();
        using (StreamWriter goalFile = new StreamWriter(fileName))
        {
            goalFile.WriteLine(_score);
            goalFile.WriteLine(myGoals);
        }


    }

    // Loads the list of goals from a file.
    public void LoadGoals()
    {

    }

}
