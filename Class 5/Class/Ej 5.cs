using System;
                                                            //Continue salta el elemento no lo rompe
public class Program
{
	public static void Main()
	{	
	
		for (int i=1; i <= 10; i++)
		{
		
			if(i<7)
			{
			   continue;
			}
			
			Console.WriteLine(i);
		}	
		Console.WriteLine("Press any key to exit");
	
	}
}