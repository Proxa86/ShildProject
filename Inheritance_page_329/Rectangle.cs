namespace Inheritance_page_329
{
    public class Rectangle: TwoDShape
    {
        public bool IsSquare()
        {
            return Equals(Width, Height);
        }

        public double Area()
        {
            return Width * Height;
        }
    }
}