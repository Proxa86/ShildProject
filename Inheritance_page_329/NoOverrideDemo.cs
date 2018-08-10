using System;

namespace Inheritance_page_329
{
    public class NoOverrideDemo
    {
        public void Page_358()
        {
            Base2 baseob = new Base2();
            
            Derived3 derived3 =  new Derived3();
            Derived4 derived4 = new Derived4();

            Base2 baseref;
            
            baseob.Who();
            derived3.Who();
            derived4.Who();
            Console.WriteLine();
            baseref = baseob;
            baseref.Who();
            Console.WriteLine();
            baseref = derived3;
            baseref.Who();
            Console.WriteLine();
            baseref = derived4;
            baseref.Who();
        }
    }
}