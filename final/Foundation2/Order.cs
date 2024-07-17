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

    public Order() {}
    // Calculates the total cost of the order.
    public double GetTotalCost()
    {
        return 0;
    }
    // Returns a string for the packing label.
    public string PackingLabel()
    {
        return "";
    }
    // Returns a string for the shipping label.
    public string ShippingLabel()
    {
        return "";
    }
}
