/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: newton.cs                         
//DATE: 30 Aug 2016                          
/////////////////////////////////////////////
//BEGINNER STYLES
using System;
class newton
{
	static void findv1(double r0,double r,double v0,double v,double t,double a)
	{
		Console.Write("v = at+v0 = ");
		Console.WriteLine(a*t +v0);
	}
	static double findr1(double r0,double r,double v0,double v,double t,double a)
	{
		Console.Write("r = r0+v0t+at^2/2 = ");	
		Console.WriteLine(r0+v0*t+a*t*t/2);
		return r0+v0*t+a*t*t/2;
	}	
	static double findr2(double r0,double r,double v0,double v,double t,double a)
	{
		Console.Write("r = r0+((v+v0)/2)t = ");	
		Console.WriteLine(r0+( (v+v0)/2 )*t);
		return r0+((v+v0)/2)*t;
	}

	static void findv2(double r0,double r,double v0,double v,double t,double a)
	{
		Console.Write("v^2 = v0^2+2a(r-r0) = ");
		Console.WriteLine( Math.Pow(v0*v0 + 2*a*(r-r0) , 0.5) );
	}

	static double findr3(double r0,double r,double v0,double v,double t,double a)
	{
		Console.Write("r = r0 + vt-(at^2/2) = ");
		Console.WriteLine(r0 + v*t - (a*t*t/2) );
		return r0+v*t-(a*t*t/2);
	}

	static void input(out double r0,out double r,out double v0,out double v,out double t,out double a)
	{
		Console.Write("a = ");
		a = int.Parse(Console.ReadLine());
		Console.Write("r = ");
		r = int.Parse(Console.ReadLine());
		Console.Write("r0 = ");
		r0 = int.Parse(Console.ReadLine());
		Console.Write("v = ");
		v = int.Parse(Console.ReadLine());
		Console.Write("v0 = ");
		v0 = int.Parse(Console.ReadLine());
		Console.Write("t = ");
		t = int.Parse(Console.ReadLine());
	}
	static void Main()
	{
		double r0=0,r=0,v0=0,v=0,t=0,a=0;
		input(out r0,out r,out v0,out v,out t,out a);

		findv1( r0,r, v0, v, t, a);
		double eiei = findr1( r0, r, v0, v, t, a);
		double eiei1 = findr2( r0, r, v0, v, t, a);
		findv2( r0, r, v0, v, t, a);
		double eiei2 = findr3( r0, r, v0, v, t, a);

	}
}
