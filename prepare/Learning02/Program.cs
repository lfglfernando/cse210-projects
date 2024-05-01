using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        // Example with a person
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2007;
        job1._endYear = 2024;

        // Another example with a different person
        Job job2 = new Job();
        job2._jobTitle = "QA Tester";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2022;
        
        List<Job> jobList = new List<Job>();
        jobList.Add(job1);
        jobList.Add(job2);
        

        Resume myResume = new Resume();
        myResume._name = "Fernando Galvez";
        myResume._jobs = jobList; 

        myResume.DisplayResumeDetails();
    }
}
