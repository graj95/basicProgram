using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class checkLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year :");
            int year = int.Parse(Console.ReadLine());
            if ((year %4 ==0) && (year %100 != 0)|| (year %400 == 0))
                {
                Console.WriteLine("is a leap year :"+ year);

            }
            else
            {
                Console.WriteLine(" is not a leap year :"+ year);
            }
        }
    }
}
