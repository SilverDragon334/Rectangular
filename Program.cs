using System;


namespace Rectangles
{
    class Rectangles
    {
        public static Random random = new Random();
        static int length;
        static int width;
        static int min;
        static int max;
        static float area;
        static float perimeter;
        static string n;
        static string nn;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the minimum length for your rectangle!");
            n = Console.ReadLine();
            min = Convert.ToInt32(n);
            Console.WriteLine("Now enter the max length!");
            nn = Console.ReadLine();
            max = Convert.ToInt32(nn);
            MakeRectangles(out length, out width);
            Calculation(out area, out perimeter);
          
            Console.Write("Length = "); Console.WriteLine(length);
            Console.Write("Width = "); Console.WriteLine(width);
            Console.Write("Perimeter = "); Console.WriteLine(perimeter);
            Console.Write("Area = "); Console.WriteLine(area);
        }

        

        static void MakeRectangles(out int length, out int width)
        {
            
            length = random.Next(min, max);
            width = random.Next(min, max);
        }
        static void Calculation(out float area, out float perimeter)
        {
            area = (length * width);
            perimeter = (length * 2) + (width * 2);
            
        }

    }
}
