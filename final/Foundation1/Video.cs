using System;

class Video {
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> Comments;

    public Video(string title, string author, int length) 
    {   
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();        
    }

    public void AddComment(string name, string text)
    {
        Comments.Add(new Comment(name, text));
    }

    public int GetNumberOfComments() 
    {
        return Comments.Count;
    }
}