public class Comment
{
    private string _user;
    private string _commentText;

    public Comment(string user, string commentText)
    {
        _user = user;
        _commentText = commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"   > {_user}");
        Console.WriteLine($"   {_commentText}");
    }
}