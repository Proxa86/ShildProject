using System;

namespace Inheritance_page_329
{
    public class Shapes5
    {
        public void Page_342()
        {
            Triangle5 t1 = new Triangle5();
            Triangle5 t2 =  new Triangle5("equals", 4.0, 4.0);
            Triangle5 t3 = new Triangle5("rectangular", 8.0);

            t1 = t2;
            
            Console.WriteLine("Object #1: ");
            
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area: "+ t1.Area());

            Console.WriteLine();
            Console.WriteLine("Object #2: ");
            
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area: "+ t2.Area());
            
            Console.WriteLine();
            Console.WriteLine("Object #3: ");
            
            t3.ShowStyle();
            t3.ShowDim();
            Console.WriteLine("Area: "+ t3.Area());
        }
    }
}