using System;

namespace Inheritance_page_329
{
    public class NoOverrideDemo2
    {
        public void Page_359()
        {
            Base3 baseob = new Base3();
            
            Derived7 derived7 =  new Derived7();
            

            Base3 baseref;
            
            baseob.Who();
            derived7.Who();
            
            Console.WriteLine();
            
            baseref = baseob;
            baseref.Who();
            Console.WriteLine();
            baseref = derived7;
            baseref.Who();
            
        }
    }
}