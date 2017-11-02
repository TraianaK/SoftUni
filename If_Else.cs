using System;

class If_Else
{
    static void Main()
    {
        Console.WriteLine("Please enter a number : ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}

