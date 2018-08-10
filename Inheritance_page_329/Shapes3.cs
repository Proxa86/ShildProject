using System;

namespace Inheritance_page_329
{
    public class Shapes3
    {
        public void Page_338()
        {
            Triangle3 t1 =  new Triangle3("equals", 4.0, 4.0);
            Triangle3 t2 = new Triangle3("rectangular", 8.0,12.0);
            
            Console.WriteLine("Object #1: ");
            
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area: "+ t1.Area());

            Console.WriteLine("Object #2: ");
            
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area: "+ t2.Area());
        }
    }
}