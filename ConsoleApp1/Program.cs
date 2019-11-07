using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            
                      for(int i = 0; i < 10; i++)
                      {
                         list.Add(random.Next(1, 200));
                 
                      }
                       
                       for(int i = 0; i < 10; i++)
                       {
                              Console.WriteLine("Dnia " + i + " Musisz poglaskac bambo tyle razy: " + list[i]);
                       }
                          
        }
    }
}
