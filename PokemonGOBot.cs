/////////////////////////////////////////////
//NAME: Supakorn Wongsawang                  
//ID: 5910500147                             
//PROGRAM: PokemonGOBot.cs                   
//DATE: 25 Aug 2016                          
/////////////////////////////////////////////

//UNFINISHED

using System;

namespace test
{
    class Program
    {
        static int PokeMonGo()
        {
            int ix = int.Parse(Console.ReadLine());
            int iy = int.Parse(Console.ReadLine());
            int ex = int.Parse(Console.ReadLine());
            int ey = int.Parse(Console.ReadLine());

            string direction = Console.ReadLine();
            while (true)
            {
                for (int i = 0; i < direction.Length; i++)
                {
                    if (direction[i] == 'U') iy++;
                    else if (direction[i] == 'D') iy--;
                    else if (direction[i] == 'L') ix--;
                    else if (direction[i] == 'R') ix++;

                    if (ix == ex && iy == ey)
                    {
                        Console.WriteLine("Yes");
                        return 0;
                    }
                    if (ix == 1000000000 || iy == 1000000000) {
                        Console.WriteLine("No");
                        return 0;
                    }
                    Console.WriteLine("{0} {1}", ix, iy);
                }
            }
            
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++) PokeMonGo();

            Console.ReadLine();
        }
    }
}

