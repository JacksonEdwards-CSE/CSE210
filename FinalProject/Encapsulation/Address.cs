
class Address
{
    private string _addressString;

    private bool _isUSA;

    public Address(string address)
    {
        _addressString = address;
        _isUSA = SetIsUSA();
    }

    private bool SetIsUSA()
    {
        string[] addressArray = _addressString.Split(',');

        if (addressArray[3] == " USA")
        {
            return true;
        }

        return false;
    }

    public bool GetIsUSA()
    {
        return _isUSA;
    }

    public string GetAddress()
    {
        return _addressString;
    }
}