/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: MyMath.cs                         
//DATE: 28 Aug 2016                          
/////////////////////////////////////////////

using System;
class MyMath
{
	static void Main()
	{
		Console.WriteLine(MyMath.sin(30) );
		Console.WriteLine(MyMath.cos(30) );
		Console.WriteLine(MyMath.tan(30) );
		Console.WriteLine(MyMath.min(1e-5,1e-8) );
		Console.WriteLine(MyMath.max(3e+20,5e+14) );
		Console.WriteLine(MyMath.sqrt(19) );
		Console.WriteLine(MyMath.abs(-12) );
		Console.WriteLine(MyMath.pow(21,14) );
		Console.WriteLine(MyMath.fac(25) );
		Console.WriteLine(MyMath.round(2.5) );
		Console.WriteLine(MyMath.ceiling(2.5) );
		Console.WriteLine(MyMath.floor(3.5) );
		Console.WriteLine(MyMath.pi);
		Console.WriteLine(MyMath.e);
	}
	static double sqrt(double a)
	{
		double x=1e-8;
		double xn;
		int i;
		for( i=0;i*i<=a;i++);
		xn=i;
		while(MyMath.abs(xn-x)>=1e-8)
		{
			x=xn;
			xn= 0.5*(x+a/x);
		}
		return xn;
	}
	static int round(double a)
	{
		if(MyMath.floor(a) %2==0) return (int)MyMath.floor(a);
		else return (int) MyMath.ceiling(a);
	}
	static double pi = MyMath.pi2();
	static double pi2()
	{
		double minus=1.0;
		double ans=3;
		for(int i=2;(i)*(i+1)*(i+2) <=8120400 ;i+=2)
		{
			ans += 4.0/( i*(i+1)*(i+2) ) * minus;
			minus*=-1;
		}
		return ans;
	}
	static int ceiling(double a)
	{
		return (int)a+1;
	}
	static int floor(double a)
	{
		return (int)a;
	}
	static double e = MyMath.pow(1.01,100);
	static double abs(double a)
	{
		if(a<=0)return -a;
		else return a;
	}
	static double pow(double a,int b)
	{
		double cc=a;
		for(int i=1;i<b;i++)a*=cc;
		return a;
	}
	static double pow(int a,int b)
	{
		int cc=a;
		long ans=a;
		for(int i=1;i<b;i++)ans*=cc;
		return ans;
	}
	static double sin(int a)
	{
		double rad = (a*MyMath.pi) / 180.0 ;
		double sum = 0;
		int kuy = 1;
		for(int i = 1;i<=19;i+=2)
		{
			sum += (MyMath.pow(rad,i)/fac(i))*kuy;
			kuy *= -1;	
		}
		return sum;
	}
	static double cos(int a)
	{
		return MyMath.sqrt(1-MyMath.pow(MyMath.sin(a),2)) ;
	}
	static double tan(int a)
	{
		return MyMath.sin(a)/MyMath.cos(a);
	}
	static double min(double a,double b)
	{
		if (a<b)return a;
		else return b;
	}
	static double max(double a,double b)
	{
		if(a<b)return b;
		else return a;
	}
	static double fac(int a)
	{
		if(a<=1)return 1;
		else return a*fac(a-1);	
	}			
}
