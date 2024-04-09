public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetVideoInfo()
    {
        return $"{_title} : {_author}";
    }

    public void addComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"     - {comment.GetCommentDetails()}");
        }
    }

    public string GetVideoDetails()
    {
        return $"{_title} by {_author} -- Length: {_length} min -- Total Comments: {_comments.Count()}";
    }
}