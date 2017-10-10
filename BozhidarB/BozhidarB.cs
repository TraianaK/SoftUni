using System;


class BozhidarB
{
    static void Main()
    {
        Console.Write("Enter circle radius r = ");
        var r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + Math.PI * r * r);
        Console.WriteLine("Perimeter = " + 2 * Math.PI * r);

    }
}

