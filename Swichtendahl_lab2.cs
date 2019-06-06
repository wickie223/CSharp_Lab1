using System;
					
public class Swichtendahl_lab2
{
	public static void Main( string[] args)
	{
		// Problem 1
		Console.WriteLine("Problem 1");
		int counter = 0;
		
		while ( counter <= 30 ) 
		{
			Console.WriteLine( "{0}", counter );
			counter = counter + 3;	
		}
		
		//Problem 2
		Console.WriteLine("\nProblem 2");
		for ( int i = 1; i <=10; i++) 
		{
		  if ((i % 2) == 0) 
		  {
			  Console.WriteLine("{0} is even", i );
		  }
		  else
		  {
			  Console.WriteLine("{0} is odd", i );
		  }
		} 
		
		// Problem 3
		Console.WriteLine("\nProblem 3");
		int number1;
		Console.WriteLine("Please enter a temperature in whole numbers");
		number1 = Convert.ToInt32(Console.ReadLine());
		
		if (number1 < 32)
		{
			Console.WriteLine("freezing");
		} 
		else if (number1 < 50)
		{
			Console.WriteLine("cold");
		}
		else if (number1 < 70)
		{
			Console.WriteLine("mild");
		}
		else if (number1 < 90)
		{
			Console.WriteLine("warm");
		}
		else
		{
			Console.WriteLine("hot");
		}
		
		// Problem 4
		Console.WriteLine("\nProblem 4");
		int j = 10;
		while (j < 21)
		{
    		Console.WriteLine("{0}", j );
			j = j + 1;
		}
		
		//Problem 5
		Console.WriteLine("\nProblem 5");
		for (int i = 0; i < 101; i++)
		{	
    		Console.WriteLine(i);
    		Console.WriteLine("********");
		}
		
		//Problem 6
		Console.WriteLine("\nProblem 6");
		for (int x = 1; x <=10; x++)
		{
			for (int y = 1; y <=x; y++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
		for (int x = 9; x >=1; x--)
		{
			for (int y = 1; y <=x; y++)
			{
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}