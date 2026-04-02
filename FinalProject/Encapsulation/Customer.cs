
class Customer
{
    private string _name;
    private Address _address;
    private bool _shippingInfo;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _shippingInfo = _address.GetIsUSA();

    }

    public string GetCustomerName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return $"{_address.GetAddress()}";
    }

    public bool GetShippingInfo()
    {
        return _shippingInfo;
    }
}