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
        {       //print nums from 1-100
            for (int i = 1; i <= 100; i++)
            //for multiple of 5&3, fizzbuzz
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                //for every multiple of 3,fizz
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }

                //for every multiple of 5,buzz
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                //prints next number
                else
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
