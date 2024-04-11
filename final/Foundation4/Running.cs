public class Running : Activity
{
    private float _distance;
    
    public Running(string name, string date, int length, float distance) : base(name, date, length)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / _length * 60;
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculatePace()
    {
        return _length / _distance;
    }
}