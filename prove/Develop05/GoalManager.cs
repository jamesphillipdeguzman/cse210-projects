using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.IO;
using System.Net;
using System.Linq.Expressions;

namespace Develop05;
// Initializes and empty list of goals and sets the player's score to be 0.
public class GoalManager
{
    // Keep track of the list of goals as well as the players score.
    protected List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _point;
    private int _ctr = 0;
    private string _chosenGoal;
    private string _chosenGoal2;
    private string _goalNames;
    private string _theGoal;
    private int _item = 0;
    private int _initialAmount;
    private int _amountCompleted;
    private int _initialBonus;
    private int _bonus;
    private string userInput = "";
    private bool _status = false;
    private string _Completed = "";

    public GoalManager() { }
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
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
            try
            {

                switch (userInput)
                {
                    case "1":
                        // 1. Create New Goal
                        _initialAmount = 0;
                        _initialBonus = 0;
                        CreateGoal();
                        break;
                    case "2":
                        // List Goals (print to the console)
                        if (_status == false && _score == 0)
                        {
                            Console.WriteLine(_chosenGoal);
                        }
                        else
                        {

                            foreach (Goal goal in _goals)
                            {
                                if (goal.IsComplete(true))
                                {
                                    // Iterate through all the child classes and override the methods as necessary
                                    Console.WriteLine(goal.GetDetailString4(goal.IsComplete(_status), _amountCompleted, _bonus));
                                }
                                else
                                {
                                    // Iterate through all the child classes and override the methods as necessary
                                    Console.WriteLine(goal.GetDetailString4(goal.IsComplete(_status), _initialAmount, _initialBonus));
                                }

                            }

                        }

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
                        _ctr = 0;
                        _chosenGoal2 = "";
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
            }
            // try to catch other errors here and ignore them (e.g., if user typed something else not part of the menu system)
            catch (Exception e)
            {
                Console.WriteLine($"An error occured {e}");
            }

        } while (userInput != "6");


    }

    // Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nTotal Score: {_score} points.\n");
    }

    // Lists the names of each of the goals.
    public void ListGoalNames()
    {

        foreach (Goal goal in _goals)
        {
            _ctr += 1;
            // Do this if user input is either a List Goals or Load Goals, and then, show the appropriate GetDetailString.
            if (userInput == "2" || userInput == "4")
            {
                _chosenGoal += _ctr + ". " + goal.GetDetailString(goal.IsComplete(_status)) + "\n";

            }
            // User input was '5' or Record Event
            else if (userInput == "5")
            {
                _chosenGoal2 += _ctr + ". " + goal.GetDetailString2() + "\n";
            }
            else
            {
                break;

            }

            ListGoalDetails(goal);

        }

    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails(Goal goal)
    {
        // If user chose to list the goal or load the goal, return name and description of the activity.
        if (userInput == "2" || userInput == "4")
        {
            goal.GetDetailString(_status);

        }
        // If user chose to Record an event, only return the name of the activity
        else if (userInput == "5")
        {
            goal.GetDetailString2();

        }

    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        // Intialize variables here
        _chosenGoal = "";
        _ctr = 0;
        string myGoal = "";

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
            int _amountCompleted = 0;
            myGoal = "Checklist Goal";

            ChecklistGoal checklistGoal = new ChecklistGoal(myGoal, goalName, shortDesc, pointAmount, bonusPoints, goalFrequency, _amountCompleted);
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

        foreach (Goal goal in _goals)
        {
            _ctr += 1;
            _chosenGoal2 += _ctr + ". " + goal.GetDetailString2() + "\n";

            ListGoalDetails(goal);

        }
        Console.WriteLine("The goals are: ");
        Console.WriteLine(_chosenGoal2);
        Console.Write("Which goal did you accomplish? ");
        // Deserialize _chosenGoal2
        _item = int.Parse(Console.ReadLine());
        string[] goalName = _chosenGoal2.Split("\n");
        string theGoalItem = $"{goalName[_item - 1].Trim()}";
        string[] tempGoal = theGoalItem.Split(":");
        string tempGoal2 = $"{tempGoal[0]}";
        string[] temp = tempGoal2.Split(".");
        string goalTemp = temp[1].Trim();
        _theGoal = goalTemp;
        string tempPts = $"{tempGoal[1]}";
        string[] tempPts2 = tempPts.Split("-");
        string pts = tempPts2[1].Trim();
        int _points = int.Parse(pts);
        int i = 0;

        foreach (Goal goal in _goals)
        {
            // This will iterate through each child class until the correct points is returned...
            Goal goal1 = new SimpleGoal();
            _point = goal.RecordEvent(goal);

            if (i == _item - 1)
            {
                Console.WriteLine($"+{_point}");
                // Only Simple Goals are completed, true or false.
                if (_theGoal == "Simple Goal")
                {
                    _status = goal.IsComplete(true);
                    _Completed = goal.GetDetailString(true);
                }
                else if (_theGoal == "Checklist Goal")
                {
                    _amountCompleted += 1;
                }
                break;
            }
            else
            {
                i++;
            }

        }

        _score += _point;

        if (_status == true && _theGoal == "Simple Goal") Console.WriteLine("Goal completed!");
        Console.WriteLine($"Congratulations! You've earned {_point} points for this {_theGoal.ToLower()}.");
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
        // Ask for the filename to load the goals
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine().Trim().ToLower();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] part = line.Split(":");

            string goalName = part[0].Trim();
            // If goalName is empty, skip it.
            if (goalName == "" || line.Length == 0) break;

            string[] parts = line.Split(" | ");
            switch (goalName)
            {
                case "Simple Goal":
                    string goal1 = parts[0].Trim();
                    string shortName1 = parts[1].Trim();
                    string description1 = parts[2].Trim();
                    int points1 = int.Parse(parts[3].Trim());
                    bool completed1 = Convert.ToBoolean(parts[4].Trim());

                    SimpleGoal simpleGoal = new SimpleGoal(goal1, shortName1, description1, points1);
                    // Pass goal completion status
                    _status = simpleGoal.IsComplete(completed1);
                    _goals.Add(simpleGoal);


                    break;
                case "Eternal Goal":
                    string goal2 = parts[0].Trim();
                    string shortName2 = parts[1].Trim();
                    string description2 = parts[2].Trim();
                    int points2 = int.Parse(parts[3].Trim());

                    EternalGoal eternalGoal = new EternalGoal(goal2, shortName2, description2, points2);
                    _goals.Add(eternalGoal);

                    break;
                case "Checklist Goal":
                    string goal3 = parts[0].Trim();
                    string shortName3 = parts[1].Trim();
                    string description3 = parts[2].Trim();
                    int points3 = int.Parse(parts[3].Trim());
                    int bonus = int.Parse(parts[4].Trim());
                    int target = int.Parse(parts[5].Trim());
                    int completed = int.Parse(parts[6].Trim());
                    _amountCompleted = completed;

                    ChecklistGoal checklistGoal = new ChecklistGoal(goal3, shortName3, description3, points3, bonus, target, completed);
                    _goals.Add(checklistGoal);

                    break;
                default:
                    if (parts[0].Trim() == "") break;
                    _score = int.Parse(parts[0].Trim());

                    break;

            }

        }

        ListGoalNames();

    }

}
