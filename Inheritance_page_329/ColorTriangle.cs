using System;

namespace Inheritance_page_329
{
    public class ColorTriangle:Triangle6
    {
        private string _color;

        public ColorTriangle(string c, string s, double w, double h): base (s, w, h)
        {
            _color = c;
        }

        public void ShowColor()
        {
            Console.WriteLine("Color: "+ _color);
        }
    }
}