using System;
using System.Collections.Generic;
public class Comments
{

    protected string _nameCommented;
    protected string _comment;

    public Comments(string nameCommented, string comment)
    {
        _nameCommented = nameCommented;
        _comment = comment;
    }

    public string GetDataFromTheComments()
    {
        return$"{_nameCommented}: {_comment}";
    }
}