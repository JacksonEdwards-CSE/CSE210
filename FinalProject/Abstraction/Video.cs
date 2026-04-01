
using System.Runtime.CompilerServices;

class Video
{
    
    private string _title;

    private string _author;

    private double _videoLength;

    private List<Comment> _commentList;

    public Video(string title, string author, double seconds)
    {
        _title = title;
        _author = author;
        _videoLength = seconds;
        _commentList = new List<Comment>();
    }

    public void GetVideoData()
    {
        double lengthInMinutes = _videoLength / 60;

        Console.WriteLine($"{_title} ({lengthInMinutes:N2} minutes) - by: {_author}");
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _commentList)
        {
            Console.WriteLine(comment.GetComment());
        }
    }

    public void GetCommentData()
    {
        int numberOfComments = 0;
        foreach (Comment comment in _commentList)
        {
            numberOfComments++;
        }

        Console.WriteLine($"There are {numberOfComments} comments on this video.");
    }

    public void AppendComment(Comment comment)
    {
        _commentList.Add(comment);
    }
}