using System;

//Dado el siguiente código, modifíquelo para realizar la suma de 3 valores
public class Program
{
	public void Main()
	{
		Console.WriteLine("El resultado de la operacion es = {0}", sumar());
	}
	public int sumar()
	{
		Console.WriteLine("Ingrese un valor de A");
		string valorA = Console.ReadLine();
        int num1 = Convert.ToInt32(valorA);

		Console.Clear();

		Console.WriteLine("Ingrese un valor de B");
		string valorB = Console.ReadLine();
        int num2 = Convert.ToInt32(valorB);

		Console.Clear();

		Console.WriteLine("Ingrese un valor de C");
		string valorC = Console.ReadLine();
        int num3 = Convert.ToInt32(valorC);
		
		Console.Clear();

		int resultado = num1 + num2 + num3;
		return resultado;
	}
}
