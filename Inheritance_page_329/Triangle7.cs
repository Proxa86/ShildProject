using System;

namespace Inheritance_page_329
{
    public class Triangle7: TwoDShape7
    {
        private string _style;

        public Triangle7()
        {
            _style = null;
        }

        public Triangle7(string style, double pri):base(pri)
        {
            _style = style;
        }
        
        public Triangle7(string style, double width, double height):base(width,height)
        {
            _style = style;
        }

        public Triangle7(Triangle7 ob):base(ob)
        {
            _style = ob._style;
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