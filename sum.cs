/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: sum.cs                            
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
class test
{
	static void sum(int n1,int n2,int n3,int n4)
	{
		Console.WriteLine("Sum is {0:F2}",n1+n2+n3+n4); 
	}
	static void avg(int n1,int n2,int n3,int n4)
	{
		Console.WriteLine("Sum is {0:F2}",(n1+n2+n3+n4)/4.0); 
	}
	static int Max(int n1,int n2,int n3,int n4)
	{
		int max = n1;
		if(n2>max)max=n2;
		if(n3>max)max=n3;
		if(n4>max)max=n4;
		return max;
	}
	static int Min(int n1,int n2,int n3,int n4)
	{
		int min = n1;
		if(n2<min)min=n2;
		if(n3<min)min=n3;
		if(n4<min)min=n4;
		return min;
	}
	static void avmaxmin(int a,int b)
	{
		Console.WriteLine("Avg of max and min is {0:F2}",(a+b)/2.0);
	}
	static void Main()
	{
		Console.Write("Input1: ");
		int n1 = int.Parse(Console.ReadLine());
		Console.Write("Input2: ");
		int n2 = int.Parse(Console.ReadLine());
		Console.Write("Input3: ");
		int n3 = int.Parse(Console.ReadLine());
		Console.Write("Input4: ");
		int n4 = int.Parse(Console.ReadLine());
		sum(n1,n2,n3,n4);
		avg(n1,n2,n3,n4);
		avmaxmin(Max(n1,n2,n3,n4),Min(n1,n2,n3,n4));
	}
}
