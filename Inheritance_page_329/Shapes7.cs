using System;

namespace Inheritance_page_329
{
    public class Shapes7
    {
        public void Page_354()
        {
            Triangle7 t1 =  new Triangle7("rectangeler",8.0, 12.0);
            Triangle7 t2 = new Triangle7(t1);
        
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