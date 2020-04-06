using System;

//Modifique el siguiente programa que tiene problemas de compilación
public class Program
{
	public void Main(string[]args)
	{
       int number = 20;
       Console.WriteLine("number + 5 = {0}");
       AddFive(number);
      
	}
    public void AddFive (int number)
    {
        number = number +5;
        Console.WriteLine(number);
        
    }
}