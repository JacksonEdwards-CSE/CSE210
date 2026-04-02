
class Order
{
    private Customer _customer;
    private List<Product> _productList;
    private double _shippingCost;
    

    public Order(Customer customer)
    {
        _customer = customer;

        _productList = new List<Product>();

        _shippingCost = SetShippingCost();
    }

    private double SetShippingCost()
    {
        if (_customer.GetShippingInfo())
        {
            return 0.00;
        }

        return 35.00;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("-- Packing Label --");
        foreach (Product product in _productList)
        {
            Console.WriteLine($"{product.GetProductName()} - {product.GetProductID()} x {product.GetProductQuantity()} ");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("-- Shipping Label --");

        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine(_customer.GetAddress());
        
    }

    public void GetTotalCost()
    {
        Console.WriteLine("-- Total Cost --");

        double totalPrice = 0;

        foreach (Product product in _productList)
        {
            Console.WriteLine($"{product.GetProductName()} - {product.GetProductQuantity()} x {product.GetProductCost()}");
            totalPrice += product.GetTotalProductCost();
        }

        Console.WriteLine($"Shipping Cost: {_shippingCost:C2}");
        totalPrice += _shippingCost;

        Console.WriteLine($"Total Cost: {totalPrice:C2}");
    }
}