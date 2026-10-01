public class Customer
{
    private string _name;
    private Address _address = new Address();

    public Customer()
    {
        
    }
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool InsideUSA()
    {
        return _address.InsideUSA();
    }

    public string GetShippingLabel()
    {

        return $"{_name}\n{_address.GetFullAdress()}";
    }
}