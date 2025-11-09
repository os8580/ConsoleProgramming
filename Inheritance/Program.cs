
var cube = new Cube();
var triangle = new Triangle();
var rectangle = new Rectangle();

Console.WriteLine("Enter Length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Height:");
int height = Convert.ToInt32(Console.ReadLine());

cube.Length = length;
cube.Width = width;
cube.Height = height;

triangle.Length = length;
triangle.Height = height;


rectangle.Length = length;
rectangle.Width = width;

Console.WriteLine("Cube Area Is: " + cube.GetArea());
Console.WriteLine("Cube Area Is: " + cube.GetVolume());

Console.WriteLine("Triangle Area Is: " + triangle.GetArea());
Console.WriteLine("Rectangle Area Is: " + rectangle.GetArea());