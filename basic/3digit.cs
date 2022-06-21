using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class _3digit
    {
        static void Main(string[] args)
        {
            int num, sum = 0, firstDigit, lastDigit;
            Console.WriteLine(" Enter a number :");
            num = int.Parse(Console.ReadLine());

            if( num > 99 && num <1000 )
            {
                Console.WriteLine("is a 3 digit number :" +num);
                lastDigit = num % 10;
                while(num>=10)
                {
                    num = num / 10;
                }
                firstDigit = num;

                sum = firstDigit + lastDigit;

                Console.WriteLine(" sum of first and last digit : " +sum);
            }
            else
            {
                Console.WriteLine(" is not a 3 digit number :" + num);
            }
        }
    }
}
