// Declare variables 
using System.Xml.Linq;

string firstName = string.Empty;
string lastName = string.Empty;
int age = 0;
int retirementAge = 65;

// Get user input
Console.WriteLine("Enter your first name:");
firstName = Console.ReadLine();

Console.WriteLine("Enter your last name:");
lastName = Console.ReadLine();

Console.WriteLine("What is your age:");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int retirementYearsLeft = retirementAge - age;

//Output the results to user
Console.WriteLine("Full name: " + firstName, lastName);
Console.WriteLine("Age: " + age);
Console.WriteLine("Working years reminding: " + retirementYearsLeft);
