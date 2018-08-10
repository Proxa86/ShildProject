using System;

namespace Inheritance_page_329
{
    public class BaseRef
    {
        public void Page_352()
        {
            X2 x = new X2(10);

            X2 x2;
        
            Y2 y =  new Y2(3,5);

            x2 = x;
            Console.WriteLine("x2.a = "+x2.a);

            x2 = y;
            Console.WriteLine("x2.a = "+ x2.a);

            x2.a = 19;
            
        }
        
    }
}