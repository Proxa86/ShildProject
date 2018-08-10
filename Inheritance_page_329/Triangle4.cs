using System;

namespace Inheritance_page_329
{
    public class Triangle4: TwoDShape4
    {
        private string _style;

        public Triangle4(string style, double width, double height):base(width,height)
        {
            _style = style;
        }

        public double Area()
        {
            return PriWidth*PriHeight /2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle "+ _style);
        }
    }
}