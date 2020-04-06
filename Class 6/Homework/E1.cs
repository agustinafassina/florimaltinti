using System;
using System.Collections.Generic;
//Modificar el siguiente programa para que le solicite al usuario el nombre de la familia y luego muestre
//por pantalla si esa familia fue encontrada en la lista FamilyName
public class Program
{
	public static void Main()
	{
    	Console.WriteLine("Ingrese Nombre de la Familia");
    	string vName = Console.ReadLine();
		
		var FamilyName = new List<String>(){ "Windows", "Stairs" ,"Roofs","Doors","Walls"};
		
		foreach (string value in FamilyName)
		{
			if (vName == value)
			{
			break;
			}
		 	Console.WriteLine("RESULT: {0} está en la Family List", vName);
    	}
	}
}
//No entiendo porque me lo imprime 5 veces