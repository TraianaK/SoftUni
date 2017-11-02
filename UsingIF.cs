using System;

class UsingIF
{
    static void Main()
    {
        Console.WriteLine("Please enter a score : ");
        var num = double.Parse(Console.ReadLine());
        var bonus = 0.0;

        if (num <= 100)
        {
            bonus = bonus + num;
        }
        else if (num <= 1000)
        {
            bonus = bonus + num * 20.0 / 100;
        }
        else
        {
            bonus = bonus + num * 10.0 / 100;
        }

        if (num % 2 == 0)
        {
            bonus++;
        }
        else if (num % 10 == 5)
        {
            bonus = bonus + 2;
        }

        Console.WriteLine("Bonus is : " + bonus);
        Console.WriteLine("Total amount of credits is : {0}", num+bonus);
    }
}

