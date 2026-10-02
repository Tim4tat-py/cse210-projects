// Job class

using System.Configuration.Assemblies;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public double _startYear;
    public double _endYear;

    public Job()
    {
    }

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}