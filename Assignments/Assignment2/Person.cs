class Person
{
    public Person (string name, double weight, double height)
    {
        this.name = name;
        this.weight = weight;
        this.height = height;


    }
    public string name;
    public double weight;
    public double height;

    double CalculateBMIOfPerson (double height, double weight){
        double bmi = weight/Math.Pow(height * 0.3048,2);
        return bmi;
    }
    public void PrintDetails(){
        Console.WriteLine($"BMI of {this.name} is {CalculateBMIOfPerson(this.height, this.weight)}");
    }
}