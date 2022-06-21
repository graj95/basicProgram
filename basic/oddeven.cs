using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class oddeven
    {
        static void Main(string [] args )
        {
            Console.WriteLine("Enter number ");
            int num = int.Parse(Console.ReadLine());
            if(num %2==0)
            {
                Console.WriteLine(num + "is even ");
            }
            else
            {
                Console.WriteLine(num + "is odd ");

            }
            
        }

    }
}
