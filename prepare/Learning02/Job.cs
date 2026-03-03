
class Job
{
    public string _companyName;

    public string _jobTitle;

    public int _startYear;

    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"Name: {_companyName}, Job Title: {_jobTitle}, Start Year: {_startYear}, End Year: {_endYear}");
    }
}