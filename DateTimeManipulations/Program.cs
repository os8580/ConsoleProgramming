// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1980, 12, 30);
Console.WriteLine("My Dob is: " + dateOfBirth);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The Time Now is: " + now);

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse(DateTime.Now.ToString(), CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + dateFromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date Only of Dob is: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time Only now is: " + timeOnly);
