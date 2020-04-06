using System;
															//Pedir nombre y que lo imprima 80 veces
public class Program
{
	public static void Main()
	{
		Console.Write("Type your first name: ");
		string myFirstName; 
        myFirstName = Console.ReadLine();

		Console.Clear();
				
		for (int i=0; i < 81; i++)
		{
			Console.WriteLine (myFirstName + "{0}", i);
		}
	}
}
