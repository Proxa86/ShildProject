using System;

namespace Inheritance_page_329
{
    public class OverrideDemo
    {
        public void Page_357()
        {
            Base baseob = new Base();
            
            Derived1 derived1 =  new Derived1();
            Derived2 derived2 = new Derived2();

            Base baseref;
            
            baseob.Who();
            derived1.Who();
            derived2.Who();
            Console.WriteLine();
            baseref = baseob;
            baseref.Who();
            Console.WriteLine();
            baseref = derived1;
            baseref.Who();
            Console.WriteLine();
            baseref = derived2;
            baseref.Who();
        }
    }
}