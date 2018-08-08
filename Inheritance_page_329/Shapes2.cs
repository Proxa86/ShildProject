using System;

namespace Inheritance_page_329
{
    public class Shapes2
    {

        public void Page_335()
        {
            Triangle2 t1 =  new Triangle2();
            Triangle2 t2 = new Triangle2();

            t1.Width = 4.0;
            t1.Height = 4.0;
            t1.Style = "equals thighs";

            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "rectangular";

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