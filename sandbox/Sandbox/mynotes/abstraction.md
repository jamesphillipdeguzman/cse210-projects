# Articulate: Abstraction in CSharp

#### Name: James Phillip De Guzman

#### Date: June 23, 2024

#### Instructor: Brother Duane Richards

1. Explain the meaning of Abstraction
   **Answer:** Abstraction is making complex things simple. For example, the print function in Python is a simple command to print the characters in the terminal window, but most people don't know that it is actually made of 3000 plus lines of code in order to make it work "behind-the-scenes", so to speak.
2. Highlight a benefit of Abstraction
   **Answer:** What's nice about Abstraction, is that we can actually think of real-world objects and don't worry everything about them. For example, an Animal object can have simple attributes, such as, name, breed, color etc..
   We do not need to find out everything about an Animal object, but it would suffice to say, that we know what their main responsibilities/purpose in our C# program.
3. Provide an application of Abstraction
   **Answer:** Abstraction is an important principle to learn when programming with Classes in C# because it will really help a programmer like me, to create a blueprint/code template that I will use in my program. Classes in C# utilize this principle a lot. Its application can be seen during Class instantiation (i.e. creating an instance of a class). This is when it becomes useful in code, because you can create many different things out of your code template or Class.

Thoroughly explain these concepts
**Answer:** For example a Person class can have its own member attributes/fields that I can declare (e.g., \_firstName, \_lastName, \_age). The Person class can also have its own member function/methods. These are things that a Person class can do. Examples are ShowWesternName() and ShowEasternName. Both of which shows or concatenates names on a different order. For example, first name basis first, and then, last name basis first, respectively. These attributes and methods become accessible, usually in other classes and/or your Mains program when you create a constructor for them (e.g., Syntax: <access modifier> such as public, then <return type>, such as void, string, int, float, and lastly, the <ClassName>)

```C#
// Product Class: I created another example illustrating how powerful abstraction can be. The object Product is created and it's member attributes.
using System;

namespace Develop02;

public class Product
{

    public string _productName;
    public string _productDesc;
    public float _productPrice;



// Entry: This is my constructor for my single Product entry.
public Product(string _productName, string _productDesc, float _productPrice)
{
    this._productName = _productName;
    this._productDesc = _productDesc;
    this._productPrice = _productPrice;

}
// ToString(): This override method is needed to convert the entries into String and avoid returning the default string representation (e.g., Develop03.Entry)
public override string ToString()
{

    return $"{_productName} - {_productDesc} - {_productPrice}";

}

}


```

```C#

//Program.cs
// This is just a rough example of how abstraction can be used from this program

using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("My Sample Product Class program showing abstraction \n" + currentDate);
        Product p1 = new Product("Orange", "Drink", 25);
        Product p2 = new Product("Apple", "Drink", 50);
        Product p3 = new Product("Pomelo", "Drink", 60);


        // p1._productName = "Orange";
        // p1._productDesc = "Drink";
        // p1._productPrice = 25;

        // p2._productName = "Apple";
        // p2._productDesc = "Drink";
        // p2._productPrice = 50;

        // p3._productName = "Pomelo";
        // p3._productDesc = "Drink";
        // p3._productPrice = 60;

        // Console.WriteLine($"{p1._productName} - {p1._productDesc} - {p1._productPrice}\n");
        // Console.WriteLine($"{p2._productName} - {p2._productDesc} - {p2._productPrice}\n");
        // Console.WriteLine($"{p3._productName} - {p3._productDesc} - {p3._productPrice}\n");
        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(p3);


    }
}



```
