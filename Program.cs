// See https://aka.ms/new-console-template for more information
Console.Write("please enter the length : ");
double length = double.Parse(Console.ReadLine());
Console.Write("please enter the width : ");
double width = double.Parse(Console.ReadLine());
if (length == width)
{
    Console.WriteLine("it is square");
}
else if (length != width)
{
    Console.WriteLine("it isn't square");
}

