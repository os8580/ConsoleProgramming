// See https://aka.ms/new-console-template for more information

// For Loop (Counter Controlled)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Iteration Number: {i}");
}

// While Loop (Condition Controlled - Pre Check)
while (false)
{
    Console.WriteLine("This will not be printed.");
}
// Do...While Loop (Condition Controlled - Post Check)
do
{
    Console.WriteLine("This will be printed once.");
} while (false);

// Foreach Loop - Hounarable Mention
foreach (char c in "Hello")
{
    Console.WriteLine(c);
}

