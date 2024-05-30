using System;
using System.Collections.Generic;

public class Video
{
    protected string _title;
    protected string _author;
    protected double _length;
    protected List<Comments> _comments;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetDataFromTheVideo()
    {
        TimeSpan time = TimeSpan.FromSeconds(_length);
        string formattedTime = string.Format("{0:D2}m:{1:D2}s", time.Minutes, time.Seconds);
        string videoData = $"Title: {_title}\nAuthor: {_author}\nLength: {formattedTime}\nNumber of Comments: {GetNumberOfComments()}\nComments:\n";

        foreach (Comments comment in _comments)
        {
            videoData += $" {comment.GetDataFromTheComments()}\n";
        }
        return videoData;
    }
}

