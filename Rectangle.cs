using System;

class Rectangle
{
    static void Main()
    {
        Console.WriteLine("To find area and perimeter of rectangle : ");
        Console.WriteLine("Enter side a of rectangle : ");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b of rectangle : ");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side c of rectangle : ");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side d of rectangle : ");
        double y2 = double.Parse(Console.ReadLine());

        double width = Math.Max(x1, x2) - Math.Min(x1,x2);
        double height = Math.Max(y1, y2) - Math.Min(y1, y2);

        Console.WriteLine("Area = {0}", width * height);
        Console.WriteLine("Perimeter = {0}", 2 * (width + height));

        Console.ReadLine();

    }
}

