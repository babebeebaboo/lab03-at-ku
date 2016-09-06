/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: overLoad.cs                       
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
namespace test
{
	class test01
	{
		static int get(int aa)
		{
			Console.Write("Input integer{0}: ",aa);	
			int a = int.Parse(Console.ReadLine());
			return a;
		}
		static char get(char aa)
		{
			Console.Write("Input character{0}: ",aa);	
			char a = Convert.ToChar(Console.Read());
			return a;
		}
		static string get(string aa)
		{
			Console.Write("Input {0}: ",aa);	
			string a = (Console.ReadLine());
			return a;	
		}
		static double something(int a,int b)
		{
			return (double)((double)b/(double)a);
		}
		static int something(char a,char b)
		{
			return ( (int)((a)+(b)) );
		}
		
		static void something(string a,string b)
		{	
			Console.WriteLine("First string is {0}",a);
			Console.WriteLine("Second string is {0}",b);
		}
		static void something(int a,int b,string c)
		{	
			Console.WriteLine("{0} is char",(char)b);
			Console.WriteLine("{0} is integer",a);
			Console.WriteLine("{0} is string",c);
		}

		static void Main()
		{

			int num1 = get(1);
			int num2 = get(2);
			char c1 = get('1');
			char c2 = get('2');
			string str1 = get("string1");
			string str2 = get("string2");
//Console.WriteLine("{0}{1}{2}{3}{4}{5}",num1,num2,c1,c2,str1,str2);
			
			double ans1=something(num1,num2);	
			Console.WriteLine(ans1);
			Console.WriteLine("-------------------------------");
			int ans2 = something(c1,c2);
			Console.WriteLine(ans2);
			Console.WriteLine("-------------------------------");
			something(str1,str2);

			Console.WriteLine("-------------------------------");
			something(num1,c1,str1);
		}
	}
}
