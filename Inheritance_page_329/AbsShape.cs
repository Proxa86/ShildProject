using System;

namespace Inheritance_page_329
{
    public class AbsShape
    {
        public void Page_366()
        {
            TwoDShape9 [] shape9 = new TwoDShape9[4];
            
            shape9[0] = new Triangle9("rectangled", 8.0, 12.0);
            shape9[1] =  new Rectangle9(3.0,4.0);
            shape9[2] = new Rectangle9(6.0);
            shape9[3] =  new Triangle9("equals",4.0);
            

            foreach (var t in shape9)
            {
                Console.WriteLine("object - "+ t.Name);
                Console.WriteLine("Area equals "+ t.Area());
                Console.WriteLine();
            }
        }
    }
}