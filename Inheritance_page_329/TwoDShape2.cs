using System;

namespace Inheritance_page_329
{
    public class TwoDShape2
    {
        private double _pri_width;
        private double _pri_height;

        public double Width
        {
            get => _pri_width;
            set => _pri_width = value < 0 ? -value : value;
        }

        public double Height
        {
            get => _pri_height;
            set => _pri_height = value < 0 ? -value : value;
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height equals: "+Width+" and "+ Height);
        }
    }
}