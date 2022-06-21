using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class gross
    {
        static void Main(string[] args)
        {
            int salary, gross, hra, da;
            Console.WriteLine("Enter the basic salary of the employee ");
             salary= int.Parse(Console.ReadLine());

            if (salary <=10000 )
            {
                da = salary * 20 / 100;
                hra = salary * 80 / 100;
                gross = salary + da + hra;

                Console.WriteLine(gross + "The gross salary of the employee is ");
            }
            else if (salary <= 20000)
            {
                da = salary * 25 / 100;
                hra = salary * 90 / 100;
                gross = salary + da + hra;
                Console.WriteLine(gross + "the gross salary of employee ");

            }
            else if (salary > 20000)
            {
                da = salary * 30 / 100;
                hra = salary * 95 / 100;
                gross = salary + da + hra;
                Console.WriteLine(gross + "the gross salary of employee ");

            }
            else
            {
                Console.WriteLine("you have no salary ");
            }

        }

    }
}
