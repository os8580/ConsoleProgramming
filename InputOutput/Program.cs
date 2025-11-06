// See https://aka.ms/new-console-template for more information


// Declare Variable
string fullName; //camelCase

//Allow user input and store in variable
Console.WriteLine("Enter your name: ");
//string fullName = Console.ReadLine();
fullName = Console.ReadLine();

//Print contents of variable/user's input
Console.Write("Good job! ");
Console.WriteLine($"Hello, {fullName}");