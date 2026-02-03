// See https://aka.ms/new-console-template for more information

//Defining a variable amd assigning a value
string name = "John Doe";

//Printing a varibale by itself, or with some string.
Console.WriteLine(name);
Console.WriteLine("My name is " + name); //String concatenation
Console.WriteLine($"My name is {name}"); //String interpolation
Console.WriteLine("My name is {0}", name)); //String formatting

//Defining more variables along with doing a calculation
int age = 54;
int retirementYearsLeft = 11;
int retirementAge = retirementYearsLeft + age;

Console.WriteLine("My age is: " + age);
Console.WriteLine("My retirement age is: " + retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? " + isRetired);
