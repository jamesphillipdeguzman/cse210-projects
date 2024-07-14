# Articulate: Polymorphism in CSharp
#### Name: James Phillip De Guzman
#### Date: July 14, 2024
#### Instructor: Brother Duane Richards


1) Explain the meaning of Polymorphism
**Answer:** Polymorphism is the fourth and final principle of programming with classes. This principle builds upon the concepts of abstraction, encapsulation, and most importantly, inheritance. You will not be able to apply this principle without a good knowlege of the latter principle. Polymorphism came from two words: 'poly' which means 'many', and 'morph', which means 'forms'. This means the child classes can change each of their behavior or implementation by overriding the parent's class generic methods or behaviors.

**Answer:** Polymorphism benefits us as programmers by making our code more versatile or mutable. One benefit of polymorphism is the ability of instantiating different constructors (a.k.a. method overriding) to meet your program's needs.
**Answer:** Polymorphism can be applied to many some abstract idea or program applications. For example, if we have a parent class called Animal (a generic idea, what kind of Animal, eh? Is it dog, a mouse a cat?...etc.), then we could have two example child classes with two different set of behaviours: 1) Dog Class and  2) a Cat Class derived classes. Both of these classes can have a different implementation of the void MakeSound() method from the Animal class. The Dog Class makes the sound 'Arf' while the Cat Class makes the sound of 'Meow'. We must remember that the methods from the base/parent class are eligible to be overriden using the 'virtual' or 'abstract' keywords (applies to certain methods you want to override from the base class and partner it with an 'override' keyword in the child classs) The difference between and abstract parent class and virtual methods is that once you have abstract methods in your base class, then, you are 'forced' to use them on your child classes, unlike virtual which is only picking some methods you like to override from the parent class.
4) Use a code example of Polymorphism from the program you wrote:

5) See code below of how the Animal class (parent class) becomes a generic code template that can be overriden by the child classes, Dog and Cat class. The abstract method of ```public abstract void MakeSound``` can be reused and "more" by the derived classes. Child classes are also able to utilize the private/protected member variables of the parent class by using the ```base``` keyword. Polymorphism is indeed, one of the most powerful OOP (Object Oriented Programming) tool that you can utilize in order to encapsulate or hide implementation of your code and make it more robust, clean and hard to break.

```C#
using System;


namespace Animal
{
    // Parent or base class: Animal
    public abstract class Animal
    {
        private string _name;
        private string _owner;
        private int _age;

        public Animal(string name, string owner, int age)
        {
            _name = name;
            _owner = owner;
            _age = age;

        }

        public abstract void MakeSound();



    }
}





```
```C#
using System;

namespace Animal
{
    public class Dog : Animal
    {
        private string _size;
        private string _hairColor;
        private string _sound;

        // Dog Class inherits from Animal class
        public Dog(string name, string owner, int age, string size, string hairColor, string sound) : base(name, owner, age)
        {
            _size = size;
            _hairColor = hairColor;
            _sound = sound;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Aarf!");
        }
    }
}

```
``` C#

using System;

namespace Animal
{
    // Cat Class inherits from Animal class
    public class Cat : Animal
    {
        private string _size;
        private string _hairColor;
        private string _sound;

        public Cat(string name, string owner, int age, string size, string hairColor, string sound) : base(name, owner, age)
        {
            _size = size;
            _hairColor = hairColor;
            _sound = sound;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }


    }
}



```
