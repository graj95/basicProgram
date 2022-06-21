using System;
using System.Collections.Generic;
using System.Text;


namespace basic
{
    class equilateraltriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side of an equilateral triangle: ");
            int side = int.Parse(Console.ReadLine());

            Double area = (Math.Sqrt(3) / 4) * (side * side);
            
            
                Console.WriteLine( area  + " Area of equilateral triangle ");
            
           

        }
    }
}
