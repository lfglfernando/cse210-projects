
using System;
using System.Collections.Generic;
public class Resume
{
    // Member variables with underscores
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume()
    {
    }

    // A method that displays the person's full name as used in eastern countries or <family name, given name>.
    public void DisplayResumeDetails()
    {
        Console.WriteLine($"Resume of {_name}:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

}