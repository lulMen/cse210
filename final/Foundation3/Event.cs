public abstract class Event
{
    // private int _type;
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        // _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void DisplayStandard()
    {
        string[] parts = _address.Split(",");
        Console.WriteLine($"Lecture Event: {_title}\tDate: {_date}\tTime: {_time}");
        Console.WriteLine($"Location:\n{parts[0]} {parts[1]}\n{parts[2]}, {parts[3]} {parts[4]}");
        Console.WriteLine($"Description:\n{_description}\n");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"Lecture Event: {_title}\tDate: {_date}\n");
    }
    public abstract void DisplayFull();
}