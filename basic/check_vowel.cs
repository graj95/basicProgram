using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class check_vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your alphabet ");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a' || ch=='e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("is a small vowel :"+ch);
            }
            else if ( ch=='A'|| ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U'  )
            {
                Console.WriteLine(" is a capital vowel :"+ch);
            }
            else
            {
                Console.WriteLine(" is a consonant:"+ ch);
            }
            

            
               
        }
    }
}
