// Declare variables 
using System.Xml.Linq;

string? firstName = string.Empty;
string? lastName = string.Empty;
int age = 0;
int retirementAge = 65;
decimal salary;
char gender = char.MinValue;
bool working = true;

// Get user input
Console.Write("Enter your first name:");
firstName = Console.ReadLine();

Console.Write("Enter your last name:");
lastName = Console.ReadLine();

Console.Write("What is your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary");
salary = Convert.ToDecimal(Console.ReadLine);

Console.Write("Please enter your gender (M or F)");
gender = Convert.ToChar(Console.ReadLine);

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine);

//Process the data
int retirementYearsLeft = retirementAge - age;

//Output the results to user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your salary: {salary}");
Console.WriteLine($"Gender: {gender}");
Console.WriteLine($"Number of working years reminding: {retirementYearsLeft}");
Console.WriteLine($"Are you Employed?: {working}");


