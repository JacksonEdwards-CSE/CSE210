
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Product
{
    private string _name;

    private string _productID;

    private double _productCost;

    private int _productQuantity;

    public Product(string name, string productID, double cost, int quantity)
    {
        _name = name;
        _productID = productID;
        _productCost = cost;
        _productQuantity = quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetProductCost()
    {
        return _productCost;
    }

    public int GetProductQuantity()
    {
        return _productQuantity;
    }

    public double GetTotalProductCost()
    {
        return _productCost * _productQuantity;
    }
}