public class Address
{
    private string _number;
    private string _street;
    private string _city;
    private string _state;
    private string _zipcode;
    private string _country;

    public Address(string number, string street, string city, string state, string zipcode,string country)
    {
        _number = number;
        _street = street;
        _city = city;
        _state = state;
        _zipcode = zipcode;
        _country = country;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            return true;
        } else {
            return false;
        }
    }

    public string GetAddressDetails()
    {
        return $"  {_number} {_street}\n  {_city}, {_state} {_zipcode}\n  {_country}\n"; 
    }
}