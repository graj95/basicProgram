using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class subjectsmarks
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter english marks ");
            float eng = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter physics marks ");
            float phy = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter chemistry marks ");
            float che = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter math marks ");
            float math = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter computer marks ");
            float comp = float.Parse(Console.ReadLine());

            float total = eng + phy + che + math + comp;
            float average = total / 5;
            float percentage = (total / 500) * 100;

            Console.WriteLine(total  + "is total marks ");
            Console.WriteLine(average + "is Average marks ");
            Console.WriteLine(percentage + "is Percentage  ");







        }
    }
}
