namespace Foundation3;

public class ReceptionEvent : Event
{
    private string _rsvpEmail;

    // Receptions, which require people to RSVP, or register, beforehand.
    public ReceptionEvent() {}

    public ReceptionEvent(string title, string description, string date, string time, string address, string rsvpEmail) : base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _rsvpEmail = rsvpEmail;
    }
    public string StandardDetails(string title, string description, string date, string time, string address, string rsvpEmail)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _rsvpEmail = rsvpEmail;

        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}\nRSVP: {_rsvpEmail}";


    }
}
