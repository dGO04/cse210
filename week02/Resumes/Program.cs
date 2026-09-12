using System;


class Program
{
    static void Main(string[] args)
    {

        Resume resume = new Resume();

        resume._name = "Diego Esquit";
        
        Job contracts = new Job();
        Job secretary = new Job();
        Job customerService = new Job();

        contracts._company = "Joshua Tree Experts";
        contracts._jobTitle = "Renewal Assistant";
        contracts._startYear = "2026";
        contracts._endYear = "2027";

        string contractsInfo = contracts.Display();
        resume._jobs.Add(contractsInfo);

        secretary._company = "Construservicios JAGUA";
        secretary._jobTitle = "Administrative Assistant";
        secretary._startYear = "2022";
        secretary._endYear = "2022";

        string secretaryInfo = secretary.Display();
        resume._jobs.Add(secretaryInfo);

        customerService._company = "24/7 Intouch";
        customerService._jobTitle = "Customer Service Representative";
        customerService._startYear = "2021";
        customerService._endYear = "2021";

        string customerServiceInfo = customerService.Display();
        resume._jobs.Add(customerServiceInfo);

        resume.Display();
    }
}