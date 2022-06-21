using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class spicalcharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character ");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch >= '0' && ch<= '9')
            {
                Console.WriteLine(ch + "is Character is digit ");
            }
            else if(ch >= 'A' && ch <='Z')
            {
                Console.WriteLine(ch + "is Character is Capital Letter ");

            }
            else if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine(ch + "is Character is Small Letter ");

            }
            else
            {
                Console.WriteLine(ch + "is Character is Spical Character ");
            }


        }
    }
}
