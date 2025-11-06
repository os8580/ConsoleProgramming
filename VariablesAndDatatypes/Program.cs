// See https://aka.ms/new-console-template for more information
using System.Globalization;

//Variable Declaration and Types


string fullName = string.Empty;
int age = 0;
double salary = 0;
char gender = char.MinValue;
bool working;

// Promt User for Input
Console.WriteLine("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Please Enter Your Gender (M or F): ");
gender = char.ToUpper(Convert.ToChar(Console.ReadLine()));

Console.WriteLine("Are You Working (true or false)?: ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine($"Your Name is {fullName}");
Console.WriteLine($"Your Age is {age}");
Console.WriteLine($"Your Salary is {salary}");
Console.WriteLine($"Your Gender is {gender}");
Console.WriteLine($"Your Working Status is {working}");