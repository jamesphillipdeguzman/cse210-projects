# Loops in C#

### Examples codes:

**Do While loop**

```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        string resp;
        do {
            Console.Write("Do you want to continue? ");
            resp = Console.ReadLine();
        } while (resp == "yes");
    }
}
```

**While loop**

```C#
using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //While loop

        string resp = "yes";
        while (resp == "yes")
        {
            Console.WriteLine("Do you want to continue? ");
            resp = Console.ReadLine();
        }
        Console.WriteLine ("Program terminated");

    }
}


```

**For loop**

```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // Print numbers from 0-9
        for (int i=0; i<10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

```

**Foreach loop**

```C#
using System;
class Program
{
    static void Main(string[] args)
    {
        // List of fruits
        //List<string> fruits = new List<string> { "avocado", "mango", "guava", "apple"};
        List<string> fruits = new() { "avocado", "mango", "guava", "apple" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}


```

Here are the troubleshooting steps I did and solutions to run my C# program in the terminal window:

**Initial Issue:** C# program was not displaying input/output in the Terminal window during debugging, defaulting instead to the Debug Console tab.

**Investigation:** Reviewed and configured tasks.json and launch.json files, essential for setting up tasks and launch configurations in Visual Studio Code.

**Root Cause Identification:** Discrepancy found between the args property in tasks.json and the cwd (current working directory) property in launch.json.

**Resolution:** Adjusted args property in tasks.json to correctly reference ${workspaceFolder} or root workspace. Aligned cwd property in launch.json with ${workspaceFolder} for consistent directory handling during debugging.

**Outcome:** Successfully enabled running C# programs in the Terminal window, facilitating proper input and output interactions during debugging sessions.

**Additional Insights:** Renaming the "name" property in launch.json (e.g., to 'C#: Prep 2' instead of '.NET Core Launch (console)') helped in organizing and distinguishing between different configurations, especially with multiple project folders (Prep 1, Prep 2, etc.).

**Conclusion:** Documented process and solutions provide valuable insights for others encountering similar challenges with Visual Studio Code and C# debugging configurations.
