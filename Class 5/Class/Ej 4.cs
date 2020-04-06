using System;
                                                            //Pedir un numero entre 0-80 y que el ciclo se rompa cuando llegue al numero pedido 					
public class Program
{
	public static void Main()
	{
		Console.Write("Type one nº between 0 & 80: ");
		
				
		string vImputTemp = Console.ReadLine();
        int vNumber = Convert.ToInt32(vImputTemp);

		Console.Clear();
				
		for (int i=0; i <= 80; i++)
		{
			if(i==vNumber)
            {
            Console.WriteLine ("{0}", i);
                {
                break;
                }
			}
			
		}
	}
}