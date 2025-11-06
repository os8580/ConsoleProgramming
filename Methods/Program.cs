// See https://aka.ms/new-console-template for more information

//Void Functions
void PrintName(string name = "DEFAULT_NAME")
{
    Console.WriteLine(name);
}

PrintName("Vitya");
PrintName("Petya");
PrintName();

Console.WriteLine("End of Void Function");

//Value Returning Functions

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;
    if (largest < num2)
    {
        largest = num2;
    }
    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}

Console.WriteLine(LargestNumber(number1, number2, number3));