namespace Foundation3;

public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    // Lectures, which have a speaker and have a limited capacity.

    public LectureEvent() {}
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

    public string FullDetails(string title, string description, string date, string time, string address, string speaker, int capacity)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _speaker = speaker;
        _capacity = capacity;
        return $"Event Name: {_title}\nDate and Time: {_date} at {_time}\nLocation: {_address}\nDescription: {_description}\nSpeaker: {_speaker}\nCapacity: {_capacity}";


    }
}
