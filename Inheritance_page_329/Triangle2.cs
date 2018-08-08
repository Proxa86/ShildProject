using System;

namespace Inheritance_page_329
{
    public class Triangle2 : TwoDShape2
    {
        public string Style;

        public double Area()
        {
            return Width * Height;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle "+ Style);
        }
    }
}