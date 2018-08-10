using System;

namespace Inheritance_page_329
{
    public class Triangle8:TwoDShape8
    {
        private string _style;

        public Triangle8()
        {
            _style = null;
        }

        public Triangle8(string style, double pri):base(pri, "rectangle")
        {
            _style = style;
        }
        
        public Triangle8(string style, double width, double height):base(width,height, "rectangle")
        {
            _style = style;
        }

        public Triangle8(Triangle8 ob):base(ob)
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