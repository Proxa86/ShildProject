using System;

namespace Inheritance_page_329
{
    public class Triangle5:TwoDShape5
    {
        private string _style;

        public Triangle5()
        {
            _style = null;
        }

        public Triangle5(string style, double pri):base(pri)
        {
            _style = style;
        }
        
        public Triangle5(string style, double width, double height):base(width,height)
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