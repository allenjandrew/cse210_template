using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "NewLine Solutions";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2023";
        job1._endYear = "2027";

        // job1.Display();

        Job job2 = new Job();
        job2._company = "Crack'd";
        job2._jobTitle = "Technician";
        job2._startYear = "2027";
        job2._endYear = "2029";

        // job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Andrew Allen";
        myResume._jobList.Add(job1);
        myResume._jobList.Add(job2);

        myResume.Display();



    }
}