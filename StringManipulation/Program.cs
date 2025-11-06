// See https://aka.ms/new-console-template for more information
string firstName = "Trevoir";
string lastName = "Williams";
DateTime date = DateTime.Now;

// Print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

// Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + " " + firstName);
Console.WriteLine($"My full name is {lastName} {firstName}");
Console.WriteLine("My full name is {0} {1}", lastName, firstName);

// String Length
int length = firstName.Length;
Console.WriteLine($"Your name lengh is {length} letters long");

// Replace string parts
string newName = firstName.Replace("T", "K");
Console.WriteLine(newName);

string newName1 = firstName.Replace('i', ' ');
Console.WriteLine(newName1);

// Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);


// Split String
string[] splitName = fullName.Split('v');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

// Compare Strings
string nullString = null;
string emptyString = "";
string whitespaceString = " ";
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if (firstName == lastName)
{
    Console.WriteLine("Names are equal");
}
if (firstName != lastName)
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

// Convert to String

string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 12345.ToString();