using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication56
{
    class Program
    {
        static void Main(string[] args)
        {//print nums from 1-100
            for (int i = 1; i <=100; i++)
            {//for every multiple of 3,fizz
                if (i%15==0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if(i % 5 == 0)
                    {
                    Console.WriteLine("buzz");
                    }
                else
                {
                    Console.WriteLine(i);
                }
            }
         
         //for every multiple of 5,buzz
         //for multiple of 5&3, fizzbuzz

        }
    }
}
