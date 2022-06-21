using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class electricitybill
    {
        static void Main(string[] args)
        {
            Double amt, total_amt, sur_charge;

            Console.WriteLine("Enter total units consumed: ");
            int unit = int.Parse(Console.ReadLine());
            if (unit <= 50)
            {
                amt = unit * 0.50;
            }
            else if (unit <=150)
            {
                amt = 25 + ((unit - 50) * 0.75); 

            }
            else if (unit <= 250)
            {
                amt = 100 + ((unit - 150) * 1.20);

            }
            else 
            {
                amt = 220 + ((unit - 250) * 1.50);

            }
            sur_charge = amt * 0.20;
            total_amt = amt + sur_charge;
            Console.WriteLine(total_amt  + "Electricity Bill ");
        }
    }




    class demo
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }
        }
    }
}
