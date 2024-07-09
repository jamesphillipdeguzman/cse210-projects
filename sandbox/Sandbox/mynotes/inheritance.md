# Articulate: Inheritance in CSharp
#### Name: James Phillip De Guzman
#### Date: July 9, 2024
#### Instructor: Brother Duane Richards


1) Explain the meaning of Inheritance
**Answer:** Inheritance is the third principle of programming with classes. This principle builds upon the concepts of abstraction and encapsulation. Inheritance is the the ability of a sub class (a.k.a a child class or derived class to inherit from a super class/parent class/base class). What a child class inherits from a parent class are its methods/behaviours.
2) Highlight a benefit of Inheritance
**Answer:** The number 1 benefit of Inheritance is the elimination of code redundancies. It is as if you've copy and pasted your code from the parent class to your child class, but you have not. Another benefit is your code becomes more organized as the child classes all pass the "is a" test.
3) Provide an application of Inheritance
**Answer:** Inheritance can be applied to some gaming application. For example, if we have a parent class called Enemy, two child classes with different behaviours can be 1) FlyingEnemy sub class and 2) WalkingEnemy sub class. Inheritance becomes useful when we limit it up to 3-4 sub classes so it becomes scalable and maintainable.
4) Use a code example of Inheritance from the program you wrote

```C#
// This is my Main program or program.cs file which has the parent class BasicEnemy, whose attributes and methods are inherited by both WalkingEnemy and FlyingEnemy classes.
namespace BasicEnemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Example Program: BasicEnemy");

            // Set enemy values and Get Enemy info
            WalkingEnemy e1 = new WalkingEnemy("soldier", "Walking Enemy1", 20, 30, 5);
            Console.WriteLine(e1.GetEnemyInfo());

            // Set new enemy values and then Get Enemy info again...
            e1.SetEnemyInfo("sergeant", "Walking Enemy1.1", 21, 31);
            Console.WriteLine(e1.GetEnemyInfo());

            FlyingEnemy f1 = new FlyingEnemy("fighter jet", "Flying Enemy1", 100, 100, 90);
            Console.WriteLine(f1.GetEnemyInfo());
            f1.Attack();

            Console.WriteLine($"The {f1.GetEnemyName()} has already attacked!");


        }
    }
}


```
```C#
// Here's the WalkingEnemy class which inherits the member variables and methods of the parent Enemy class. This class has getters and setters for the _walkSpeed variable.

using System;


namespace BasicEnemy
{
    public class WalkingEnemy : Enemy
    {
        private int _walkSpeed;

        public WalkingEnemy(string name, string description, int HP, int MP, int walkSpeed) : base(name, description, HP, MP)
        {
            _walkSpeed = walkSpeed;
        }

        public WalkingEnemy() { }

        public int GetWalkSpeed()
        {

            return _walkSpeed;
        }

        public void SetFlightSpeed(int walkSpeed)
        {
            _walkSpeed = walkSpeed;
        }


    }
}

```

```C#

// Here's the FlyingEnemy class which inherits the member variables and methods of the parent Enemy class. This class has getters and setters for the _flightSpeed variable.

using System;

namespace BasicEnemy
{
    public class FlyingEnemy : Enemy
    {
        private int _flightSpeed;

        public FlyingEnemy(string name, string description, int HP, int MP, int flightSpeed): base(name, description, HP, MP)
        {
            _flightSpeed = flightSpeed;
        }

        public FlyingEnemy() { }

        public int GetFlightSpeed()
        {

            return _flightSpeed;
        }

        public void SetFlightSpeed(int flightSpeed)
        {
            _flightSpeed = flightSpeed;
        }
    }
}

```
5) Thoroughly explain these concepts (this likely cannot be done in less than 100 words)

First, I've declared the parent class, Enemy class, and set all of its member variables (private, so it follows encapsulation principles as well) and its member methods or functions. The variables can be initiliazed to some default or preset values if I wished. Second, I have created two derived classes called WalkEnemy class and FlyingEnemy class. Both of these classes inherited the member variables and methods of the Enemy class by using the colon ":" after the class names and putting the name of the parent class after that. I also used the 'base' keyword to be able to utilize the variables from the parent class. After this setup, I am now able to control the variables and methods I wish to access after declaring my constructors from the two other classes. Finally, all that is left is to create instances or copies of the Parent class through the Child classes and create my program.
