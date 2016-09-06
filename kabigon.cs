/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: kabigon.cs                        
//DATE: 27 Aug 2016                          
/////////////////////////////////////////////
using System;

namespace lab03
{
   class kabigon
   {
      static void paper(int iiii)
      {
         long round=0;
         long w = Convert.ToInt64(Console.ReadLine());
         long l = Convert.ToInt64(Console.ReadLine());
         char r = Convert.ToChar(Console.Read());
         //long numround[3];
			long[] numround;
			numround = new long[3];
         numround[0]=0;
         numround[1]=0;
         numround[2]=0;
//CODETOCOMPUTE BEGIN HERE
/*         while(w!=l)
         {
            //min=Math.Min(w,l);
				if(w<l)min=w;
				else min=l;
            if(w!=min)w-=min;
            if(l!=min)l-=min;
            numround[round%3]++;
//Console.WriteLine("{0} {1} {2}",round,w,l);
            round++;
         }
*/
			while(w!=0&&l!=0)
			{
				long maxx = Math.Max(w,l);
				long min = Math.Min(w,l);
				round+=maxx/min;
				if(w>l)w -= w/min*l;
				else l -= l/min*w;
			}
			numround[0]=numround[1]=numround[2]=round/3;
		//	long rr=0;
/*			while(w!=0||l!=0)
			{
				if(w==0) l--;
				else w--;
				numround[rr%3]++;
				rr++;
			}*/
			if ( round - round/3*3 ==1)
			{
				numround[0]++;
			}
			else if(round-round/3*3==2)
			{
				numround[0]++;
				numround[1]++;
			}
//END COMPUTE
			
//         numround[round%3]++;
         Console.WriteLine("Case #{0}:",iiii);
         Console.WriteLine(round);

         long max = 0;
         if(numround[0]>max)max = numround[0];
         if(numround[1]>max)max = numround[1];
         if(numround[2]>max)max = numround[2];
         //I F G
         if(r == 'I')
         {
            if(numround[0] == max)Console.Write("I ");
            if(numround[1] == max)Console.Write("F ");
            if(numround[2] == max)Console.Write("G ");
				Console.WriteLine();
         	Console.WriteLine("{0} {1} {2}",numround[0],numround[1],numround[2]);
         }
         else if(r == 'F')
         {
            if(numround[2] == max)Console.Write("I ");
            if(numround[0] == max)Console.Write("F ");
            if(numround[1] == max)Console.Write("G ");
				Console.WriteLine();
         	Console.WriteLine("{0} {1} {2}",numround[2],numround[0],numround[1]);
         }
         else if(r == 'G')
         {
            if(numround[1] == max)Console.Write("I ");
            if(numround[2] == max)Console.Write("F ");
            if(numround[0] == max)Console.Write("G ");
				Console.WriteLine();
         	Console.WriteLine("{0} {1} {2}",numround[1],numround[2],numround[0]);
         }
      }
      static void Main()
      {
         int t = int.Parse(Console.ReadLine());
         for(int i=0;i<t;i++)
         {
            paper(i+1);
         }
      }
   }
}
