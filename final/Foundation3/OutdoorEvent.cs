namespace Foundation3;

public class OutdoorEvent : Event
{
    private string _weatherStatement;

    // -- Check why base is throwing an error
    public string FullDetails(string title, string description, string date, string time, string address, string weatherStatement) //: base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
        return "";
    }
}

