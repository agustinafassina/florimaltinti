using System;
                                                            //Pedir nombre y que el ciclo se rompa cuando llegue 5 
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
			if(i==5)
            {
            Console.WriteLine (myFirstName + "{0}", i);
            break;
            }
		}
	}
}
                                                            //Poniendo el Break DESPUES hacemos que el ciclo se rompa cuando se cumpla la condicion