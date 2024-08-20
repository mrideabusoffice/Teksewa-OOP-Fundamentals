using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class PeopleReport
{
    public static void SaveMales(List<Person> people)
    {
        var males = people.Where(p => p.Sex.Equals("Male", StringComparison.OrdinalIgnoreCase)).ToList();
        WriteToCsv("males.csv", males);
    }

    public static void SaveFemales(List<Person> people)
    {
        var adultFemales = people
            .Where(p => p.Sex.Equals("Female", StringComparison.OrdinalIgnoreCase) && 
                        (DateTime.Now.Year - p.DateOfBirth.Year) >= 18)
            .ToList();
        WriteToCsv("adultfemales.csv", adultFemales);
    }

    public static void SaveDotComUsers(List<Person> people)
    {
        var dotComUsers = people
            .Where(p => p.Email.EndsWith("@example.com", StringComparison.OrdinalIgnoreCase))
            .Select(p => new { p.UserId, p.Email, p.Phone })
            .ToList();
        WriteToCsv("dotcomusers.csv", dotComUsers);
    }

    private static void WriteToCsv<T>(string fileName, List<T> records)
    {
        using (var writer = new StreamWriter(fileName))
        {
            var properties = typeof(T).GetProperties();

            // Write header
            writer.WriteLine(string.Join(",", properties.Select(p => p.Name)));

            // Write data
            foreach (var record in records)
            {
                writer.WriteLine(string.Join(",", properties.Select(p => p.GetValue(record))));
            }
        }
    }
}
