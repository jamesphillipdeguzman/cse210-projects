using System;
using System.Net;


namespace Develop04;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;


    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n.::Welcome to the  {_name}::.");
        Console.WriteLine($"\n- {_description}");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        if (_duration < 20)
        {
            // If no. of seconds is less than 20, ask user to enter a longer number of seconds.
            Console.WriteLine("The minimum is 20 seconds.");
            DisplayStartingMessage();

        }

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!! ");
        ShowSpinner();
        Console.WriteLine($"You spent {_duration} seconds for this {_name}.");
        ShowSpinner();
    }

    public void PlayMusic()
    {

        int C = 262; // C
        int Cs = 277; // C#/Db
        int D = 294; // D
        int Ds = 311; // D#/Eb
        int E = 330; // E
        int F = 349; // F
        int Fs = 370; // F#/Gb
        int G = 392; // G
        int Gs = 415; // G#/Ab
        int A = 440; // A
        int As = 466; // A#/Bb
        int B = 494; // B
        int C2 = 523; // C2

        int eightNote = 250;
        int quarterNote = 500;
        int halfNote = 1000;
        int wholeNote = 2000;

        Console.Beep(C, quarterNote);
        Console.Beep(C, quarterNote);
        Console.Beep(G, quarterNote);
        Console.Beep(G, quarterNote);
        Console.Beep(A, quarterNote);
        Console.Beep(A, quarterNote);
        Console.Beep(G, halfNote);

    }

    public void ShowGetReady(int seconds)
    {
        List<string> spinner = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                spinner.Add(".");
                spinner.Add("..");
            }
            else
            {
                spinner.Add("...");
                spinner.Add("..");
                spinner.Add(".");
            }
        }

        foreach (string c in spinner)
        {
            Console.Write("Get ready");
            Console.Write(c);
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Clear();

        }

    }

    public void ShowSpinner()
    {
        List<string> spinner = new List<string>();
        for (int i = 0; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                spinner.Add("|");
                spinner.Add("/");
                spinner.Add("-");
                spinner.Add("\\");
            }
            else
            {
                spinner.Add("/");
                spinner.Add("-");
                spinner.Add("\\");
            }
        }

        foreach (string c in spinner)
        {
            Console.Write(c);
            Thread.Sleep(150);
            Console.Write("\b \b");
        }

    }

    public void ShowCountdown(int seconds)
    {
        string spin = "";
        List<string> spinner = new List<string>();

        int i = 1;
        int ctr = _duration;
        do
        {
            spin += ".";
            ctr -= 1;
            if (i >= 1 && i <= 4)
            {
                Console.Write(spin);
                Console.Write("inhale " + i);
                Console.Beep(262, 500);
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Clear();
            }
            else if (i >= 5 && i <= 12)
            {
                Console.Write(spin);
                Console.Write("hold " + i);
                Console.Beep(294, 500);
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Clear();
            }
            else if (i >= 13 && i <= 20)
            {
                Console.Write(spin);
                Console.Write("exhale " + i);
                Console.Beep(262, 500);
                Thread.Sleep(500);
                Console.Write("\b \b");
                Console.Clear();
            }
            else
            {
                i = 0;
            }

            spinner.Add(spin);
            i++;

        } while (i != _duration + 1 && ctr != 0);

    }
}

