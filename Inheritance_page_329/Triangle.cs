using System;

namespace Inheritance_page_329
{
    public class Triangle: TwoDShape
    {
        public string Style;

        public double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle "+ Style);
        }
    }
}