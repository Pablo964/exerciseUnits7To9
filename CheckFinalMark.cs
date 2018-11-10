using System;
class ChekFinalMark
{
    static void Main()
    {
        Console.WriteLine("Put your mark of exam one");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Put your mark of exam two");
        int mark2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Put your mark of exam three");
        int mark3 = Convert.ToInt32(Console.ReadLine());
        int average = (mark1 + mark2 + mark3) / 3;
        if (( mark1 >= 4 ) && ( mark1 >= 4 ) && ( mark1 >= 4 ))
        {
            Console.WriteLine("You average is: " + average);
        }
        else if (( average >= 5 ) && (( mark1 < 4 ) || ( mark2 < 4 ) || ( mark3 < 4 )))
        {
            Console.WriteLine("You average is: 3");
        }
        else
        {
            Console.WriteLine("You average is: " + average);
        }
    }
}
