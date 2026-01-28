using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2026;
        job1._endYear = 2029;
        Job job2 = new Job();
        job2._jobTitle = "Game Designer";
        job2._company = "Nintendo";
        job2._startYear = 2025;
        job2._endYear = 2029;
        Job job3 = new Job();
        job3._jobTitle = "Junior Developer";
        job3._company = "Microsoft";
        job3._startYear = 2027;
        job3._endYear = 2030;
        job1.Display();
        job2.Display();
        job3.Display();

        Resume resume1 = new Resume();
        resume1._name = "greg";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._jobs.Add(job3);
        resume1.Display();

    }
}