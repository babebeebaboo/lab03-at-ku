/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: powFac.cs                         
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////

using System;
namespace test
{
	class test01
	{
		private static void power()
		{
			Console.Write("\nEnter integer: ");
			int i = int.Parse(Console.ReadLine());	
			int k=i;
			Console.Write("Enter power: ");
			int p = int.Parse(Console.ReadLine());
			for (int j=1;j<p;j++)i*=k;
			Console.WriteLine("{0}^{1} = {2}",k,p,i);
		}

		private static int factorial(int i)
		{
			if(i<=1)return 1;
			else return i*factorial(i-1);
		}
		private static void fac()
		{
			Console.Write("\nEnter integer: ");
			int i = int.Parse(Console.ReadLine());	
			Console.WriteLine("{0}! = {1}",i, factorial(i));	
		}
		private static void Select_Func(int  a)
		{
			if(a == 'p')power();
			if(a=='f')fac();
		}
		static void Main()
		{
			Console.Write("Type p for power, f for factorial: ");
			int aa = Console.Read();
			Select_Func(aa);
		}
	}
}
