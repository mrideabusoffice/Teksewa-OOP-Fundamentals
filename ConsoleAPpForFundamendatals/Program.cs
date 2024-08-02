// Datatypes

//Numbers: Integer and Floating Point (Floats/ Fixed Point)

byte? age = 27; //8 bits
// age = null;  // ? added at the end of datatype determines that it is nullable.
short numberOfPeopleInCompany = 23121; //16 bits  Camel casing

// Pascal casing has first letter capital as well. It's used for declating class and methods.

int  areaOfCountry = 151447;  //32 bits
long distanceBetweenPlanets = 2345235436543;

//Accuracy (Precision)
float averageWeight = 63.5F; //32bits
double averageDistance = 1231312.12312321;
decimal averageDistanceBetweenElectrons = 1231231.1231231231231M;


//Text

string name = "Pradyumna Ji";
char gender = 'M';



// Boolean (Flags)

bool isQA = true;


//Dates
DateTime dob = new(1996/11/19);


Console.WriteLine(averageWeight);


// string userInput = Console.ReadLine();
// Console.WriteLine("You entered " + userInput.Length + " characters."); //String concatetation
// Console.WriteLine($"You entered {userInput.Length} characters."); //String 



// Get input from user and change it to uppercase

Console.WriteLine("Enter your name:");
string userInput = Console.ReadLine();
Console.WriteLine($"Your name is {userInput.ToUpper()}"); //String concatetation
