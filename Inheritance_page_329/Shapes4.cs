using System;

namespace Inheritance_page_329
{
    public class Shapes4
    {
        public void Page_341()
        {
            Triangle4 t1 =  new Triangle4("equals", 4.0, 4.0);
            Triangle4 t2 = new Triangle4("rectangular", 8.0,12.0);
            
            Console.WriteLine("Object #1: ");
            
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area: "+ t1.Area());

            Console.WriteLine();
            Console.WriteLine("Object #2: ");
            
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area: "+ t2.Area());
        }
    }
}