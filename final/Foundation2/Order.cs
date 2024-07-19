using System.Reflection.Metadata.Ecma335;

namespace Foundation2;
// Contains a list of products and a customer.
// Can calculate the total cost of the order.
// Can return a string for the packing label.
// Can return a string for the shipping label.

public class Order
{
    private string _packingLabel;
    private string _shippingLabel;
    private double _totalOrderCost;

    // Contains a list of products and a customer.
    private List<Product> _products;
    private List<Customer> _customers;
    private int ctrOrder = 0;

    public Order() { }
    // Calculates the total cost of the order.
    public double GetTotalCost(double unitPrice, int qty)
    {
        Product product = new Product();
        double totalCost = product.GetTotalCost(unitPrice, qty);
        _totalOrderCost = totalCost;
        return _totalOrderCost;
    }
    // Returns a string for the packing label.
    public string PackingLabel(Product products)
    {
        List<Product> _products = new List<Product>();
        _products.Add(products);
        string myProducts = "";
        foreach (Product product in _products)
        {
            myProducts = product.GetProductInfo();
        }

        // Deserialize the details
        string[] parts = myProducts.Split("|");
        string prodDesc = parts[0].Trim();
        string prodID = parts[1].Trim();
        int prodQty = int.Parse(parts[2].Trim());
        string[] prodPriceTemp = parts[3].Split("$");

        double prodUnitPrice = double.Parse(prodPriceTemp[1]);

        ctrOrder += 1;
        _shippingLabel = $"\n{ctrOrder}. SKU: {prodID}\n    Description: {prodDesc}\n    Quantity   : {prodQty}\n    Unit       : ${prodUnitPrice}\n    Price      : ${GetTotalCost(prodUnitPrice, prodQty)}";

        return _shippingLabel;
    }
    // Returns a string for the shipping label.
    public string ShippingLabel(Customer customer, Address address, Customer recipient, Address address2)
    {
        // LBC

        // Sender: James De Guzman
        //          Imperial Homes III Subdivision,
        //          Mandurriao, Iloilo City 5000, PH
        // Recepient: Marie De Guzman
        //           123 Disneyland Dr,
        //           Anaheim, CA 92802
        //           USA



        // Tracking No: 1234
        // Shipping Method: LBC Worldwide Express Padala
        List<Customer> _customers = new List<Customer>();
        _customers.Add(customer);
        string customerName = "";
        string customerAddress = "";

        List<Customer> _recipients = new List<Customer>();
        _recipients.Add(recipient);
        string recipientName = "";
        string recipientAddress = "";

        foreach (Customer customer1 in _customers)
        {
            customerName = customer1.GetCustomerName();
            customerAddress = customer1.GetCustomerAddress();
        }

        foreach (Customer recipient1 in _recipients)
        {
            recipientName = recipient1.GetRecipientName();
            recipientAddress = recipient1.GetRecipientAddress();
        }


        // Deserialize customer address
        string[] parts = customerAddress.Split("\n");
        string[] parts2 = parts[1].Split(",");

        string theAddress = parts[0].Trim();
        string theCity = parts2[0].Trim();
        string theProvince = parts2[1].Trim();
        string thePostCode = parts2[2].Trim();
        string theCountry = parts2[3].Trim();
        // Check if person is from USA
        string result = customer.IsInUSA(theCountry) ? "Yes" : "No";


        // Deserialize recipient address
        string[] parts1 = recipientAddress.Split("\n");
        string[] parts3 = parts1[1].Split(",");

        string theAddress2 = parts1[0].Trim();
        string theCity2 = parts3[0].Trim();
        string theState = parts3[1].Trim();
        string thePostCode2 = parts3[2].Trim();
        string theCountry2 = parts3[3].Trim();
        // Check if person is from USA
        string result2 = recipient.IsInUSA(theCountry2) ? "Yes" : "No";

        return $"Sender: {customerName}\n        {theAddress},\n        {theCity}, {theProvince}, {thePostCode}, {theCountry}\n        Located in US: {result}\n\nRecipient: {recipientName}\n        {theAddress2},\n        {theCity2}, {theState}, {thePostCode2}, {theCountry2}\n        Located in US: {result2}";
    }
}
