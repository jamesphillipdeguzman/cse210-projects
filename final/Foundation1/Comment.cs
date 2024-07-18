namespace Foundation1;
// Tracks the name of the person who made the comment and the text of the comment the number of comments.
public class Comment
{
    private string _person;
    private string _textComment;

    public Comment() { }

    public string GetComment()
    {
        return _person + ": " + _textComment;
    }

    public void SetComment(string person, string textComment)
    {
        _person = person;
        _textComment = textComment;
    }
}
