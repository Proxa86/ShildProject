using System;

namespace Inheritance_page_329
{
    public class Triangle6: TwoDShape6
    {
        private string _style;

        public Triangle6()
        {
            _style = null;
        }

        public Triangle6(string style, double pri):base(pri)
        {
            _style = style;
        }
        
        public Triangle6(string style, double width, double height):base(width,height)
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