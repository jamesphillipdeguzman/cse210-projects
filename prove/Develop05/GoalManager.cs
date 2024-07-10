using System.Diagnostics.Contracts;

namespace Develop05;
// Initializes and empty list of goals and sets the player's score to be 0.
public class GoalManager
{

    // Keep track of the list of goals as well as the players score.
    private List<Goal> _goals;
    private int _score;


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
                    // 2. List Goals
                    ListGoalNames();
                    ListGoalDetails();
                    break;
                case "3":
                    // 3. Save Goals
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

    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {

    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string userChoice = Console.ReadLine();

        // Track the goal selected by user
        List<Goal> goals = new List<Goal>();
        // SimpleGoal simpleGoal1 = new SimpleGoal();
        // switch (userChoice)
        // {
        //     case "1": goals.Add("Simple Goal");

        // }



        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string shortDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int pointAmount = int.Parse(Console.ReadLine());

        SimpleGoal simpleGoal = new SimpleGoal(goalName, shortDesc, pointAmount);


    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void RecordEvent()
    {

    }

    //Saves the list of goals to a file.
    public void SaveGoals()
    {

    }

    // Loads the list of goals from a file.
    public void LoadGoals()
    {

    }

}
