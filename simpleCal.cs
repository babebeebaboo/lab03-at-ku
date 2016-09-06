/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: simpleCal.cs                      
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
class simpleCal
{
	static void Main()
	{
		Console.WriteLine("Function :\n + = Plus\n - = Minus\n * = Multiply\n / = Divide\n");

		Console.Write("Enter function: ");
		string function = Console.ReadLine();
		double res = 0.0;
		double a = getInput(1);
		double b = getInput(2);
		
		if(function=="+")
		{
			res = plus(a,b);
			Console.WriteLine("result = {0}",res);
		}
		else if(function=="-")
		{
			res = minus(a,b);
			Console.WriteLine("result = {0}",res);
		}
		else if(function=="*")
		{
			res = multiply(a,b);
			Console.WriteLine("result = {0}",res);
		}
		else if(function=="/")
		{
			res = divide(a,b);
			Console.WriteLine("result = {0}",res);
		}
		else
		{
			Console.WriteLine("Please re-excute and try again...");
		}
	}
	static double getInput(int num)
	{
		Console.Write("Enter Input{0}: ",num);
		return double.Parse(Console.ReadLine());
	}
	static double plus(double number1, double number2)
	{
		return number1+number2;
	}
	static double minus(double number1, double number2)
	{
		return number1-number2;
	}
	static double multiply(double number1, double number2)
	{
		return number1*number2;
	}
	static double divide(double number1, double number2)
	{
		return number1/number2;
	}
}
