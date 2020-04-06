using System;

//Crear un programa con un metodo que se llame "Mostrar mi Nombre" llamandolo desde el main
public class Program
{
	public void Main()
	{
    	Calculo();
        
	}
    void Calculo()
    {
		Console.WriteLine("Inserte su nombre");
        string vNombre = Console.ReadLine();
		
		Console.Clear();
		
		Console.WriteLine("Mi nombre es {0}", vNombre);
    }
}
