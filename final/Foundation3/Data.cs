public class Data
{
    // private List<int> _eventType = new(){0, 1, 2};
    private static List<string> _eventTitles = new(){"Overcoming Your 'Limits'", "Welcome Back!", "Fall Activities and Events"};
    private List<string> _eventDescriptions = new()
    {
        $"This is some place holder text for the {_eventTitles[0]} event. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
        $"This is some place holder text for the {_eventTitles[1]} event. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
        $"This is some place holder text for the {_eventTitles[2]} event. Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
    };
    private List<string> _eventDates = new(){"March 23", "July 14", "November 2"};
    private List<string> _eventTimes = new(){"9:00", "14:00", "19:00"};
    private List<string> _eventAddresses = new()
    {
        "997,Union Road,Roy,UT,84067",
        "477,South Rockland Street,Marion,NC,28752",
        "324,Cardinal Ave.,Brandon,FL,33510"
    };
    private int _lectureCapacity = 200;
    private string _lectureSpeaker = "Johnathan Poole";
    private string _receptionEmail = "j_poole14_@domain.com";
    private string _gatheringWeather = "Clear";

    public Data(){}
    public List<string> titles {get{return _eventTitles;}}
    public List<string> descriptions {get{return _eventDescriptions;}}
    public List<string> dates {get{return _eventDates;}}
    public List<string> times {get{return _eventTimes;}}
    public List<string> addresses {get{return _eventAddresses;}}
    public int capacity {get{return _lectureCapacity;}}
    public string speaker {get{return _lectureSpeaker;}}
    public string email {get{return _receptionEmail;}}
    public string weather {get{return _gatheringWeather;}}

}