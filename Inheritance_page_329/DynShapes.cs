using System;

namespace Inheritance_page_329
{
    public class DynShapes
    {
        public void Page_362()
        {
            TwoDShape8 [] shape8 = new TwoDShape8[5];
            
            shape8[0] = new Triangle8("rectangled", 8.0, 12.0);
            shape8[1] =  new Rectangle8(3.0,4.0);
            shape8[2] = new Rectangle8(6.0);
            shape8[3] =  new Triangle8("equals",4.0);
            shape8[4] = new TwoDShape8(10, 20, "Common forms");

            foreach (var t in shape8)
            {
                Console.WriteLine("object - "+ t.Name);
                Console.WriteLine("Area equals "+ t.Area());
                Console.WriteLine();
            }
            
        }
    }
}