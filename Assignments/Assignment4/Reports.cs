using System;
using System.Collections.Generic;
using System.Linq;

internal class Reports
{
    static List<Trainee> trainees = new List<Trainee>
    {
        new Trainee("Ram Bista", new DateTime(1990, 12, 12), "Vedas", "BIT"),
        new Trainee("Laxman Shrestha", new DateTime(1988, 1, 10), "Ascol", "BSC"),
        new Trainee("Bishnu Rawal", new DateTime(1990, 4, 22), "PK", "BIM"),
        new Trainee("Suneer Bista", new DateTime(2000, 6, 10), "Central TU", "BIT"),
        new Trainee("Sita Acharya", new DateTime(2010, 8, 29), "CCRC", "BIT"),
        new Trainee("Ram Basnet", new DateTime(2004, 9, 23), "People's College", "BSC"),
        new Trainee("Rama Chitrakar", new DateTime(2003, 8, 17), "People's College", "BSC"),
        new Trainee("Mahesh Manandhar", new DateTime(2004, 9, 23), "CCRC", "BIM"),
        new Trainee("Renu Shahi", new DateTime(2004, 9, 23), "Vedas", "BIM"),
        new Trainee("Sanjana Luitel", new DateTime(2007, 4, 26), "PK", "BSC")
    };
    
    public static void LetsQuery()
    {
        // Get all trainees grouped by their college
        var groupedByCollege = trainees
            .GroupBy(t => t.College)
            .Select(g => new
            {
                College = g.Key,
                Trainees = g.Select(t => t.Name).ToList()
            });

        Console.WriteLine("Trainees grouped by college:");
        foreach (var group in groupedByCollege)
        {
            Console.WriteLine($"College: {group.College}");
            foreach (var trainee in group.Trainees)
            {
                Console.WriteLine($"- {trainee}");
            }
        }
        Console.WriteLine();

        // Get name and age of trainees who are in their teens (between 13 and 19 years old)
        var teens = trainees
            .Where(t =>
            {
                var ageInMonths = t.CalculateAge().AgeInMonths;
                var ageInYears = ageInMonths / 12;
                return ageInYears >= 13 && ageInYears <= 19;
            })
            .Select(t => new
            {
                Name = t.Name,
                Age = t.CalculateAge().AgeString
            });

        Console.WriteLine("Trainees in their teens:");
        foreach (var teen in teens)
        {
            Console.WriteLine($"{teen.Name} - {teen.Age}");
        }
        Console.WriteLine();

        // Get name initials, age and academic program of trainees and order result by initials
        var orderedByInitials = trainees
            .Select(t => new
            {
                Initials = t.GetInitials(),
                Age = t.CalculateAge().AgeString,
                Program = t.Program,
                Name = t.Name
            })
            .OrderBy(t => t.Initials)
            .ToList();

        Console.WriteLine("Trainees ordered by initials:");
        foreach (var trainee in orderedByInitials)
        {
            Console.WriteLine($"{trainee.Initials} -- {trainee.Name} -- {trainee.Age} -- {trainee.Program}");
        }
    }
}
