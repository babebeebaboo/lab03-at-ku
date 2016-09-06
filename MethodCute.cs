/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: MethodCute.cs                     
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////


using System;
class MethodCute
{
	static void Main()
	{
		input();
	}
	static void input()
	{
		string b = "";
		string a ="BABE";
		while(a != "end")
		{
			a= Console.ReadLine();
			if(a == "Enter")
			{
				b = b+'\n';
			}
			else if(a=="end")
			{
				
			}
			else
			{
				b = b+a;
			}
		}
		Console.WriteLine(b);
	}

}
