using System;

class Alphabet
{
    static void Main()
    {
        var startTime = DateTime.Now;
        Console.WriteLine("The English alphabet is : ");
        for (var letter = 'a'; letter <= 'z'; letter++)
        {
            Console.WriteLine(letter);
        }
        var endTime = DateTime.Now;
        Console.WriteLine(startTime - endTime);
    }
    
}

