using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class swichdemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());

            switch (num % 2)
            {

                case 0:
                    Console.WriteLine(num + "is even number ");
                    break;
                case 1:
                    Console.WriteLine(num + "is odd number ");
                    break;



            }

        }
    }
}
