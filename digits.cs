/* The program calculates how many numbers of 1, 2, 3 or more digits
   are entered by the user until he/she types "end"*/
using System;

class digits
{
    static void Main()
    {
        int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreDigits = 0;

        Console.Write("Insert a number: ");
        string end = Console.ReadLine();
        /* string is used here to finish the program if the user write "end", 
           but it has to become an int to read the possible numbers*/

        while (end != "end")
        {
            int input = Convert.ToInt32(end);

            if (input != 0)
            {
                if (input/10 == 0)
                    oneDigit++;  
                else if (input/100 == 0)
		            twoDigits++;  
                else if (input/1000 == 0)
                    threeDigits++;  
                 else
                    moreDigits++;  
            }

            end = Console.ReadLine();
        }

        Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit,
        twoDigits, threeDigits, moreDigits);
    }
}

