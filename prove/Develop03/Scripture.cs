using System.Text.RegularExpressions;
namespace Develop03;

// Scripture Class: Purpose is to keep track of both the reference and the text of the scripture.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    private string _text;

    // Keeps track of both the reference and the text of the scripture.
    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;

        _words = words;
        _text = words[0].ToString();

    }

    public Scripture()
    {

    }

    public override string ToString()
    {
        return $"{_reference} {_words}";
    }

    // Hide random words
    // A couple of random words are passed in and replaced with "_" underscores to hid them from user view (depending on number of characters)
    public void HideRandomWords(string verse)
    {
        // Scripture scripture = new Scripture();
        string[] parts = _text.Split(" ");

        int ctr = 0;

        List<Word> words = new List<Word>();
        List<int> indexes = new List<int>();
        Console.Clear();
        for (int i = 0; i < parts.Length - 1; i++)
        {
            string newText = "";
            string underscores = "";
            Random randWordNum = new Random();
            int randWordNumber = randWordNum.Next(0, parts.Length - 1);
            foreach (int ind in indexes)
            {
                // Start checking for duplicate random numbers
                do
                {
                    // Generate a random number again
                    randWordNumber = randWordNum.Next(0, parts.Length - 1);

                } while (indexes.Contains(randWordNumber) && ctr != parts.Length - 2);

                // Clean up what characters remains in the scriptures and replace with "_" underscore.
                if (ctr == parts.Length - 2)
                {
                    for (int j = 0; j <= parts.Length - 2; j++)
                    {
                        underscores += "_";
                        // Find all characters in string pattern...
                        string pattern = "[abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ;:,.]";
                        Regex regex = new Regex(pattern);
                        MatchCollection text = regex.Matches(_text);
                        foreach (Match match in text)
                        {
                            _text = _text.Replace(match.Value, underscores);

                        }

                        IsCompletelyHidden();
                        // Console.Clear();
                        break;

                    }
                }

            }

            Word word = new Word(parts[randWordNumber], true);

            // Count no. of times hidden
            ctr += 1;

            words.Add(word);

            // Save the random word number indexes and check if the number was already called
            indexes.Add(randWordNumber);


            for (int k = 0; k <= parts[randWordNumber].Length - 1; k++)
            {
                underscores += "_";
            }


            if (ctr != parts.Length)
            {
                if (parts[randWordNumber].Length - 1 >= 1)
                {
                    _text = _text.Replace(parts[randWordNumber], underscores);
                }

                newText += _text;

                // Hide words as user presses the enter key...

                // string userInput = Console.ReadLine();

                // if (string.IsNullOrEmpty(userInput))
                // {
                    ConsoleKey key;
                    //Console.Write("> ");
                    var keyInfo = Console.ReadKey(intercept: false);
                    key = keyInfo.Key;

                //     {
                // Clear the screen before printing the verse and new text



                    if (key == ConsoleKey.Enter)
                    {

                        Console.Clear();
                        Console.Write("> ");
                        Console.WriteLine(verse + ": " + newText);
                }
                    else
                    {
                        break;
                    }




                //     }
                // }
                // else
                // {
                //     if(userInput.Trim().ToLower() == "quit")
                //     {
                //         Console.WriteLine("Bye!");
                //         break;
                //     }
                // }


            }

        }

    }


    // Get the rendered display of the text.
    // Text with some words shown normally, and some replaced by underscores.
    public void GetDisplayText(string verse, Word word)
    {
        word.Show();
        List<Word> words = new List<Word>();
        words.Add(word);

        _text = words[0].ToString();

        // Let user decide if he wants to hide the words or go back to menu
        ConsoleKey key;
        var keyInfo = Console.ReadKey(intercept: false);
        key = keyInfo.Key;



        // Hide words as user presses the enter key...

        // string userInput = Console.ReadLine();

        // if (string.IsNullOrEmpty(userInput))
        // {

            key = keyInfo.Key;
            if (key == ConsoleKey.Enter)
            {
                Console.Write("> ");

                HideRandomWords(verse);

            }
        // }
        // else
        // {
        //     if (userInput.Trim().ToLower() == "quit")
        //     {
        //         Console.WriteLine("Bye!");

        //     }
        // }



        //return verse + ": " + words[0];
    }
    // Default value of the scripture is to show everything at first.
    // Check if all text had been hidden
    public bool IsCompletelyHidden()
    {
        Console.Clear();
        Console.WriteLine("Quitting the program now...please type 'q' after q> to quit or press <enter> to continue...");
        return true;
    }

}
