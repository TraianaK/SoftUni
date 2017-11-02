using System;

class InvalidNumber
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a number : ");
            var num = double.Parse(Console.ReadLine());
            var inRange = (num >= 100 && num <= 200);
            var zero = (num == 0);
            var valid = inRange || zero;
            if (!valid)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

        }
    }
}
