using System;

namespace Operator_page_97
{
    public class RelLogOps
    {
        public void Page_102()
        {
            int i = 10, j = 11;
            if(i < j) Console.WriteLine("If true to [i < j]");
            if(i <= j) Console.WriteLine("If true to [i <= j]");
            if(i != j) Console.WriteLine("If true to [i != j]");
            if( i == j) Console.WriteLine("If true to [i==j]");
            if(i>= j) Console.WriteLine("If true to [i >= j]");
            if(i > j) Console.WriteLine("if true to [i > j]");

            bool b1 = true, b2 = false;

            Console.WriteLine("If b1 = {0} and b2 = {1}" , b1, b2);
            Console.WriteLine("If b1 & b2 = " + (b1 & b2));
            Console.WriteLine("If !(b1 & b2) = "+ !(b1 & b2));
            Console.WriteLine("If b1 | b2 = "+ (b1 | b2));
            Console.WriteLine("If b1 ^ b2 = "+ (b1 ^ b2));
                
            
        }
    }
}