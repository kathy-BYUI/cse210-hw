using System;
public class Job 

{
    public string _jobTittle = "";
    public string _company = "";
    public int _startYear = 0;
    public int _endYear = 0;


    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTittle} ({_company}) {_startYear}-{_endYear}");
    }
}