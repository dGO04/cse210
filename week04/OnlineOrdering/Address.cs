public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address()
    {
        
    }

    public Address (string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetFullAdress()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
    }

    public bool InsideUSA()
    {
        if (_country.Contains("USA"))
        {
            return true;
        } else 
            
            return false;
    
    }

}