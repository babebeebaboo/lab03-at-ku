/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: sphere.cs                         
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
class sphere
{
	static void get(out double a)
	{
		Console.Write("Diameter:");
		a=double.Parse(Console.ReadLine())/2;
	}
	static void area(double a)
	{
		Console.WriteLine("Sphere's area = {0}",4.0*Math.PI*a*a);
	}
	static void volume(double a)
	{
		Console.WriteLine("Sphere's area = {0}",4.0/3.0*Math.PI*a*a*a);
	}
	static void Main()
	{
		double a;
		get(out a);
		area(a);
		volume(a);
	}
}
