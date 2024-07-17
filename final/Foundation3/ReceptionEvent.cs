namespace Foundation3;

public class ReceptionEvent : Event
{
    private string _email;
    private string _rsvp;

    // -- Check why base is throwing an error
    public string FullDetails(string title, string description, string date, string time, string address, string email, string rsvp) //: base(title, description, date, time, address)
    {
        _email = email;
        _rsvp = rsvp;

        return "";
    }
}
