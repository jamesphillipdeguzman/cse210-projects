namespace Foundation3;

public class OutdoorEvent : Event
{
    private string _weatherStatement;

    // Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
    public OutdoorEvent() {}
    public OutdoorEvent(string title, string description, string date, string time, string address, string weatherStatement): base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weatherStatement = weatherStatement;

    }

    public string ShortDescription(string title, string description, string date, string time, string address, string weatherStatement)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _weatherStatement = weatherStatement;

        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}\nWeather Forecast: {_weatherStatement}";
    }
}

