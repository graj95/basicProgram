using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class break_amount
    {
        static void Main(string[] args)
        {
            int amt, total;
            Console.WriteLine(" Enter input the amount :");
             amt = int.Parse(Console.ReadLine());
             total = (int)amt / 2000;
            Console.WriteLine("Ther are :");
            Console.WriteLine("Note(s) of 2000.00 :" + total);
             amt = amt - (total * 2000);

             total = (int)amt / 1000;
            Console.WriteLine("Note(s) of 1000.00 :" + total);
            amt = amt - (total * 1000);

            total = (int)amt / 500;
            Console.WriteLine("Note(s) of 500.00 :" + total);
            amt = amt - (total * 500);

            total = (int)amt / 200;
            Console.WriteLine("Note(s) of 200.00 :" + total);
            amt = amt - (total * 200);

            total = (int)amt / 100;
            Console.WriteLine("Note(s) of 100.00 :" + total);
            amt = amt - (total * 100);

            total = (int)amt / 50;
            Console.WriteLine("Note(s) of 50.00 :" + total);
            amt = amt - (total * 50);

            total = (int)amt / 20;
            Console.WriteLine("Note(s) of 20.00 :" + total);
            amt = amt - (total * 20);

            total = (int)amt / 10;
            Console.WriteLine("Note(s) of 10.00 :" + total);
            amt = amt - (total * 10);

            total = (int)amt / 1;
            Console.WriteLine("Note(s) of 1.00 :" + total);
            amt = amt - (total * 1);

        }
    }
}
