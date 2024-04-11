public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFull()
    {
        string[] parts = _address.Split(",");
        Console.WriteLine($"Lecture Event: {_title}\tDate: {_date}\tTime: {_time}\nRSVP Email: {_email}");
        Console.WriteLine($"Location:\n{parts[0]} {parts[1]}\n{parts[2]}, {parts[3]} {parts[4]}");
        Console.WriteLine($"Description:\n{_description}\n");        
    }
}