using System;

namespace Operator_page_97
{
    public class SCops
    {
        public void Page_105()
        {
            int n = 10, d = 2;
            
            if(d != 0 && (n % d == 0))
                Console.WriteLine(n + " div "+ d+" with residue.");

            d = 0;
            if( d != 0 && (n % d == 0))
                Console.WriteLine(n + " div "+ d+" with residue.");
            
            if( d != 0 & (n % d == 0))
                Console.WriteLine(n + " div "+ d+" with residue.");
        }
    }
}