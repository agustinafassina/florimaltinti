using System;
                                                            //Crear un programa que 
                                                            //1.Que solicite por pantalla un numero 
                                                            //2.Mostrar por pantalla la multiplicación del número solicitado por pantalla por los numero del 5 al 200(use un ciclo for para esto)
                                                            //3. Importante si la multiplicación del numero solicitado por pantalla es mayor o igual a 150 invocar el comando break
public class Program
{
	public static void Main()
	{
		Console.Write("Type a number: ");
		string vImputTemp = Console.ReadLine();
      	int vNumber = Convert.ToInt32(vImputTemp);

		Console.Clear();
				
		for (int i=5; i <= 200; i++)
		{
			int vMultiplicacion = vNumber * i;
			Console.WriteLine("Resultado - {0} * {1} = {2}", vNumber, i, vMultiplicacion);
			
            if(vMultiplicacion>=150)
            {
            break;
            }
		}
	}
}                                                    