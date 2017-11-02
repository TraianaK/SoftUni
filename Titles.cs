using System;

class Titles
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a gender : ");
            var gender = Console.ReadLine();
            Console.WriteLine("Please enter an age : ");
            var age = int.Parse(Console.ReadLine());

            if (gender == "male")
            {
                if (age < 16) Console.WriteLine("Master");
                else Console.WriteLine("Mr");
            }
            else if (gender == "female")
            {
                if (age < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms");
            }
        }
    }
}

