using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class CSVParser
{
    public static List<Person> ParseCsv(string filePath)
    {
        var people = new List<Person>();
        var lines = File.ReadAllLines(filePath);
        
        // Skip header line
        foreach (var line in lines.Skip(1))
        {
            var columns = line.Split(',');

            // Ensure correct number of columns
            if (columns.Length == 9) 
            {
                var person = new Person
                {
                    Index = columns[0],
                    UserId = columns[1],
                    FirstName = columns[2],
                    LastName = columns[3],
                    Sex = columns[4],
                    Email = columns[5],
                    Phone = columns[6],
                    DateOfBirth = DateTime.Parse(columns[7], CultureInfo.InvariantCulture),
                    JobTitle = columns[8]
                };

                people.Add(person);
            }
        }

        return people;
    }
}
