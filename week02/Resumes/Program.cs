using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}