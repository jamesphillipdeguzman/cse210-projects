# Articulate: Programming with Classes in CSharp

#### Name: James Phillip De Guzman

#### Date: July 21, 2024

#### Instructor: Brother Duane Richards

• Explain the meaning of each principle.
1. Abstraction
   **Answer:** Abstraction is making complex things simple. For example, the print function in Python is a simple command to print the characters in the terminal window, but most people don't know that it is actually made of 3000 plus lines of code to make it work "behind-the-scenes", so to speak.
2. Encapsulation 
   **Answer:** Encapsulation is the second principle of programming with classes. It's not only important that we make the complex simple by abstraction (or letting the class handle information about itself), but it is equally important to be able to hide the variables from other classes (in other words make the member variables, private or read-only)
3. Inheritance 
   **Answer:** Inheritance is the third principle of programming with classes. This principle builds upon the concepts of abstraction and encapsulation. Inheritance is the ability of a sub-class.
  (a.k.a. a child class or derived class to inherit from a superclass/parent class/base class). What a child class inherits from a parent class are its methods/behaviors.

4. Polymorphism
  **Answer:** Polymorphism is the fourth and final principle of programming with classes. This principle builds upon the concepts of abstraction, encapsulation, and most importantly, 
  inheritance. You will not be able to apply this principle without a good knowledge of the latter principle. Polymorphism came from two words: 'poly' which means 'many', and 'morph', which means 'forms'. 
  This means the child classes can change each of their behavior or implementation by overriding the parent's class generic methods or behaviors.

----------------------------
• Highlight how each principle was used in your final project.
  1. Foundation 1 - YouTube Videos (Abstraction principle)
  Highlights: Video class and Comment class
  ```C#
  public class Video
  {
  ...
  // define all member variables and methods here...
  }
  
  public class Comment
  {
  ...
  // define all member variables and methods here...
  }
  
  ```
  
  2. Foundation 2 - Online Ordering (Encapsulation principle)
  Highlights: All privately declared member variables within each class (e.g., Customer, Product, Address and Order classes)
  -For brevity, I have only posted a code snippet of my Customer class here.
  ```C#
  public class Customer
  {
      private string _name;
  
      private Address _address = new Address();
  
      private string _recipient;
      private Address _address2 = new Address();
      //... other codes like methods go here...
  }
  ```

  3. Foundation 3 - Event Planning (Inheritance principle)
  Hightlights: The Event class is the parent class while the LectureEvent class inherits all protected variables from the Event class and also its methods (e.g., StandardDetails).
  ```C#

  public class Event
  {
      protected string _title;
      protected string _description;
      protected string _date;
      protected string _time;
      protected string _address;
  
      public Event() { }
  
      public Event(string title, string description, string date, string time, string address)
      {
  
      }

       public virtual string StandardDetails(string title, string description, string date, string time, string address)
       {
    
            return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}";
    
       }

       // ... other methods down here...
  
  }

  public class LectureEvent : Event
  {
      private string _speaker;
      private int _capacity;
  
      // Lectures, which have a speaker and have a limited capacity.
  
      public LectureEvent() {}
      public LectureEvent(string title, string description, string date, string time, string address, string speaker, int capacity): base(title, description, date, time, address)
      {
          _title = title;
          _description = description;
          _date = date;
          _time = time;
          _address = address;
          _speaker = speaker;
          _capacity = capacity;
  
  
      }

  }

  ```

  4. Foundation 4 - Exercise Tracking (Polymorphism principle)
  Hightlights: The Activity class is the parent class with the GetSummary method which is overridden in the RunningActivity class.
               The GetSummary() becomes eligible for overriding when we place the **virtual** keyword in it. 
  ```C#
  // Code snippets for all methods came from the Activity class, which is the parent class.

    public virtual string GetSummary()
    {
        return "Please override this";
    }

    public virtual double GetDistance(double speed, int minutes)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

    public virtual double GetSpeed(double _pace)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

   public virtual double GetSpeed(double distance, int minutes)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }

    public virtual double GetPace(int minutes, double distance)
    {
        // Console.WriteLine("Please override this");
        return 0;
    }
  ```
