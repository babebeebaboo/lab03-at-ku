/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: a_z_cycle2.cs                     
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////
using System;
class program
{
	static int input_num()
	{
		Console.Write("Input your number :");
		return int.Parse(Console.ReadLine());
	}
	static int input_ascii()
	{
		Console.Write("Character : ");
		return Console.Read();
	}
	static int output_ascii(int num,int asc)
	{
		int mod = num%26;
		asc +=mod;
		if(asc>122)asc = 96+asc-122;
		else if(asc<97)asc = 123-97+asc;
		return asc;
	}

	static void print_output(int a)
	{
		Console.Write("Output character :");
		Console.WriteLine((char)a);
	}
	static void Main()
	{
		int num = input_num();
		int ascii = input_ascii();
		Console.WriteLine();
		int ans = output_ascii(num,ascii);
		print_output(ans);
	}
}

