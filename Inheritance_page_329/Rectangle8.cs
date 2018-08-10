namespace Inheritance_page_329
{
    public class Rectangle8:TwoDShape8
    {
        public Rectangle8(double w, double h) : base(w, h, "rectangle"){}
        
        public Rectangle8(double pri):base(pri, "rectangle"){}
        
        public Rectangle8(Rectangle8 ob):base(ob){}

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