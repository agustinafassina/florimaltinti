using System;

//El usuario debe ingresar dos valores y el programa mostrará el resultado de (a+b)*(a-b). Implementando VOID
public class Program
{
	public void Main()
	{
       int valueA = PedirValorA();
	   int valueB = PedirValorB();
	   Calculo(valueA,valueB);
      
	}
     int PedirValorA()
    {	
        Console.WriteLine("Ingrese valor para A");
        string vImputTemp = Console.ReadLine();
        int valueA = Convert.ToInt32(vImputTemp);

        Console.Clear();
		 return valueA;
    }
	
     int PedirValorB()
    {
        Console.WriteLine("Ingrese valor para B");
        string vImputTemp2 = Console.ReadLine();
      	int valueB = Convert.ToInt32(vImputTemp2);

      	Console.Clear();
		return valueB;
     }

    void Calculo(int valueA, int valueB)
    {
		int vResultado;
        vResultado= (valueA+valueB)*(valueA-valueB);
        Console.WriteLine("El resultado de (a+b)*(a-b) es {0}", vResultado);
    }
}