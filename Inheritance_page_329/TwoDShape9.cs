using System;

namespace Inheritance_page_329
{
    public abstract class TwoDShape9
    {
        private double _pri_width;
        private double _pri_height;

        public TwoDShape9()
        {
            PriHeight = PriWidth = 0.0;
            Name = "";
        }

        public TwoDShape9(double pri, string n)
        {
            PriHeight = PriWidth = pri;
            Name = n;
        }
        
        public TwoDShape9(double priWidth, double priHeight, string n)
        {
            PriWidth = priWidth;
            PriHeight = priHeight;
            Name = n;
        }

        public TwoDShape9(TwoDShape9 ob)
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

        public abstract double Area(); 
    }
}