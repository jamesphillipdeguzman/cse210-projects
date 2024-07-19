namespace Foundation2;
//  Contains the name, product id, price, and quantity of each product.

public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // - The total cost of this product is computed by multiplying the price per unit and the quantity.
    // (If the price per unit was $3 and they bought 5 of them, the product total cost would be $15.)
    public double GetTotalCost(double price, int quantity)
    {
        _price = price;
        _quantity = quantity;
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} | {_productID} | {_quantity} | ${_price}";
    }

    public void SetProductInfo(string name, string productID, int quantity, double price)
    {
        _name = name;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }
}
