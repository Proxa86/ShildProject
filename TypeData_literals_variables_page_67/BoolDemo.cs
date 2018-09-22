using System;

namespace TypeData_literals_variables_page_67
{
    public class BoolDemo
    {
        public void Page_75()
        {
            bool b = false;
            Console.WriteLine("b equals " + b);
            b = true;
            Console.WriteLine("b equals " + b);
            
            if(b) Console.WriteLine("Do");
            b = false;
            if(b) Console.WriteLine("No do");

            Console.WriteLine("10 > 9 equals "+(10 >9));
        }
    }
}