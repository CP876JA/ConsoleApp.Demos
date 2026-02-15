// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

/*
    Math Operators and Operations
 */

//Add numbers
int sum = num1 + num2;

//multiply
int product = num1 * num2;

//Division 
int quotient = num1 / num2;

//Substraction
int difference = num1 - num2;

//Modulus
int mod = num1 % num2;

Console.WriteLine("*******Maths Result******");
Console.WriteLine();
Console.WriteLine($"Sum is: {sum}");
Console.WriteLine($"Product is: {product}");
Console.WriteLine($"Difference is: {difference}");
Console.WriteLine($"Quotient is: {quotient}");
Console.WriteLine($"Modulus is: {mod}");
Console.WriteLine();
Console.WriteLine("******End of Result*******");


/*
Logic Operations and Operators
*/

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessthanorEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("******Logic Result******");
Console.WriteLine();
Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than or Equal To: {isLessthanorEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine();
Console.WriteLine("******End of Logic Result*******");

/*
    Assignment Operation and Operators
 */
int randomValue = Convert.ToInt32(Console.ReadLine());
int increaseValue = num1 + randomValue;

Console.WriteLine("******Assignment Result******");
Console.WriteLine();
//num1 = num1 + 5;
num1 += randomValue;
Console.WriteLine($"num1 after increase: {num1}");
//num1 = num1 - 5;
num1 -= randomValue;
Console.WriteLine($"num1 after decrease: {num1}");
//num1 = num1 * 5;
num1 *= randomValue;
Console.WriteLine($"num1 after multiplication: {num1}");
//num1 = num1 / 5;
num1 /= randomValue;
Console.WriteLine($"num1 after division: {num1}");
//num1 = num1 % 5;
num1 %= randomValue;
Console.WriteLine($"num1 after modulus: {num1}");