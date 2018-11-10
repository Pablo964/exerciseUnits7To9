/*
 * Pablo Sánchez Alonso
 * 
 * Program that shows the average of three marks.
 */
 
using System;
class ChekFinalMark
{
    static void Main()
    {
        int mark1, mark2, mark3, average;
        
        Console.WriteLine("Put your mark of exam one");
        mark1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Put your mark of exam two");
        mark2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Put your mark of exam three");
        mark3 = Convert.ToInt32(Console.ReadLine());
        
        average = (mark1 + mark2 + mark3) / 3;
        
        if (( mark1 >= 4 ) && ( mark1 >= 4 ) && ( mark1 >= 4 ))
        {
            Console.WriteLine("You average is: " + average);
        }
        
        else if (( average >= 5 ) && (( mark1 < 4 ) || ( mark2 < 4 ) 
                || ( mark3 < 4 )))
        {
            Console.WriteLine("You average is: 3");
        }
        
        else
        {
            Console.WriteLine("You average is: " + average);
        }
    }
}