``` C#

// Code snippets showing how the RunningActivity class cannot only inherit the Activity classes member variables and functions, but also override the methods by using the **override* keyword before the method's name.
public class RunningActivity : Activity
{
    private double _distance;
    private double _speed;
    private double _pace;

    public RunningActivity(string name, string date, int length, double distance) : base(name, date, length)
    {
        _name = name;
        _date = date;
        _length = length;
        _distance = distance;

    }

    public override string GetSummary()
    {
        return $"{_date} {_name} ({_length} min)-Distance {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
    }

    public override double GetSpeed(double distance, int minutes)
    {
        _speed = (distance / minutes) * 60;
        return _speed;
    }

    public override double GetPace(int minutes, double distance)
    {
        _pace = minutes / distance;
        return _pace;
    }
}
```
----------------------------
• Explain how these principles make your final project more flexible for changes.
1. Abstraction can adapt to changes in code by letting the classes deal with the changes. For example, the owner of the company asked if the number of views can be tracked for each video. This can be achieved easily through abstraction by letting the Video class handle that change. You will need to add another variable in Video class called _views which will store these numbers. Then, you might need to track them using a GetViews() method.

2. Encapsulation can help my programs become flexible for changes by hiding information about my variables using the access modifier 'private'. Making the variables private can hide them from access by other variables in 
the program. This means my program will not easily break because other variables or methods in my program can only access these privately declared variables using the class methods which hold them.
The getters and setters will be able to communicate the changes locally in each class and be able to make the changes by using the same variable naming convention (for example string _name for string name variable).
These methods act like the "middleman" for these private member variables. In addition, if you need to change the name of a variable, you may just need to change the variables within one class where the variables are located.
For example, _name could be renamed as _fullName instead. You only need to do it in one location and change a few lines of code.

3. Inheritance helps my program be flexible by declaring all variables that stays the same inside the parent class and then putting all extra variables that change in the child classes. 
By doing this, the program only needed to change in the parent class to reflect the additional attributes the derived/child classes may need. For example, if my derived classes also need to track date and time joined together,
(e.g., _dateAndTime) then you can delete the _date and _time variable and just declare them as private string _dateAndTime.

4. Polymorphism is able to make changes to the code easier by using method overriding principles in its derived or child classes. It is an important and powerful principle in Programming with classes because, if there will be any dynamic changes required for the program, these changes can be easily implemented through the child classes. For example, if ever the company owner wants to create another exercise activity such as Calisthenics activity, then the programmer can just easily add this new activity and have its own different methods or implementations. Instead of tracking the distance, perhaps, a reps or repetition variable can be declared in it. Truth is, Calisthenics can be declared as another generic or abstract idea for an activity. It can have sub-classes that can be declared such as PushupActivity, CurlupActivity, LiftingActivity, etc. This becomes easily managed through the use of both Inheritance and Polymorphism principles which I've learned in Programming with Classes in C# in the CSE210 course.


----------------------------
• Thoroughly explain these concepts (this likely cannot be done in less than 100 words)
1. Abstraction Concept: 
The Video class and Comment class are called objects or Classes. Video and Comment class is an abstraction because they are abstract ideas from the real world. They may have more properties or characteristics that can be 
defined if I wish, but they have been simplified in my program by only defining what their primary responsibilities and behaviors are going to be concerning the goal of my program. 
In my program, the Video class tracks the title, author, and length of the video. Whereas, my Comment class only tracks the name of the person who made the comment and the text of the comment the number of comments. 
Additionally, both classes have their own getters and setters (or methods/behaviors). The main behavior I have for Video class grabs the number of Comments being passed to it. Also, abstraction is shown when you let the classes
handle the responsibility of tracking the video and comment details on their own. Because of this, my main class or Program.cs can create an instance of these Video and/or Comment classes. 
As a result, their implementation in the main class looks simple enough on the outside (but actually is complex from the inside).
In summary, in C#, abstraction is simplification of complex things or ideas. Only the essential characteristics are used in my program regarding Video and Comment, and both are used in a very specific way to accomplish the goal of my program.

