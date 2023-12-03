using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1) User 2 rəqəm daxil etsin, bu iki rəqəm arasında olan cüt rəqəmlərin kvadratları cəmini qaytarsın.

            Console.WriteLine("reqemleri daxil edin :");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1 = int.Parse(input1);
            int num2 = int.Parse(input2);

            int sum = 0;

            for (int i = num1; i < num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i * i;  
                }
            }
            Console.WriteLine($"kvadratlarin cemi:  {sum}");

        }
    }
}
