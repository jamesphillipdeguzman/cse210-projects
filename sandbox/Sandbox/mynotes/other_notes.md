# Changing global variable for CRLF to LF

```
git config --global core.autocrlf true
```

**Note:**
This will convert LF to CRLF when you check out code and convert CRLF to LF when you commit code.

# Creating a Class in C#

```C#

using System;

// Keep track of new custom data type (Blind) for height, width, color and Area for blinds
public class Blind
{
    public double _height;
    public double _width;
    public string _color;

    public double GetArea()
    {
        return _height * _width;
    }
}

// Keep track of new household names for blinds ordered
public class House
{
    public string _owner = "";
    public Blind _kitchen = new Blind();
    public Blind _livingRoom = new Blind();

    public Blind _kitchenColors = new Blind();

}

class Program
{
    public static void Main(string[] args)
    {
        House deGuzmanHome = new House();
        deGuzmanHome._owner = "De Guzman Family";
        Blind kitchen = new Blind();
        kitchen._width = 80.45;
        kitchen._height = 100.5;
        kitchen._color = "white";
        kitchen.GetArea();
        Console.WriteLine($"The width is {kitchen._width}");
        Console.WriteLine($"The height is {kitchen._height}");
        Console.WriteLine($"The color is {kitchen._color}");
        Console.WriteLine($"The area is {kitchen.GetArea()}");
        Console.WriteLine($"The owner of De Guzman Home is {deGuzmanHome._owner}");

        deGuzmanHome._kitchen._width = 60;
        // deGuzmanHome._kitchen._height = 100;
        double newWidth = deGuzmanHome._kitchen._width;
        double newHeight = deGuzmanHome._kitchen._height = 100;
        string newColor = deGuzmanHome._kitchenColors._color = "beige";
        string owner1 = deGuzmanHome._owner;
        Console.WriteLine($"For {owner1}: Width is {newWidth}. Height is {newHeight}. Color is {newColor}");
    }
}












```
