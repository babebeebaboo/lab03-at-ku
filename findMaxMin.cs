/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: findMaxMin.cs                     
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
	class test01
	{
		static int findMax(int n1,int n2,int n3,int n4,int n5)
		{
			int max = n1;
			if(max<n2)max=n2;	
			if(max<n3)max=n3;	
			if(max<n4)max=n4;	
			if(max<n5)max=n5;
			return max;	
		}
		static int findMin(int n1,int n2,int n3,int n4,int n5)
		{
			int min = n1;
			if(min>n2)min=n2;	
			if(min>n3)min=n3;	
			if(min>n4)min=n4;	
			if(min>n5)min=n5;
			return min;	
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
			Console.Write("Input5: ");
			int n5 = int.Parse(Console.ReadLine());
			int max = findMax(n1,n2,n3,n4,n5);
			Console.WriteLine("Max is {0}",max);
			int min = findMin(n1,n2,n3,n4,n5);
			Console.WriteLine("Min is {0}",min);
		}
	}
}
