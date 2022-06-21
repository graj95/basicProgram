using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class swichdemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter week number (1-7): ");
            int week = int.Parse(Console.ReadLine());


            switch (week)
            {

                case 1:
                    Console.WriteLine("Monday ");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("friday ");
                    break;
                case 6:
                    Console.WriteLine("Saturday ");
                    break;
                case 7:
                    Console.WriteLine("Sunday ");
                    break;
                default:
                    Console.WriteLine("not a day valid ");
                    break;



            }

        }
    }
}
