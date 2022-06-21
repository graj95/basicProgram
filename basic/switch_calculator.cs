using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class switch_calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number  ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number  ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter operand (+, -, /, *): ");
            string operand = Console.ReadLine();


            switch (operand)
            {

                case "+":
                    Console.WriteLine("Addition = "+ ( num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Substraction= "+ (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Multiplication= "+(num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("division = "+ (num1 / num2));
                    break;
               
                   
                default:
                    Console.WriteLine("not a operand ");
                    break;



            }

        }
    }
}
