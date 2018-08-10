using System;

namespace Inheritance_page_329
{
    public class Shapes6
    {
        public void Page_348()
        {
            ColorTriangle t1 =  new ColorTriangle("blue", "rectangeler",8.0, 12.0);
            ColorTriangle t2 = new ColorTriangle("red", "equals", 2.0, 2.0);
        
            Console.WriteLine("Object #1: ");
            
            t1.ShowStyle();
            t1.ShowDim();
            t1.ShowColor();
            Console.WriteLine("Area: "+ t1.Area());

            Console.WriteLine();
            Console.WriteLine("Object #2: ");
            
            t2.ShowStyle();
            t2.ShowDim();
            t2.ShowColor();
            Console.WriteLine("Area: "+ t2.Area());
        }
        
    }
}