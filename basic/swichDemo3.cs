using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class swichDemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word number (1-7): ");
            int word = int.Parse(Console.ReadLine());


            switch (word)
            {

                case 1:
                    Console.WriteLine("One ");
                    break;
                case 2:
                    Console.WriteLine("Two ");
                    break;
                case 3:
                    Console.WriteLine("Three ");
                    break;
                case 4:
                    Console.WriteLine("Four ");
                    break;
                case 5:
                    Console.WriteLine("Five  ");
                    break;
                case 6:
                    Console.WriteLine("Six ");
                    break;
                case 7:
                    Console.WriteLine("Seven ");
                    break;
                default:
                    Console.WriteLine("not a valid number ");
                    break;



            }

        }
    }
}
