using System;

namespace Inheritance_page_329
{
    public class TwoDShape8
    {
        private double _pri_width;
        private double _pri_height;

        public TwoDShape8()
        {
            PriHeight = PriWidth = 0.0;
            Name = "";
        }

        public TwoDShape8(double pri, string n)
        {
            PriHeight = PriWidth = pri;
            Name = n;
        }
        
        public TwoDShape8(double priWidth, double priHeight, string n)
        {
            PriWidth = priWidth;
            PriHeight = priHeight;
            Name = n;
        }

        public TwoDShape8(TwoDShape8 ob)
        {
            PriHeight = ob.PriHeight;
            PriWidth = ob.PriWidth;
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

        public string Name { get; set; }

        public void ShowDim()
        {
            Console.WriteLine("Width and height equals: "+ PriWidth + " "+ PriHeight);
        }

        public virtual double Area()
        {
            Console.WriteLine("Method Area() must redefined.");
            return 0.0;
        }
    }
}