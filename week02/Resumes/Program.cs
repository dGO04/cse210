using System;


class Program
{
    static void Main(string[] args)
    {
        
        //Save job details in this Resume object
        Resume resume = new Resume();

        resume._name = "Diego Esquit";
        
        //Create new Job object for each different job 
        Job contracts = new Job();
        Job secretary = new Job();
        Job customerService = new Job();

        //Add details for first Job object
        contracts._company = "Joshua Tree Experts";
        contracts._jobTitle = "Renewal Assistant";
        contracts._startYear = "2026";
        contracts._endYear = "2027";

        //Save full job details into Resume job list
        string contractsInfo = contracts.Display();
        resume._jobs.Add(contractsInfo);

        //Add details for second Job object
        secretary._company = "Construservicios JAGUA";
        secretary._jobTitle = "Administrative Assistant";
        secretary._startYear = "2022";
        secretary._endYear = "2022";

        //Save full job details into Resume job list
        string secretaryInfo = secretary.Display();
        resume._jobs.Add(secretaryInfo);

        //Add details for third Job object
        customerService._company = "24/7 Intouch";
        customerService._jobTitle = "Customer Service Representative";
        customerService._startYear = "2021";
        customerService._endYear = "2021";

        //Save full job details into Resume job list
        string customerServiceInfo = customerService.Display();
        resume._jobs.Add(customerServiceInfo);

        //Display job list to the user
        resume.Display();
    }
}