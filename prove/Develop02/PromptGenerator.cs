using System;

namespace Develop02;

public class PromptGenerator
{
    public List<string> _prompts;

    // 7 journal prompts shown at random each time the user selects Menu# 1 - Write.
    public string GetRandomPrompt()
    {
        List<string> myPrompts = new List<string>();
        // My prompt list are all here ...
        myPrompts.Add("Who was the most interesting person I interacted with today?");
        myPrompts.Add("What was the best part of my day?");
        myPrompts.Add("How did I see the hand of the Lord in my life today?");
        myPrompts.Add("What was the strongest emotion I felt today?");
        myPrompts.Add("If I had one thing I could do over today, what would it be?");
        myPrompts.Add("What did I do to help someone?");
        myPrompts.Add("What life lesson have I learned today?");
        myPrompts.Add("Who was the person you like the least today, and why?");
        myPrompts.Add("What can you do to show more charity towards others?");
        myPrompts.Add("Which place did you go to today?");
        myPrompts.Add("Who did you spend most of your time?");
        myPrompts.Add("What did you buy at the grocery store?");
        myPrompts.Add("Were you on time at work today?");
        myPrompts.Add("What did you eat for breakfast?");
        myPrompts.Add("What did you eat for lunch?");
        myPrompts.Add("What did you eat for dinner?");
        myPrompts.Add("Did you use the treadmill? What was the number of miles you run and for how many minutes?");
        myPrompts.Add("When are you goin on vacation?");
        myPrompts.Add("Did you read the scriptures today? If yes, what was your favorite scripture verse?");
        myPrompts.Add("What are your academic goals today?");
        myPrompts.Add("How has the Spirit influenced your actions today?");
        myPrompts.Add("How many times did you pray today?");

        // Show a random journal prompt each time here.
        Random randNumber = new Random();
        int randNum = randNumber.Next(1, 22);

        foreach (string prompt in myPrompts)
        {
            Console.WriteLine(myPrompts[randNum]);
            // Show a match and exit the foreach loop immediately
            break;
        }

        return myPrompts[randNum];
    }

}
