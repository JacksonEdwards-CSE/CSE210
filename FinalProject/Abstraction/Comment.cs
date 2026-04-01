
class Comment
{
    
    private string _commenter;

    private string _comment;

    public Comment(string commenter, string comment)
    {
        _commenter = commenter;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_commenter}: {_comment}";
    }
}