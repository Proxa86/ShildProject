using System;

namespace Inheritance_page_329
{
    public class Triangle3: TwoDShape3
    {
        private string _style;

        public Triangle3(string style, double width, double height)
        {
            _style = style;
            PriWidth = width;
            PriHeight = height;
        }

        public double Area()
        {
            return PriHeight * PriWidth /2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle "+ _style);
        }
    }
}