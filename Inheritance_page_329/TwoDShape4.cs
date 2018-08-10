using System;

namespace Inheritance_page_329
{
    public class TwoDShape4
    {
        private double _pri_width;
        private double _pri_height;

        public TwoDShape4(double priWidth, double priHeight)
        {
            PriWidth = priWidth;
            PriHeight = priHeight;
        }

        public double PriWidth
        {
            get => _pri_width;
            set => _pri_width = value < 0? -value: value;
        }

        public double PriHeight
        {
            get => _pri_height;
            set => _pri_height = value < 0 ? -value: value;
        }

        public void ShowDim()
        {
            Console.WriteLine("Width and height equals: "+ PriWidth + " "+ PriHeight);
        }
    }
}