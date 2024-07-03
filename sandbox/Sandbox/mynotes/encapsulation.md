# Articulate: Encapsulation in CSharp
#### Name: James Phillip De Guzman
#### Date: July 3, 2024
#### Instructor: Brother Duane Richards


1) Explain the meaning of Encapsulation
**Answer:** Encapsulation is the second principle of programming with classes. It's not only important that we make the complex, simple by abstraction (or letting the class handle information about itself), but it is equally important to be able its variables from other classes (in other words make the member variables, private or read-only)
2) Highlight a benefit of Encapsulation
**Answer:** Encapsulation or "information/implementation details hiding is important because of 2 things 1) It something is broken, we can troubleshoot only one spot, that is, the class where the encapsulated variables and methods are. The methods or functions within this class which has access to these private member variables can also be easily changed since they are just in one spot.
3) Provide an application of Encapsulation
**Answer:** Encapsulation is applied when we declare member variables as "private". For example, the BankAcount class, we might have the _firstName, _lastName, _accountName, _accountNumber and _balance as private member variables. Then, we can have methods like SetBalance() and GetBalance() that can return integers values after being passed in some initialBalance of 500 from the main program. Encapsulation protects the private variables from access by other classes as it acts like a "middle man". All operations has to be performed using the constructors to pass in the values and manipulate the private member variables from within the class.
4) Use a code example of Encapsulation from the program you wrote

```C#
// This is my Main program or program.cs file which calls the class BankAccount constructors and class methods like GetBalance() and SetBalance().
namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Encapsulation Principles\n");
            Console.Write("First Name : ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name  : ");
            string lastName = Console.ReadLine();
            Console.Write("Account No : ");
            int accountNum = Convert.ToInt32(Console.ReadLine());

            BankAccount ba1 = new BankAccount(firstName, lastName, accountNum);
            Console.WriteLine(ba1);

            Console.Write("What is your initial balance? ");
            int balance = Convert.ToInt32(Console.ReadLine());

            int initBal = ba1.SetBalance(balance);


            Console.Write("Your balance is " + ba1.GetBalance(initBal));


        }
    }
}

```
```C#
// Here's the BankAccount.cs files where all the private member variables are being encapsulated or hidden from the Main program or class.

using System;


namespace BankAccount
{
    public class BankAccount
    {
        private string? _firstName;
        private string? _lastName;
        private string? _accountName;
        private int _accountNumber;
        private int _balance;



        public BankAccount()
        {
            _firstName = null;
            _lastName = null;
            _accountName = null;
        }

        public BankAccount(string firstName, string lastName)
        {
            _firstName=firstName;
            _lastName=lastName;
            _accountName = firstName.ToUpper() + " " + lastName.ToUpper();

        }

        public BankAccount(string firstName, string lastName, int accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            _accountName = firstName.ToUpper() + " " + lastName.ToUpper();
            _accountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"{ _accountName} Account: {_accountNumber}";
        }

        public int GetBalance(int balance)
        {
            _balance = balance;

            return _balance;
        }

        public int SetBalance(int balance)
        {
            _balance = balance;
           return balance;
        }
    }
}

```
5) Thoroughly explain these concepts (this likely cannot be done in less than 100 words)

First, the user is asked to enter his/her details such as First Name, Last Name and Account Number. These are done using the prompts in Console.WriteLine(). The inputs are being read through the Console.ReadLine(). Once input has been entered, we passed in the firstName, lastName and accountNum to the 3rd version of our constructor that takes in 3 parameters firstName, lastName and accountNumber. These are tied to the private member variables _firstName, _lastName and _accountNumber. Therefore, the user need not have direct access to them but they are indirectly accessible through the overloading constructors we've setup.
The program works because the member methods or functions will just returned whatever value we've passed into them from the Mains class without knowing the implementation or actual variables used in the BankAccount class.
