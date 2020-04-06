using System;

//Crear un metodo modificando el programa anterior pero un parametro va a ser string que va a ser su nombre y lo muestren por pantalla
public class Program
{
	public void Main()
	{
    	string vName;
		Console.WriteLine("Inserte su nombre");
		vName=Console.ReadLine();
        SayMyName (vName);
	}
    void SayMyName(string vName)
    {	
        Console.Clear();
        Console.WriteLine("Su nombre es {0}",vName);
    }
}
