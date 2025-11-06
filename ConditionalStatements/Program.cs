// See https://aka.ms/new-console-template for more informatio

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, <, >, >=, <=, != )
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
}
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}
else
{
    Console.WriteLine("Invalid Input");
}

Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch (grade)
{
    case int n when n >= 0 && n <= 59:
        Console.WriteLine("You Failed");
        break;
    case int n when n >= 60 && n <= 100:
        Console.WriteLine("You got 10 marks");
        break;
    case 101:
        Console.WriteLine("Single Case Example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

// Ternary Operators

var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);