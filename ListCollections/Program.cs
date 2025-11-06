// See https://aka.ms/new-console-template for more information

//Declare
List<string> names = new List<string>();
string name = "";

//Add values to list
names.Add("Trevoir");
Console.WriteLine("Enter Names:");
//while (name != "-1")
//    while (name.Equals("-1") == false)
while (!name.Equals("-1"))
{
    Console.WriteLine("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

//Print values in list
Console.WriteLine("Names in the list are:");
//for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}

foreach (string n in names)
{
    Console.WriteLine(n);
}

