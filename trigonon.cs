/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: trigonon.cs                       
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
class test
{
	static int fac(int i)
	{
		if(i<=1)return 1;
		else return i*fac(i-1);
	}
	static double sin(double rad)
	{
		double sum = 0;
		int kuy = 1;
		for(int i = 1;i<=19;i+=2)
		{
			sum += (Math.Pow(rad,i)/fac(i))*kuy;
			kuy *= -1;	
		}
		return sum;
	}
	static void Main()
	{
		double a = int.Parse(Console.ReadLine())*Math.PI/180.0;
		double sina=sin(a);
		Console.WriteLine("sin({0}) = {1}",a/Math.PI*180,sina);
		Console.WriteLine("cos({0}) = {1:f2}",a/Math.PI*180,Math.Sqrt(1-Math.Pow(sina,2)) );
		Console.WriteLine("tan({0}) = {1:f2}",a/Math.PI*180,sina / Math.Sqrt(1-Math.Pow(sina,2)) );
	}
}
