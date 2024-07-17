namespace Foundation3;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    // -- Check why base is throwing an error
    public LectureEvent(string title, string description, string date, string time, string address, string speaker, int capacity): base(title, description, date, time, address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;


    }

    public void FullDetails()
    {

    }
}
