using System;

public class Job
 {
    //declaring variable names 
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear; 

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear} - {_endYear}");
    }
 }