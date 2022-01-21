using System;
					
public class Program
{
	public static void Main()
	{
		/*Console.WriteLine("Hello World");
		
		int num1 = Convert.ToInt32(Console.ReadLine());
		int num2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(num1 + num2);
		
		int num3 = Convert.ToInt32(Console.ReadLine());
		int num4 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(num3 / num4);*/
		
		//remember to read backwards
		
		int firstNum = Convert.ToInt32 (Console.ReadLine());
		int secondNum = Convert.ToInt32 (Console.ReadLine());
		Console.WriteLine(firstNum);
		Console.WriteLine(secondNum);
		int thirdNum = firstNum;
		firstNum = secondNum;
		secondNum = thirdNum;
		Console.WriteLine(firstNum);
		Console.WriteLine(secondNum);
		
	}
}
