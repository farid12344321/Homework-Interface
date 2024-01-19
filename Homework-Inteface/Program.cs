using Homework_Inteface;

Circle circle = new Circle()
{
    Radius = 10,
};
Console.WriteLine($"Circle sahesi : {circle.CalculateArea()}");



Rectangle rectangle = new Rectangle()
{
    Height = 101,
    Width = 10,
};
Console.WriteLine($"Rectangle sahesi : {rectangle.CalculateArea()}");
