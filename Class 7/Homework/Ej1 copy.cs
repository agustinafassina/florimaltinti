using System;

//El usuario debe ingresar dos valores y el programa mostrará el resultado de (a+b)*(a-b). Implementando VOID
public class Program
{
	public void Main()
	{
        Valores();
    	Calculo(,);
	}
     void Valores(string valores)
    {	
        Console.WriteLine("Ingrese valor para A");
        string vImputTemp = Console.ReadLine();
        int vA = Convert.ToInt32(vImputTemp);

        Console.Clear();

        Console.WriteLine("Ingrese valor para B");
        string vImputTemp2 = Console.ReadLine();
        int vB = Convert.ToInt32(vImputTemp2);

        Console.Clear();
    }
    void Calculo(int vA, int vB)
    {
		int vResultado;
        vResultado= (vA+vB)*(vA-vB);
        Console.WriteLine("El resultado es {0}", vResultado);
    }
}
