using System;

namespace Inheritance_page_329
{
    public class Triangle9:TwoDShape9
    {
        private string _style;

        public Triangle9()
        {
            _style = null;
        }

        public Triangle9(string style, double pri):base(pri, "rectangle")
        {
            _style = style;
        }
        
        public Triangle9(string style, double width, double height):base(width,height, "rectangle")
        {
            _style = style;
        }

        public Triangle9(Triangle9 ob):base(ob)
        {
            _style = ob._style;
        }

        public override double Area()
        {
            return PriWidth*PriHeight /2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Triangle "+ _style);
        }
    }
}