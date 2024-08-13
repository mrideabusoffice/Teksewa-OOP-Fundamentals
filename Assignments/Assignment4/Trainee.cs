using System;

internal class Trainee
{
    public string Name { get; private set; }
    public DateTime Dob { get; private set; }
    public string College { get; private set; }
    public string Program { get; private set; }

    public Trainee(string name, DateTime dob, string college, string program)
    {
        Name = name;
        Dob = dob;
        College = college;
        Program = program;
    }

    // Calculate age of a trainee in years and months
    public (string AgeString, int AgeInMonths) CalculateAge()
    {
        var today = DateTime.Today;
        var age = today.Year - Dob.Year;
        if (Dob.Date > today.AddYears(-age)) age--;

        var months = today.Month - Dob.Month;
        if (months < 0) months += 12;

        return ($"{age} Years and {months} Months", age * 12 + months);
    }

    // Get name initials of a trainee e.g. Bishnu Singh Rawal => BR
    public string GetInitials()
    {
        var nameParts = Name.Split(' ');
        if (nameParts.Length < 2) return string.Empty; // Ensure there are at least two parts

        char firstInitial = nameParts[0][0];
        var lastInitial = nameParts[^1][0];   

        return $"{firstInitial}{lastInitial}";       
    }
    
    public static string PrintDetails(Trainee trainee) => 
        $"{trainee.Name}\t{trainee.Dob.ToShortDateString()}\t{trainee.College}\t{trainee.Program}";
}
