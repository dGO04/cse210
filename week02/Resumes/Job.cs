//This contains the class for the Job data type
public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    //Create constructor for this class
    public Job()
    {
        
    }

    //Return a detailed description of the job
    public string Display()
    {
        return $"{_jobTitle} ({_company}) {_startYear}-{_endYear}";
    }
}