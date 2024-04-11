public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override void DisplayFull()
    {
        string[] parts = _address.Split(",");
        Console.WriteLine($"Lecture Event: {_title}\tDate: {_date}\tTime: {_time}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
        Console.WriteLine($"Location:\n{parts[0]} {parts[1]}\n{parts[2]}, {parts[3]} {parts[4]}");
        Console.WriteLine($"Description:\n{_description}\n");
    }

}