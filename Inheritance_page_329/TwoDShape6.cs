using System;

namespace Inheritance_page_329
{
    public class TwoDShape6
    {
        private double _pri_width;
        private double _pri_height;

        public TwoDShape6()
        {
            PriHeight = PriWidth = 0.0;
        }

        public TwoDShape6(double pri)
        {
            PriHeight = PriWidth = pri;
        }
        
        public TwoDShape6(double priWidth, double priHeight)
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