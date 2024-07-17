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
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public Event(Address address, string title)
    {

    }

    // Lists the title, description, date, time, and address.
    public virtual string StandardDetails(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        return "";
    }
    // Full details - Lists all of the above, plus type of event and information specific to that event type.
    // For lectures, this includes the speaker name and capacity.
    // For receptions this includes an email for RSVP.
    // For outdoor gatherings, this includes a statement of the weather.
    public virtual string FullDetails(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        return "";
    }
    // ShortDescription(type, event, title, date) : string -- > Check if type and event can be passed in as parameters here...
    // Short description - Lists the type of event, title, and the date.

    public virtual string ShortDescription(string title, string date)
    {
        _title = title;
        _date = date;
        return "";
    }

}
