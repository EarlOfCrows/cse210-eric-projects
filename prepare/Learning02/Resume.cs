using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:\n{_jobs[0]._jobTitle}");
    }
}