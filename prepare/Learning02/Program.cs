using System;

class Program
{
    static void Main(string[] args)
    {        
        Job job1 = new Job();
        job1._jobTittle = "QA Engineer";
        job1._company = "NTT Data";
        job1._startYear = 2022;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTittle = "FullStack Developer";
        job2._company = "Agile - Works";
        job2._startYear = 2021;
        job2._endYear = 2022;

        Resume resume1 = new Resume();
        resume1._name="Kathy Campos";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();  

    }
}