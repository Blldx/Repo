using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            for(int i = 0; i < 15; i++)
            {
                list.Add(random.Next(1, 12345));
            }

            for(int i = 0; i < 15; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(list[i]);
                }
            }


        }
    }
}
