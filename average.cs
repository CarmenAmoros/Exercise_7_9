// This program calculates the average of a set of marks, until the user types "end"
using System;

public class Average
{
	public static void Main()
	{
		double sum = 0, markNumber, count = 0, resultAverage;
		string end;

		Console.Write("Insert a mark: ");
		end = Console.ReadLine();	

		while (end != "end")
		{  
			// if the mark isn't an end then we pass it to double to work with it
			markNumber = Convert.ToDouble(end);
			count++;   
			sum += markNumber;  

			Console.Write("Insert a mark: ");
			end = Console.ReadLine();
		}
		/* This way the count will accumulate the 
		   number of subjects to check the average of the marks*/
		if (count != 0)
		{
			resultAverage = sum / count;  
			Console.WriteLine("The average is {0}.", resultAverage);
		}
	}
}
