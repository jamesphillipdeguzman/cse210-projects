using System.Diagnostics.Contracts;
using System.Reflection.Metadata;
using System.IO;
using System.Net;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

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
    private string _theGoal;
    private int _item = 0;
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private string userInput = "";
    private bool _status = false;
    private string _Completed = "";

    private bool _isLoaded = false;

    public GoalManager() { }
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
        do
        {
            try
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
                        _target = 0;
                        _bonus = 0;
                        CreateGoal();
                        Console.WriteLine(">>Please choose Save, and then quit to save your file.");
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
                                _bonus = 0;
                                _amountCompleted = 0;
                                if (_amountCompleted != _target && _status == false)
                                {
                                    // Reset the bonus
                                    _bonus = 0;
                                    _amountCompleted = goal.GetDetailString6(_amountCompleted);
                                    _status = goal.IsComplete(false);
                                }
                                else
                                {
                                    // Grab the bonus, amount completed and status
                                    _bonus = goal.GetDetailString5(_bonus);
                                    _amountCompleted = goal.GetDetailString6(_amountCompleted);
                                    _status = goal.IsComplete(_status);
                                }
                                // Iterate through all the child classes and override the methods as necessary
                                Console.WriteLine(goal.GetDetailString4(_status, _amountCompleted, _bonus));

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
                        _isLoaded = true;
                        break;
                    case "5":
                        // 5. Record Event
                        if (_isLoaded == true)
                        {
                            _ctr = 0;
                            _chosenGoal2 = "";
                            RecordEvent();
                        }
                        else
                        {
                            Console.WriteLine(">>Please load the goal file first.");
                        }

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
                Console.WriteLine($">>An error occured: {e.Message}");
            }

        } while (userInput != "6");


    }

    // Displays the players current score.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nTotal Score: {_score} points.");

        List<string> praises = new List<string>();
        praises.Add("Wow, you're on a roll!");
        praises.Add("Great going!");
        praises.Add("You're so cool!");
        praises.Add("Keep it up!");
        praises.Add("You're wonderful!");

        Random randNum = new Random();
        int randPraise = randNum.Next(1, praises.Count);

        if (_score >= 50 && _score <= 200)
        {
            Console.WriteLine($">>{praises[randPraise]}");
        }
        else if (_score >= 201 && _score <= 600)
        {
            Console.WriteLine($">>{praises[randPraise]}");
        }
        else if (_score >= 601 && _score <= 1500)
        {
            Console.WriteLine($">>{praises[randPraise]}");
        }
        else if (_score >= 1501 && _score <= 4000)
        {
            Console.WriteLine($">>{praises[randPraise]}");
        }
        else if (_score > 4001)
        {
            Console.WriteLine($">>{praises[randPraise]}");
        }
        else
        {
            // just add a blank row
            Console.WriteLine();
        }



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
        try
        {
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

        catch (Exception e)
        {
            Console.WriteLine($">>An error occured: {e.Message}");
        }


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
        string tempPts = "";
        Console.WriteLine("The goals are: ");
        Console.WriteLine(_chosenGoal2);
        Console.Write("Which goal did you accomplish? ");
        // Deserialize _chosenGoal2
        _item = int.Parse(Console.ReadLine());
        string[] goalName = _chosenGoal2.Split($"\n");
        string theGoalItem = $"{goalName[_item - 1].Trim()}";
        string[] tempGoal = theGoalItem.Split("-");
        string tempGoal2 = $"{tempGoal[0].Trim()}";
        if (tempGoal2.Contains("Simple Goal"))
        {
            tempGoal2 = "Simple Goal";
        }
        else if (tempGoal2.Contains("Eternal Goal"))
        {
            tempGoal2 = "Eternal Goal";
        }
        else
        {
            tempGoal2 = "Checklist Goal";
        }
        _theGoal = tempGoal2;
        // Catch out of bounds array error for the points here...
        try
        {
            tempPts = $"{tempGoal[1].Trim()}";
        }
        catch
        {

            tempPts = $"{tempGoal[0].Trim()}";
        }


        int _points = int.Parse(tempPts);
        int i = 0;

        foreach (Goal goal in _goals)
        {
            // This will iterate through each child class until the correct points is returned...
            Goal goal1 = new SimpleGoal();
            _point = goal.RecordEvent(goal);

            if (i == _item - 1)
            {

                // Only Simple Goals are completed, true or false.
                if (_theGoal == "Simple Goal")
                {
                    _status = goal.IsComplete(true);
                    _Completed = goal.GetDetailString(true);
                }
                else if (_theGoal == "Checklist Goal")
                {
                    _amountCompleted += 1;
                    _amountCompleted = goal.GetDetailString6(_amountCompleted);
                    _bonus = goal.GetDetailString5(_bonus);
                    _status = goal.IsComplete(true);
                    goal.GetDetailString4(_status, _amountCompleted, _bonus);
                }
                break;
            }
            else
            {
                i++;
            }

        }


        if (_status == true && _theGoal == "Simple Goal")
        {
            _score += _point;
            Console.WriteLine($"+{_point}");
            Console.WriteLine("Goal completed!");
        }
        else if (_status == true && _theGoal == "Checklist Goal" && _amountCompleted == _target)
        {
            _point += _bonus;
            _score += _point;
            Console.WriteLine($"+{_point}");
            Console.WriteLine($"Congratulations! You've earned {_point} points for this {_theGoal.ToLower()} (i.e., +{_bonus} bonus points!)");
        }
        else
        {
            _score += _point;
            Console.WriteLine($"+{_point}");
            Console.WriteLine($"Congratulations! You've earned {_point} points for this {_theGoal.ToLower()}.");
        }

        // Auto-save here...
        SaveGoals();
        Console.WriteLine("Warning: Please choose quit after each saves to avoid overriding your existing data");

    }

    //Saves the list of goals to a file.
    public void SaveGoals()
    {
        string myGoals = "";
        foreach (Goal goal in _goals)
        {
            _ctr += 1;
            myGoals += goal.GetStringRepresentation() + "\n";
            // _bonus = goal.GetDetailString5(_bonus);
            // _amountCompleted = goal.GetDetailString6(_amountCompleted);
            // _status = goal.IsComplete(true);
            goal.GetDetailString4(_status, _amountCompleted, _bonus);
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
                    _target = target;
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
