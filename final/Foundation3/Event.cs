namespace Foundation3;
// Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

public class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event() { }

    public Event(string title, string description, string date, string time, string address)
    {

    }

    // Lists the title, description, date, time, and address.
    public virtual string StandardDetails(string title, string description, string date, string time, string address)
    {

        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}";

    }

    // For lectures, this includes the speaker name and capacity.
    // For receptions this includes an email for RSVP.
    // For outdoor gatherings, this includes a statement of the weather.
    // Full details - Lists all of the above, plus type of event and information specific to that event type.
    public virtual string FullDetails(string title, string description, string date, string time, string address)
    {

        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}";
    }

    // Short description - Lists the type of event, title, and the date.
    public virtual string ShortDescription(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}";
    }

}
