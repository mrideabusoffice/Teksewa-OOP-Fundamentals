using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var filePath = "People.csv"; 
        var people = CSVParser.ParseCsv(filePath);

        PeopleReport.SaveMales(people);
        PeopleReport.SaveFemales(people);
        PeopleReport.SaveDotComUsers(people);

        Console.WriteLine("Reports generated successfully.");
    }
}
