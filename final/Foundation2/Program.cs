using System;
using Foundation2;
/* Author: James Phillip K. De Guzman
 * Programming Language: C Sharp or C#
 * Instructor: Brother Duane Richards
 * Date Started: June 15, 2024
 * Date Finished: June 19, 2024
 /
/* Rubrics for Foundation 2: Encapsulation with Online Ordering
 * 1. Abstraction Classes
 *   - All classes in the specification are created and contain the required attributes.
 *   Class composition is used correctly for each of the class relationships (classes contain instances of other classes).
 *
 * 2. Encapsulation: Information Hiding
 *   - All classes in the specification are created and contain the required attributes. Class composition is used
 *   correctly for each of the class relationships (classes contain instances of other classes).
 *
 * 3. Functionality: Object Creation
 *   - Program runs without errors. At least 2 Order objects are created. Each Order object contains at least 2 Product
 *   objects. Each Order object contains a Customer object. Each Customer object contains an Address object.
 *   Values are set for each member variable of these objects.
 *
 * 4. Functionality: Behaviors
 *   - Program runs without errors. For each order, the program calculates and displays the total cost.
 *   The program also calls methods to get packing and shipping labels and displays the results of these labels
 *   containing all required information.
 *
 * 5. Style: Whitespace
 *   - Vertical and horizontal whitespace (blank lines, indentation, braces) is correct throughout the program.
 *
 * 5. Style: Naming Conventions
 *   - Classes and methods use TitleCase, member variables use _underscoreCamelCase, local variables use camelCase.
 */

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Foundation 2: Encapsulation with Online Ordering");

        // Create a first order

        Order order1 = new Order();
        Product product1 = new Product();
        Product product2 = new Product();

        Console.WriteLine("=============================================");
        // Pass in the product information (e.g., name, product ID, qty, and total cost)
        product1.SetProductInfo("wrangler jeans", "12345", 1, order1.GetTotalCost(49.99, 1));
        product2.SetProductInfo("SM adidas shoe", "54321", 2, order1.GetTotalCost(110, 1));

        // Add the product info to a list called product1
        List<Product> products = new List<Product>();
        products.Add(product1);
        products.Add(product2);

        // Output the product info to the console
        Console.WriteLine("-Item-------Desc---------PID---Qty---Unit----+");


        Console.WriteLine("    1. " + product1.GetProductInfo());
        Console.WriteLine("    2. " + product2.GetProductInfo() + "\n");

        // Set the customer's address
        Address address1 = new Address();
        string customerName1 = "James De Guzman";
        address1.SetAddress("Imperial Homes III Subd.", "Mandurriao", "Iloilo", "5000", "PH");

        Address address2 = new Address();
        string recipientName1 = "Marie De Guzman";
        address2.SetAddress("123 Disneyland Dr", "Anaheim", "California", "92802", "USA");

        // Create the customer object (e.g., name and address passed in as a class)
        Customer customer1 = new Customer(customerName1, address1, recipientName1, address2);

        // Create a new list of customers
        List<Customer> customers = new List<Customer>();
        customers.Add(customer1);


        // Create the order and return packing label and shipping label information here

        Console.WriteLine("\nPacking slip details: \nOrder No.\n" + order1.PackingLabel(product1) + order1.PackingLabel(product2) + "\n");
        Console.WriteLine("---------------------------------------------\n");
        Console.WriteLine("LBC (Shipping Details)\n");
        Console.WriteLine(order1.ShippingLabel(customer1, address1, customer1, address2));
        Console.WriteLine("\nMethod: LBC Worldwide Express Padala");
        Console.WriteLine("=============================================\n");


        // Create second order

        Order order2 = new Order();
        Product product3 = new Product();
        Product product4 = new Product();

        Console.WriteLine("=============================================");
        // Pass in the product information (e.g., name, product ID, qty, and total cost)
        product3.SetProductInfo("SAUVAGE EAU DE PARFUM", "45461", 1, order2.GetTotalCost(145, 1));
        product4.SetProductInfo("Frontgate Bath Towels", "01234", 2, order2.GetTotalCost(45.50, 1));

        // Add the product info to a list called product1
        List<Product> products2 = new List<Product>();
        products2.Add(product3);
        products2.Add(product4);

        // Output the product info to the console
        Console.WriteLine("-Item-------Desc---------PID---Qty---Unit----+");


        Console.WriteLine("    1. " + product3.GetProductInfo());
        Console.WriteLine("    2. " + product4.GetProductInfo() + "\n");

        // Set the customer's address
        Address address3 = new Address();
        string customerName2 = "Angela C. De Guzman";
        address3.SetAddress("Imperial Homes III Subd.", "Mandurriao", "Iloilo", "5000", "PH");

        Address address4 = new Address();
        string recipientName2 = "Jacob Irving";
        address4.SetAddress("123 Disneyland Dr", "Anaheim", "California", "92802", "USA");

        // Create the customer object (e.g., name and address passed in as a class)
        Customer customer2 = new Customer(customerName2, address3, recipientName2, address4);

        // Create a new list of customers
        List<Customer> customers2 = new List<Customer>();
        customers2.Add(customer2);


        // Create the order and return packing label and shipping label information here

        Console.WriteLine("\nPacking slip details: \nOrder No.\n" + order2.PackingLabel(product3) + order2.PackingLabel(product4) + "\n");
        Console.WriteLine("---------------------------------------------\n");
        Console.WriteLine("LBC (Shipping Details)\n");
        Console.WriteLine(order2.ShippingLabel(customer2, address3, customer2, address4));
        Console.WriteLine("\nMethod: LBC Worldwide Express Padala");
        Console.WriteLine("=============================================\n");

    }
}
