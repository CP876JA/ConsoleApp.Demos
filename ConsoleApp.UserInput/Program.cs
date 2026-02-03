// Declare variables 
string name = string.Empty;
int age = 0;
int retirementAge = 65;

// Get user input
Console.WriteLine("Enter your name:");
name = Console.ReadLine();

Console.WriteLine("What is your age:");
age = Convert.ToInt32(Console.ReadLine());

//Process the data
int retirementYearsLeft = retirementAge - age;

//Output the results to user
Console.WriteLine("Full name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Working years reminding: " + retirementYearsLeft);
