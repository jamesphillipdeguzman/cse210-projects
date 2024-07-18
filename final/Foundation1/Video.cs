namespace Foundation1;
//  To track the title, author, and length (in seconds) of the video.

public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments = new List<Comment>();


    public Video() { }

    public string GetVideoInfo()
    {

        return $"{_title}: {_author} - {_length} minutes";
    }

    public void SetVideo(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;

    }
    //  - Store a list of comments, and should have a method to return the number of comments.
    public int GetNumberOfComments(Comment comment)
    {
        int ctrComments = 0;
        string allComments = "";
        _comments.Add(comment);

        foreach (Comment comment1 in _comments)
        {
            // setup all comments string accumulator
            allComments += comment1.GetComment() + "\n";
            // count comments
            ctrComments += 1;
        }
        if (allComments.Contains("~")) // watch out for EOF ~
        {
            // Print to console once EOF has been found
            Console.WriteLine($"Number of Comments: {ctrComments}\n{allComments}\n");
            // Create new list of _comments
            List<Comment> _comments = new List<Comment>();
            // Reset counter to 0
            ctrComments = 0;
        }
        return ctrComments;
    }
}