2. Encapsulation Concept:
The Customer class is able to hide its member variables such as _name, _address, _recipient by using the access modifier 'private'. If it were a public access modifier, then, this will defy the principles of encapsulation 
because all variables become available inside the program. However, hiding them using **private** keyword helps make troubleshooting easier for any bugs because you may only need to look at one class which contains these variables 
and not look elsewhere. Encapsulation is also called "information/implementation hiding". The concept is to hide the implementation of each class from the main class. For example, the implementation for tracking Orders is handled by the Order class. On the one hand, the Order class has a method called GetTotalCost(). On the other, the Product class also has the same method name. It is interesting to note that you can use different parameter names
for each method and yet be able to refer to the same thing (e.g., double price in the Product class, then double unitPrice in Order class). This is another way of hiding the information. 

Example snippets:
```C#
// From Main class snippet...
     product1.SetProductInfo("wrangler jeans", "12345", 1, order1.GetTotalCost(49.99, 1));
     // this instantiates a product object called 'product1' from the Product class and also calls a function called GetTotalCost() from the Order class.
    // ...

// From Product class snippet...
    public double GetTotalCost(double price, int quantity)
      {
          _price = price;
          _quantity = quantity;
          return _price * _quantity;
      }
  // ...

// From Order class snippet...
    // Calculates the total cost of the order.
    public double GetTotalCost(double unitPrice, int qty)
    {
        Product product = new Product();
        double totalCost = product.GetTotalCost(unitPrice, qty);
        _totalOrderCost = totalCost;
        return _totalOrderCost;
    }
  // ...

 
```


3. Inheritance Concept: 
In my Event planning C# program, inheritance plays a vital role because it makes code reuse easy by being able to put all member variables that are common to all derived classes within my base class called **Event**.
Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address, and all of these are declared inside the Event class. Then, I could just declare extra variables inside each of the derived classes. For example, in my code snippet above, Event base class tracks for a total of 5 variables namely title, description, date, time and address. I declared extra variables like _capacity and _speaker in the LectureEvent class and need not redeclare the other 5 variables because they have been all inherited by the LectureEvent class from Event class. Aside from inheriting all Event member variables by the 3 derived classes (e.g., LectureEvent, ReceptionEvent and OutdoorEvent), they have also inherited the functions or methods like StandardDetails(), FullDetails() and ShortDescription().


5. Polymorphism Concept:
This is the final concept that I've learned in this course. Polymorphism makes the program even more flexible and powerful by being able to declare different implementations of my program through method overriding principles in the parent's sub classes. For example, in my Foundation 4 program for Exercise Tracking, the GetSummary() method from the base class is overridden in the RunningActivity class (see snippet below).
```C#

  // From Activity class (the Parent class)

  public virtual string GetSummary()
  {
      return "Please override this";
  }

  // ...

// From RunningActivity class (the Child class)

  public override string GetSummary()
  {
      return $"{_date} {_name} ({_length} min)-Distance {_distance} km, Speed: {_speed} kph, Pace: {_pace} min per km";
  }


```

Overriding is achieved by using the **override** keyword in the derived class that matches the **virtual** keyword from the base class. Because of this ability in polymorphism, the programmer can make changes dynamically in the child class without even touching the code from the base class. In a way, this also implements the principles of Encapsulation because we can hide the GetSummary method from the base class and not think about it, since we are overriding it anyway in our derived class in the RunningActivity. 








