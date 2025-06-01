public class Video
{
    public string title;
    public string author;
    public int length;
    public List<Comment> comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
}
