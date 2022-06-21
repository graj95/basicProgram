using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class Demo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number");
                int n = int.Parse(Console.ReadLine());
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException es)
            {
                Console.WriteLine(es.Message);
            }
          for( int i=0; i<=20; i++)
            {
                i += 2;
                Console.WriteLine(i);
            }

        }
    }


    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException( string msg):base(msg)
        {

        }

        public InvalidPasswordException()
        {

        }
    }



    class 
}
