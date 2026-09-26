public class Video
{
    private string _title;
    private string _author;
    private double _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, double videoLength)
    {
        _title = title;
        _author = author;
        _videoLength = videoLength;
    }

    public int CommentsAmount()
    {
        return _comments.Count();
    }

    public void AddComments(string [] comments)
    {
       foreach (string comment in comments)
        {
            string cleanComment = comment.Trim('"');
            string[] commentDetails = cleanComment.Split(": ");
            string user = commentDetails[0];
            string commentText = commentDetails[1];

            Comment newComment = new Comment(user:user, commentText:commentText);
            _comments.Add(newComment);
        }
    }

    public void DisplayVideo()
    {
        string vidLengthMinutes = $"{((double)_videoLength / 60):F2}";
        string[] minAndSec = vidLengthMinutes.Split(".");

        Console.WriteLine($"{_title} [{minAndSec[0]}:{minAndSec[1]}]");
        Console.WriteLine($"Posted by: {_author}");
        DisplayAllComments();
    }

    private void DisplayAllComments()
    {
        Console.WriteLine($"Comments({_comments.Count()}) [...]");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}