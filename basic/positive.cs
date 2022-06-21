using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class positive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());
            if (num >0)
            {
                Console.WriteLine(num + "is +ve ");
            }
            else
            {
                Console.WriteLine(num + "is -ve ");

            }

        }
    }
}
