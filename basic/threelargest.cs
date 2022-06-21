using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class threelargest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2 ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number3 ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 >= num2 && num1 > num3)
            {
                Console.WriteLine(num1 + "is largest number  ");
            }
            else if ( num2 >= num1 && num2 >= num3)  
            {
                Console.WriteLine(num2 + "is largest number ");

            }
            else if (num3 >= num1 && num3 >= num2)
            {
                Console.WriteLine(num3 + "is largest number ");

            }

        }
    }
}
