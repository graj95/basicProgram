using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    class swicharea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Area of a circle \n 2. Area of a square \n 3. Area of a right angled triangle " +
                "\n 4.  Area of a rectangle\n 5.  Circumference of a circle \n 6.Perimeter of a square ");
            int choice = int.Parse(Console.ReadLine());

            switch( choice)
            {
                case 1:
                    {
                        float radius, area;
                       
                        Console.WriteLine("Enter Radius of circle");
                        radius = float.Parse(Console.ReadLine());
                        area = (float)3.141 * radius * radius;
                        Console.WriteLine("Area of a circle :"+area);

                        break;


                    }
                case 2:
                    {
                        float side, area;
                        Console.WriteLine("Enter side of square ");
                        side = float.Parse(Console.ReadLine());
                        area = side * side;
                        Console.WriteLine("Area of a square:" + area);
                        break;
                    }
                case 3:
                    {
                        float Base,height, area;
                        Console.WriteLine("Enter base of triangle ");
                        Base= float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height of triangle ");
                        height = float.Parse(Console.ReadLine());
                        area =  (float)0.5* Base * height;
                        Console.WriteLine("Area of a right angled triangle:" + area);
                        break;
                    }
                case 4:
                    {
                        float Base, height, area;
                        Console.WriteLine("Enter base of rectangle ");
                        Base = float.Parse(Console.ReadLine());
                        Console.WriteLine("Enter height of rectangle ");
                        height = float.Parse(Console.ReadLine());
                        area =  Base * height;
                        Console.WriteLine("Area of a rectangle:" + area);
                        break;
                    }
                case 5:
                    {
                        float radius, area;

                        Console.WriteLine("Enter Radius of circle");
                        radius = float.Parse(Console.ReadLine());
                        area = (float)3.141 * radius * 2;
                        Console.WriteLine("Circumference of a circle :" + area);
                        break;
                    }
                case 6:
                    {
                        float side, per;
                        Console.WriteLine("Enter side of square ");
                        side = float.Parse(Console.ReadLine());
                        per = 4 * side;
                        Console.WriteLine("Perimeter of a square:" + per);
                        break;
                    }
                default:
                    Console.WriteLine("number are nit exit ");
                    break;
            }
        }
    }
}
