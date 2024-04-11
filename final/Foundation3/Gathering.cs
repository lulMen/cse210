public class Gathering : Event
{
    private string _weather;

    public Gathering(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void DisplayFull()
    {
        string[] parts = _address.Split(",");
        Console.WriteLine($"Lecture Event: {_title}\tDate: {_date}\tTime: {_time}\nWeather: {_weather}");
        Console.WriteLine($"Location:\n{parts[0]} {parts[1]}\n{parts[2]}, {parts[3]} {parts[4]}");
        Console.WriteLine($"Description:\n{_description}\n");        
    }
}