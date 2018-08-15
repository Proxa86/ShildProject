namespace Inheritance_page_329
{
    public class Rectangle9:TwoDShape9
    {
        public Rectangle9(double w, double h) : base(w, h, "rectangle"){}
        
        public Rectangle9(double pri):base(pri, "rectangle"){}
        
        public Rectangle9(Rectangle9 ob):base(ob){}

        public bool IsSquare()
        {
            return Equals(PriHeight, PriWidth);
        }

        public override double Area()
        {
            return PriHeight * PriWidth;
        }
    }
}